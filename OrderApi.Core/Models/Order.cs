using OrderApi.Core.Extension;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Models
{
    public class Order
    {
        [JsonPropertyName("identificador")]
        public Guid Id { get; set; }
        [JsonPropertyName("dataVenda")]
        public DateTime SaleDate { get; set; }
        [JsonPropertyName("cliente")]
        public virtual Customer Customer { get; set; } = null!;
        [JsonIgnore]
        public int CustomerId { get; set; }
        [JsonPropertyName("itens")]
        public List<Itens> Itens { get; set; } = null!;
        [JsonPropertyName("valorTotal")]
        public decimal TotalAmount { get; set; }
        [JsonPropertyName("Desconto")]
        public decimal Discount { get; set; }
        public bool Status { get; set; }

    }
}
