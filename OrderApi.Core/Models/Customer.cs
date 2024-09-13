using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrderApi.Core.Models
{
    public class Customer
    {
        [JsonPropertyName("clienteId")]
        public Guid Id { get; set; } = new Guid();  
        [JsonPropertyName("nome")]
        public string Name { get; set; } = null!;
        [JsonPropertyName("cpf")]
        public string Cpf { get; set; } = null!;
        [JsonPropertyName("categoria")]
        public string Category { get; set; } = null!;
    }
}
