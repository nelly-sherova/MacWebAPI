using MacWebApi.Data.Models;
using MacWebApi.Repositories.ProductRepository;
using System.Security.AccessControl;

namespace MacWebApi.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ICollection<Product> GetExistsProducts()
        {
            return productRepository.GetProducts().Where(p => p.Exist == true).ToList();
        }

        public Product GetProduct(int productId)
        {
            return productRepository.GetProduct(productId);
        }

        public ICollection<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public ICollection<Product> GetSaleProducts()
        {
            return productRepository.GetProducts().Where(p => p.SalePersent > 0).ToList();
        }

        public bool IsExist(int productId)
        {
            return (productRepository.GetProduct(productId)).Exist;
        }

        public ICollection<Product> Search(string name)
        {
            return productRepository.GetProducts().Where(p => p.Name.Contains(name)).ToList();      
        }
    }
}
