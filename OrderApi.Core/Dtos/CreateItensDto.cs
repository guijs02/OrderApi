using OrderApi.Core.Extension;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Dtos
{
    public record CreateItensDto
    {
        public int ProductId { get; set; }
        public string Description { get; set; } = null!;
        public int Amount { get; set; }
        public decimal Price { get; set; }
    }
}
