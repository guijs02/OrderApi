using OrderApi.Core.Extension;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateOrderDto
    {
        public DateTime SaleDate { get; set; }
        public CreateCustomerDto Customer { get; set; } = null!;
        public List<CreateItensDto> Itens { get; set; } = null!;
       
    }
}
