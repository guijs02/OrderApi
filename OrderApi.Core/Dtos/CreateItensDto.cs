using OrderApi.Core.Extension;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateItensDto
    {
        [JsonPropertyName("produtoId")]
        [Required]
        public int ProductId { get; set; }
        [JsonPropertyName("descricao")]
        [Required]
        public string Description { get; set; } = null!;
        [JsonPropertyName("quantidade")]
        [Required]
        public int Amount { get; set; }
        [JsonPropertyName("precoUnitario")]
        [Required]
        public decimal Price { get; set; }
    }
}
