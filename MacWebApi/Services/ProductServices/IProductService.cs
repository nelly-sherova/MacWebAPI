using MacWebApi.Data.Models;

namespace MacWebApi.Services.ProductServices
{
    public interface IProductService
    {
        ICollection<Product> GetProducts();

        bool IsExist(int  productId);
        ICollection<Product> GetSaleProducts();
        ICollection<Product> Search(string name);
        Product GetProduct(int productId);
        ICollection<Product> GetExistsProducts();


    }
}
