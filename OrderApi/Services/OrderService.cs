﻿using OrderApi.Core.Dtos;
using OrderApi.Core.Extension;
using OrderApi.Core.Interfaces.Repositories;
using OrderApi.Core.Interfaces.Services;
using OrderApi.Core.Models;
using OrderApi.Core.Response;
using OrderApi.DiscountRules;
namespace OrderApi.Services
{
    public class OrderService(IOrderRepository orderRepository) : IOrderService
    {
        private readonly IOrderRepository _orderRepository = orderRepository;
        public async Task<Response<Order>> ProcessSaleAsync(CreateOrderDto dto)
        {
            var orderObj = dto.ToOrder();

            var DiscountOrder = new DiscountManager().Discount(orderObj);

            DiscountOrder.Discount = DiscountOrder.Discount.RoundToTwoDecimalPlaces();

            var response = await _orderRepository.ProcessSaleAsync(DiscountOrder);

            return response;
        }

        public async Task<PagedResponse<List<Order>>> GetOrdersAsync(int pageNumber, int pageSize) =>
             await _orderRepository.GetAllByPagedAsync(pageNumber, pageSize);

        public async Task<Response<Order>> GetOrderAsync(Guid id) =>
             await _orderRepository.GetOrderAsync(id);

    }
}
