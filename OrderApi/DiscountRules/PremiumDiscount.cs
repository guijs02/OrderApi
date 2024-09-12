
using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class PremiumDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        public Order Discount(Order order)
        {
            NextDiscount = new VipDiscount();

            if (string.Equals(nameof(ECategory.Premium),
            order.Customer.Category, StringComparison.CurrentCultureIgnoreCase) &&
            order.TotalAmount > 300)
            {
                order.Discount = order.TotalAmount * 0.1m;
                return order;
            }
            return NextDiscount.Discount(order);
        }
    }
}
