using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class VipDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        public Order Discount(Order order)
        {
            if (string.Equals(nameof(ECategory.Vip),
              order.Customer.Category, StringComparison.CurrentCultureIgnoreCase))
            {
                order.Discount = order.TotalAmount * 0.15m;
                return order;
            }
            return order;
        }
    }
}
