using OrderApi.Core.Extension;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace OrderApi.Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; }
        public virtual Customer Customer { get; set; } = null!;
        public int CustomerId { get; set; }
        public List<Itens> Itens { get; set; } = null!;
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }

    }
}
