namespace OrderApi.Core.Summary
{
    public class BillingSummary
    {
        public int Id { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public List<ItensSummary> Itens { get; set; } = null!;

    }
    public class ItensSummary
    {
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
