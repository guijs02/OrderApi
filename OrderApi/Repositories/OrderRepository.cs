using Microsoft.EntityFrameworkCore;
using OrderApi.Config;
using OrderApi.Context;
using OrderApi.Core.Extension;
using OrderApi.Core.Interfaces.Repositories;
using OrderApi.Core.Models;
using OrderApi.Core.Response;
using OrderApi.Core.Summary;

namespace OrderApi.Repositories
{
    public class OrderRepository(AppDbContext context) : IOrderRepository
    {
        public async Task<PagedResponse<List<Order>>> GetAllByPagedAsync(int pageNumber, int pageSize)
        {
            var totalRecords = context.Orders.Count();

            var totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

            var orders = await context.Orders
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(f => f)
                .Include(f => f.Customer)
                .Include(i => i.Itens)
                .ToListAsync();

            return new PagedResponse<List<Order>>(orders, pageNumber, pageSize, totalPages);
        }
        public async Task<Response<Order>> GetOrderAsync(Guid id)
        {
            var order = await context.Orders.Include(i => i.Itens)
                                                 .Include(i => i.Customer)
                                                 .AsNoTracking()
                                                 .FirstOrDefaultAsync(w => w.Id == id);

            return order is null ?
                            new Response<Order>(null, ResponseMessages.OrderNotFound, StatusCodes.Status404NotFound)
                            :
                            new Response<Order>(order);
        }

        public async Task<Response<Order>> ProcessSaleAsync(Order order)
        {
            try
            {
                await context.Database.BeginTransactionAsync();

                if (await VerifyClientIdAlreadyExists(order.Customer.Id))
                {
                    return new Response<Order>(null, ResponseMessages.ClientIdAlreadyExist, StatusCodes.Status409Conflict);
                }

                var orderObj = context.Orders.Add(order);
                await context.SaveChangesAsync();

                BillingSummary summary = new BillingSummary()
                {
                    Discount = order.Discount,
                    Itens = order.Itens.ToItensSummary(),
                    TotalAmount = order.TotalAmount - order.Discount,
                    Id = orderObj.Entity.Id,
                    SubTotal = order.TotalAmount
                };

                var result = await SentSummaryToServiceBillingAsync(summary);

                orderObj.Entity.Status = result.isSuccess;

                context.Orders.Update(orderObj.Entity);
                await context.SaveChangesAsync();

                await context.Database.CommitTransactionAsync();

                return new Response<Order>(orderObj.Entity, ResponseMessages.OrderProcessedWithSuccess, StatusCodes.Status201Created);
            }
            catch (Exception e)
            {
                return new Response<Order>(null, e.Message, StatusCodes.Status500InternalServerError);
            }
        }

        public async Task<ResponseBillingApi> SentSummaryToServiceBillingAsync(BillingSummary summary)
        {
            try
            {
                using HttpClient client = new();

                client.DefaultRequestHeaders.Add("email", Configuration.EmailRequest);
                var response = await client.PostAsJsonAsync(Configuration.BillingApiUrl, summary);

                response.EnsureSuccessStatusCode();

                return new ResponseBillingApi(response.IsSuccessStatusCode, string.Empty);

            }
            catch (Exception e)
            {
                return new ResponseBillingApi(false, e.Message);
            }
        }
        public async Task<bool> VerifyClientIdAlreadyExists(Guid id) =>
             await context.Orders.AnyAsync(a => a.Customer.Id == id);
    }
}
