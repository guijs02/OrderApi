using OrderApi.Core.Models;
using OrderApi.Core.Response;

namespace OrderApi.Core.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<Response<Order>> ProcessSaleAsync(Order order);
    }
}
