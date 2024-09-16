using OrderApi.Core.Extension;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateOrderDto
    {
        [JsonPropertyName("dataVenda")]
        [Required]
        public DateTime SaleDate { get; set; }
        [JsonPropertyName("cliente")]
        public CreateCustomerDto Customer { get; set; } = null!;
        [JsonPropertyName("itens")]
        public List<CreateItensDto> Itens { get; set; } = null!;
       
    }
}
