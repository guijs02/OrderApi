using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class VipDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        public Order Discount(Order order)
        {
            if (HasDiscount(order))
            {
                order.Discount = order.TotalAmount * 0.15m;
                return order;
            }
            return order;
        }

        public bool HasDiscount(Order order) =>
            string.Equals(nameof(ECategory.Regular),
            order.Customer.Category, StringComparison.CurrentCultureIgnoreCase)
            && order.TotalAmount > 500;
    }

}
