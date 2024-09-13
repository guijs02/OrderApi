using OrderApi.Core.Dtos;
using OrderApi.Core.Extension;
using OrderApi.Core.Interfaces.Repositories;
using OrderApi.Core.Interfaces.Services;
using OrderApi.Core.Models;
using OrderApi.Core.Response;
using OrderApi.DiscountRules;
namespace OrderApi.Services
{
    public class OrderService(IOrderRepository orderRepository) : IOrderService
    {
        private readonly IOrderRepository _orderRepository = orderRepository;
        public async Task<Response<Order>> ProcessSaleAsync(CreateOrderDto dto)
        {
            var orderObj = dto.ToOrder();
            var DiscountOrder = new DiscountManager().Discount(orderObj);
            DiscountOrder.Discount = DiscountOrder.Discount.RoundToTwoDecimalPlaces();
            var response = await _orderRepository.ProcessSaleAsync(DiscountOrder);

            //if (response.Data != null)
            //{
            //    BillingSummary summary = new BillingSummary()
            //    {
            //        Discount = response.Data.Discount,
            //        Itens = response.Data.Itens.ToItensSummary(),
            //        TotalAmount = response.Data.TotalAmount - response.Data.Discount,
            //        Id = response.Data.Id,
            //        SubTotal = response.Data.TotalAmount,
            //    };

            //    var result = await SentSummaryToServiceBillingAsync(summary);

            //    return new Response<Order>(orderObj);

            //}

            return response;
        }

        public async Task<PagedResponse<List<Order>>> GetOrdersAsync(int pageNumber, int pageSize)
        {
            return await _orderRepository.GetAllByPagedAsync(pageNumber, pageSize);
        }

        public async Task<Response<Order>> GetOrderAsync(Guid id)
        {
            return await _orderRepository.GetOrderAsync(id);
        }

    }
}
