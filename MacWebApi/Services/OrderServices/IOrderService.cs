using MacWebApi.Data.Models;
using System.Collections.ObjectModel;

namespace MacWebApi.Services.OrderServices
{
    public interface IOrderService
    {
        ICollection<Order> GetOrders();
        ICollection<Order> GetAllOrderdsByDate(DateTime? dateStart, DateTime? dateEnd, bool IsTogo);
        ICollection<Order> GetAllToGoes();
        ICollection<Order> GetAllInTheHolls();
    }
}
