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

    }
}
