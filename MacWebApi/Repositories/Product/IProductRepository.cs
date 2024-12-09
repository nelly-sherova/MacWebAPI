using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Product
{
    public interface IProductRepository
    {
        ICollection<Data.Models.Product> GetProducts();
    }
}
