namespace OrderApi.Core.Models
{
    public class Itens
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set; } = null!;
        public int Amount { get; set; }
        public decimal Price { get; set; }

    }
}
