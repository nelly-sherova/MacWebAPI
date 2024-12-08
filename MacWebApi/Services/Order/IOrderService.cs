namespace MacWebApi.Services.Order
{
    public interface IOrderService
    {
        ICollection<Data.Models.Order> GetOrders(); 
    }
}
