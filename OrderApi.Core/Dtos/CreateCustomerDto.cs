namespace OrderApi.Core.Dtos
{
    public record CreateCustomerDto
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Category { get; set; } = null!;
    }
}
