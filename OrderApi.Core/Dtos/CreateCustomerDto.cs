using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateCustomerDto
    {
        [JsonPropertyName("clienteId")]
        public Guid CustomerId { get; set; }
        [JsonPropertyName("nome")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("cpf")]
        public string Cpf { get; set; } = null!;
        [JsonPropertyName("categoria")]
        public string Category { get; set; } = null!;
    }
}
