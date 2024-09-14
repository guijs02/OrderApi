using OrderApi.Core.Enum;
using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class VipDiscount : IDiscount
    {
        public IDiscount NextDiscount { get; set; }
        private const decimal DiscountRate = 0.15m;
        public Order Discount(Order order)
        {
            if (HasDiscount(order))
            {
                order.Discount = order.TotalAmount * DiscountRate;
                return order;
            }
            return order;
        }

        public bool HasDiscount(Order order) =>
            DiscountManager.IsCustomerOfCategory(order, ECategory.Vip);
    }

}
