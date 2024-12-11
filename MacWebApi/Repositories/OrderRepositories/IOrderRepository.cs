using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.OrderCategories
{
    public interface IOrderRepository
    {
        ICollection<Order> GetOrders();
        Order GetOrder(int id);
    }
}
