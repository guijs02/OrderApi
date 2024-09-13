using System.Text.Json.Serialization;

namespace OrderApi.Core.Summary
{
    public class BillingSummary
    {
        [JsonPropertyName("identificador")]
        public Guid Id { get; set; }
        [JsonPropertyName("subTotal")]
        public decimal SubTotal { get; set; }
        [JsonPropertyName("descontos")]
        public decimal Discount { get; set; }
        [JsonPropertyName("valorTotal")]
        public decimal TotalAmount { get; set; }
        [JsonPropertyName("itens")]
        public List<ItensSummary> Itens { get; set; } = null!;

    }
    public class ItensSummary
    {
        [JsonPropertyName("quantidade")]
        public decimal Amount { get; set; }
        [JsonPropertyName("precoUnitario")]
        public decimal Price { get; set; }
    }
}
