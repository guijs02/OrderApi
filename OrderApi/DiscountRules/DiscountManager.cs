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
    }
}
