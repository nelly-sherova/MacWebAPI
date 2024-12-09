using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Order
{
    public interface IOrderRepository
    {
        ICollection<Data.Models.Order> GetOrders();
    }
}
