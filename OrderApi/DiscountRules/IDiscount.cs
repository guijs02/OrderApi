using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public interface IDiscount
    {
        Order Discount(Order order);
        bool HasDiscount(Order order);
        IDiscount NextDiscount { get; set; }
    }
}