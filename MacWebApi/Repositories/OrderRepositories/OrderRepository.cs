using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.OrderCategories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext context;
        public OrderRepository(DataContext context)
        {
            this.context = context;
        }

        public Order GetOrder(int id)
        {
            return context.Orders.Where(o => o.Id == id).FirstOrDefault();
        }

        public ICollection<Order> GetOrders()
        {
            return context.Orders.OrderBy(o => o.Id).ToList();
        }
        
    }
}
