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
 
        public ICollection<Order> GetAllOrderdsByDate(DateTime? dateStart, DateTime? dateEnd)
        {
            var orders = orderRepository.GetOrders();

            if (!dateStart.HasValue && !dateEnd.HasValue)
            {
                return orders.OrderBy(o => o.DateCreate).ToList();
            }

            if (dateStart.HasValue && !dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate == dateStart).ToList();
            }
            else if (dateStart.HasValue && dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate >= dateStart && o.DateCreate <= dateEnd).ToList();
            }

            return orders;
        }
        public ICollection<Order> GetAllOrderdsByDateIsDelivery(DateTime? dateStart, DateTime? dateEnd, bool IsDelivery)
        {
            var orders = orderRepository.GetOrders();

            if (!dateStart.HasValue && !dateEnd.HasValue)
            {
                return orders.Where(o => o.IsDelivery == IsDelivery).OrderBy(o => o.DateCreate).ToList();
            }

            if (dateStart.HasValue && !dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate == dateStart && o.IsDelivery == IsDelivery).ToList();
            }
            else if (dateStart.HasValue && dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate >= dateStart && o.DateCreate <= dateEnd && o.IsDelivery == IsDelivery).ToList();
            }

            return orders;
        }

        public ICollection<Order> GetAllOrderdsByDateIsToGo(DateTime? dateStart, DateTime? dateEnd, bool IsTogo)
        {
            var orders = orderRepository.GetOrders();

            if (!dateStart.HasValue && !dateEnd.HasValue)
            {
                return orders.Where(o => o.IsToGo == IsTogo).OrderBy(o => o.DateCreate).ToList();
            }

            if (dateStart.HasValue && !dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate == dateStart && o.IsToGo == IsTogo).ToList();
            }
            else if (dateStart.HasValue && dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate >= dateStart && o.DateCreate <= dateEnd && o.IsToGo == IsTogo).ToList();
            }

            return orders;
        }

        public ICollection<Order> GetOrdersByStatus(DateTime? dateStart, DateTime? dateEnd, int Status)
        {
            var orders = orderRepository.GetOrders();
            if (!dateStart.HasValue && !dateEnd.HasValue)
            {
                return orders.Where(o => o.Status == Status && o.DateCreate == DateTime.Today).OrderBy(o => o.DateCreate).ToList();
            }
            if (dateStart.HasValue && !dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate == dateStart && o.Status == Status).ToList();
            }
            else if (dateStart.HasValue && dateEnd.HasValue)
            {
                orders = orders.Where(o => o.DateCreate >= dateStart && o.DateCreate <= dateEnd && o.Status == Status).ToList();
            }

            return orders;
        }
        public Order GetOrder(int id)
        {
            return orderRepository.GetOrder(id);
        }
    }
}
