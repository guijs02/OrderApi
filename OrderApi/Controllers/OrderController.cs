using Microsoft.AspNetCore.Mvc;
using OrderApi.Core.Dtos;
using OrderApi.Core.Interfaces.Services;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController(IOrderService orderService) : ControllerBase
    {
        private IOrderService _orderService = orderService;

        [HttpPost]
        public async Task<IActionResult> ProcessSaleAsync(CreateOrderDto dto)
        {
            var response = await _orderService.ProcessSaleAsync(dto);

            return StatusCode(response.StatusCode, response.Data);
        }
        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var response = await _orderService.GetOrdersAsync(pageNumber, pageSize);

            return StatusCode(response.StatusCode, response.Data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder([FromRoute] Guid id)
        {
            var response = await _orderService.GetOrderAsync(id);

            return StatusCode(response.StatusCode, response.Data);
        }

    }
}
