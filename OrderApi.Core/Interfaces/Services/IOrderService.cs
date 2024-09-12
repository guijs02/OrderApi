using OrderApi.Core.Dtos;
using OrderApi.Core.Models;
using OrderApi.Core.Response;

namespace OrderApi.Core.Interfaces.Services
{
    public interface IOrderService
    {
        Task<Response<Order>> ProcessSaleAsync(CreateOrderDto dto);
    }
}
