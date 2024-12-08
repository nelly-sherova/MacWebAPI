using MacWebApi.Interfaces;

namespace MacWebApi.Services.Order
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository; 
        public OrderService(IOrderRepository orderRepository) 
        {
            this.orderRepository = orderRepository;
        }

        public ICollection<Data.Models.Order> GetOrders()
        {
            return orderRepository.GetOrders();
        }
    }
}
