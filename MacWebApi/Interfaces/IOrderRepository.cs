using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
    }
}
