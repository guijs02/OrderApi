using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateCustomerDto
    {
        [JsonPropertyName("clienteId")]
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        [JsonPropertyName("nome")]
        public string Name { get; set; } = null!;

        [Required]
        [JsonPropertyName("cpf")]
        public string Cpf { get; set; } = null!;
        
        [JsonPropertyName("categoria")]
        public string Category { get; set; } = null!;
    }
}
