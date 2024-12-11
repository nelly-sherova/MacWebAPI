using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        ICollection<Data.Models.Product> GetProducts();
        Product GetProduct(int productId);
    }
}
