using OrderApi.Core.Models;

namespace OrderApi.DiscountRules
{
    public class TotalAmountCalculator
    {
        public Order Calculate(Order order)
        {
            order.TotalAmount = order.Itens.Sum(o => o.Amount * o.Price);

            return order;
        }
    }
}
