using Microsoft.AspNetCore.Mvc;
using RabbitMQ.API.Entities.Dtos;
using RabbitMQ.API.Entities.Models;
using RabbitMQ.API.Services;

namespace RabbitMQ.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMessageProducer _messagePublisher;
        public OrdersController(IMessageProducer messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        /// <summary>
        /// Create order
        /// </summary>
        /// <param name="orderDto">OrderDto</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Route("CreateOrder")]
        public async Task<IActionResult> CreateOrder(OrderDto orderDto)
        {
            Order order = new()
            {
                ProductName = orderDto.ProductName,
                Price = orderDto.Price,
                Quantity = orderDto.Quantity
            };

            await _messagePublisher.SendMessageAsync(order);

            return Ok(new { id = order.Id });
        }
    }
}