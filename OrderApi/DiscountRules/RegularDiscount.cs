using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class RegularDiscount : IDiscount
    {
        public RegularDiscount(IDiscount nextDiscount)
        {
            NextDiscount = nextDiscount;
        }

        public IDiscount NextDiscount { get; set; }

        public Order Discount(Order order)
        {
            if (string.Equals(nameof(ECategory.Regular),
                order.Customer.Category, StringComparison.CurrentCultureIgnoreCase)
                && order.TotalAmount > 500)
            {
                order.Discount = order.TotalAmount * 0.05m;
                return order;
            }
            return NextDiscount.Discount(order);
        }
    }
}
