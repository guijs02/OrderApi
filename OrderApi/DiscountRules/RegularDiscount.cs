using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class RegularDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public Order Discount(Order order)
        {
            NextDiscount = new PremiumDiscount();

            if (HasDiscount(order))
            {
                order.Discount = order.TotalAmount * 0.05m;
                return order;
            }
            return NextDiscount.Discount(order);
        }

        public bool HasDiscount(Order order) =>
            string.Equals(nameof(ECategory.Regular),
            order.Customer.Category, StringComparison.CurrentCultureIgnoreCase)
            && order.TotalAmount > 500;
    }
}
