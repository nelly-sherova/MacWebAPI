using MacWebApi.Data.Models;
using MacWebApi.Repositories.OrderCategories;

namespace MacWebApi.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public ICollection<Order> GetOrders()
        {
            return orderRepository.GetOrders();
        }
        public ICollection<Order> GetAllOrderdsByDate(DateTime? dateStart, DateTime? dateEnd, bool isToGo)
        {
            var orders = orderRepository.GetOrders();

            if (!dateStart.HasValue && !dateEnd.HasValue)
            {
                return orders.Where(o => o.IsToGo == isToGo).OrderBy(o => o.DateCreate).ToList();
            }

            if (dateStart.HasValue && !dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate == dateStart && o.IsToGo == isToGo).ToList();
            }
            else if (dateStart.HasValue && dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate >= dateStart && o.DateCreate <= dateEnd && o.IsToGo == isToGo).ToList();
            }

            return orders;
        }

        public ICollection<Order> GetAllToGoes()
        {
            return orderRepository.GetOrders().Where(c => c.IsToGo == true).ToList();
        }
        public ICollection<Order> GetAllInTheHolls()
        {
            return orderRepository.GetOrders().Where(c => c.IsToGo == false).ToList();
        }
        
    }
}
