using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext context;
        public OrderRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Order> GetOrders()
        {
            return context.Orders.OrderBy(o => o.Id).ToList();  
        }
    }
}
