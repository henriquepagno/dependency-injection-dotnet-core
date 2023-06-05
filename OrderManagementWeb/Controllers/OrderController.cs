using Microsoft.AspNetCore.Mvc;
using OrderManagement.Interfaces;
using OrderManagement.Models;

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;

        public OrderController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        [HttpPost]
        public ActionResult<string> Post(Order order)
        {
            return Ok(_orderManager.Transmit(order));
        }
    }
}