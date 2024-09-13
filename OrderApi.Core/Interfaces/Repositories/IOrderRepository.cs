using OrderApi.Core.Models;
using OrderApi.Core.Response;
using OrderApi.Core.Summary;

namespace OrderApi.Core.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task<PagedResponse<List<Order>>> GetAllByPagedAsync(int pageNumber, int pageSize);
        Task<Response<Order>> GetOrderAsync(Guid id);
        Task<Response<Order>> ProcessSaleAsync(Order order);
        Task<ResponseBillingApi> SentSummaryToServiceBillingAsync(BillingSummary summary);
    }
}
