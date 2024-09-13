using OrderApi.Core.Config;
using OrderApi.Core.Dtos;
using OrderApi.Core.Models;
using OrderApi.Core.Response;

namespace OrderApi.Core.Interfaces.Services
{
    public interface IOrderService
    {
        Task<Response<Order>> ProcessSaleAsync(CreateOrderDto dto);
        Task<Response<Order>> GetOrderAsync(Guid id);
        Task<PagedResponse<List<Order>>> GetOrdersAsync(int pageNumber, int pageSize);
    }
}
