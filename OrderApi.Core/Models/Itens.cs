using System.Text.Json.Serialization;

namespace OrderApi.Core.Models
{
    public class Itens
    {
        public int Id { get; set; }
        [JsonPropertyName("produtoId")]
        public int ProductId { get; set; }
        [JsonPropertyName("descricao")]
        public string Description { get; set; } = null!;
        [JsonPropertyName("quantidade")]
        public int Amount { get; set; }
        [JsonPropertyName("precoUnitario")]
        public decimal Price { get; set; }

    }
}
