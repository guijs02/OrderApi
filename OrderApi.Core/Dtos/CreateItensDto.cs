using OrderApi.Core.Extension;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateItensDto
    {
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
