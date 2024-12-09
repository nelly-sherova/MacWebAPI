using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext context;
        public OrderRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Data.Models.Order> GetOrders()
        {
            return context.Orders.OrderBy(o => o.Id).ToList();
        }
    }
}
