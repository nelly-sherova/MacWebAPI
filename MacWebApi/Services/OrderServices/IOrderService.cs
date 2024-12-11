using MacWebApi.Data.Models;
using System.Collections.ObjectModel;

namespace MacWebApi.Services.OrderServices
{
    public interface IOrderService
    {
        ICollection<Order> GetOrders();
        ICollection<Order> GetAllOrderdsByDateIsDelivery(DateTime? dateStart, DateTime? dateEnd, bool IsDelivery);
        ICollection<Order> GetAllOrderdsByDateIsToGo(DateTime? dateStart, DateTime? dateEnd, bool IsTogo);
        ICollection<Order> GetAllOrderdsByDate(DateTime? dateStart, DateTime? dateEnd);
        ICollection<Order> GetOrdersByStatus(DateTime? dateStart, DateTime? dateEnd, int Status);
        public Order GetOrder(int id);


    }
}
