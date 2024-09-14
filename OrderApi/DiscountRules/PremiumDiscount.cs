
using OrderApi.Core.Enum;
using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class PremiumDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        private const decimal DiscountRate = 0.1m;
        private const decimal MinimumAmountForDiscount = 300;
        public Order Discount(Order order)
        {
            NextDiscount = new VipDiscount();

            if (HasDiscount(order))
            {
                order.Discount = order.TotalAmount * DiscountRate;
                return order;
            }
            return NextDiscount.Discount(order);
        }

        public bool HasDiscount(Order order) =>
          DiscountManager.IsCustomerOfCategory(order, ECategory.Premium)
          && order.TotalAmount > MinimumAmountForDiscount;
    }
}
