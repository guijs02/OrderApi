using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi.Core.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
