using System.Threading.Tasks;
using OrderManagement.Interfaces;
using OrderManagement.Models;

namespace OrderManagement
{
    public class OrderManager : IOrderManager
    {
        private readonly IOrderSender _orderSender;

        public OrderManager(IOrderSender orderSender)
        {
            _orderSender = orderSender;
        }

        public async Task<string> Transmit(Order order)
        {
            return await _orderSender.Send(order);
        }
    }
}