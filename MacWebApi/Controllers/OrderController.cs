using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;
using MacWebApi.Services.OrderServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MacWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IMapper mapper;
        private readonly IOrderService orderService; 
        public OrderController(IMapper mapper, IOrderService orderService)
        {
            this.mapper = mapper;
            this.orderService = orderService;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<City>))]
        public IActionResult GetOrders()
        {
            var orders = mapper.Map<List<OrderDto>>(orderService.GetOrders());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(orders);
        }
        [HttpGet("bydate")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetOrdersByDate(DateTime? startDate, DateTime? endDate)
        {
            var orders = mapper.Map<List<Order>>(orderService.GetAllOrderdsByDate(startDate, endDate));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(orders);
        }
        [HttpGet("togoes")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetAllToGoes()
        {
            var orders = mapper.Map<List<Order>>(orderService.GetAllToGoes());  
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(orders);
        }
        [HttpGet("intheholls")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetAllInTheHolls()
        {
            var orders = mapper.Map<List<Order>>(orderService.GetAllInTheHolls());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(orders);
        }
    }
}
