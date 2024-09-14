using OrderApi.Core.Enum;
using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class RegularDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        private const decimal DiscountRate = 0.05m;
        private const decimal MinimumAmountForDiscount = 500;
        public Order Discount(Order order)
        {
            NextDiscount = new PremiumDiscount();

            if (HasDiscount(order))
            {
                order.Discount = order.TotalAmount * DiscountRate;
                return order;
            }
            return NextDiscount.Discount(order);
        }

        public bool HasDiscount(Order order) =>
            DiscountManager.IsCustomerOfCategory(order, ECategory.Regular)
            && order.TotalAmount > MinimumAmountForDiscount;
    }
}
