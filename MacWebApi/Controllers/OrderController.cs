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
        [HttpGet("bydelivery/{IsDelivery}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetAllOrderdsByDateIsDelivery(DateTime? dateStart, DateTime? dateEnd, bool IsDelivery)
        {
            var orders = mapper.Map<List<Order>>(orderService.GetAllOrderdsByDateIsDelivery(dateStart, dateEnd, IsDelivery));
            if (!ModelState.IsValid) return BadRequest();
            return Ok(orders);
        }

        [HttpGet("bygo/{IsTogo}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetAllOrderdsByDateIsToGo(DateTime? dateStart, DateTime? dateEnd, bool IsTogo)
        {
            var orders = mapper.Map<List<Order>>(orderService.GetAllOrderdsByDateIsToGo(dateStart, dateEnd, IsTogo));
            if (!ModelState.IsValid) return BadRequest();
            return Ok(orders);
        }
        [HttpGet("bystatus/{Status}")]
        [ProducesResponseType(200, Type =typeof(IEnumerable<Order>))]
        public IActionResult GetOrdersByStatus(DateTime? dateStart, DateTime? dateEnd, int Status)
        {
            var orders = orderService.GetOrdersByStatus(dateStart, dateEnd, Status);
            if (!ModelState.IsValid) return BadRequest();
            return Ok(orders);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(City))]
        [ProducesResponseType(400)]
        public IActionResult GetOrder(int id)
        {
            var order = orderService.GetOrder(id);
            if(!ModelState.IsValid) return BadRequest();
            return Ok(order);
        }
    }
}
