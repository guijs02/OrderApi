using OrderApi.Context;
using OrderApi.Core.Interfaces.Repositories;
using OrderApi.Core.Models;
using OrderApi.Core.Response;

namespace OrderApi.Repositories
{
    public class OrderRepository(AppDbContext context) : IOrderRepository
    {
        public async Task<Response<Order>> ProcessSaleAsync(Order order)
        {
            var orderObj = context.Orders.Add(order);
            await context.SaveChangesAsync();
            return new Response<Order>(orderObj.Entity, "Venda processada com sucesso!", StatusCodes.Status201Created);
        }
    }
}
