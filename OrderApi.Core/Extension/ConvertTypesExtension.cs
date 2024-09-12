using OrderApi.Core.Dtos;
using OrderApi.Core.Models;

namespace OrderApi.Core.Extension
{
    public static class ConvertTypesExtension
    {
        public static List<Itens> ToItens(this List<CreateItensDto> dtos) =>
             dtos.Select(d => new Itens
             {
                 Description = d.Description,
                 Price = d.Price.RoundToTwoDecimalPlaces(),
                 ProductId = d.ProductId,
                 Amount = d.Amount,
             })
           .ToList();

        public static Order ToOrder(this CreateOrderDto dto) =>
             new Order
             {
                 Customer = new()
                 {
                     Category = dto.Customer.Category,
                     Cpf = dto.Customer.Cpf,
                     Name = dto.Customer.Name,
                     Id = dto.Customer.CustomerId,
                 },
                 SaleDate = dto.SaleDate,
                 Itens = dto.Itens.ToItens()
             };

    }
}
