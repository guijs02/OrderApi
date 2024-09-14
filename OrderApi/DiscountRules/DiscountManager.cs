using OrderApi.Core.Enum;
using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class DiscountManager
    {
        public Order Discount(Order order)
        {
            IDiscount regularDiscount = new RegularDiscount();
            var orderWithTotalAmount = new TotalAmountCalculator().Calculate(order);
            return regularDiscount.Discount(orderWithTotalAmount);
        }

        public static bool IsCustomerOfCategory(Order order, ECategory category) =>
         string.Equals(category.ToString(),
            order.Customer.Category, StringComparison.CurrentCultureIgnoreCase);
    }
}
