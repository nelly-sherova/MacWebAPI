using MacWebApi.Data.Models;
using MacWebApi.Interfaces;
using System.Security.AccessControl;

namespace MacWebApi.Services.Prduct
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository; 
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ICollection<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }
    }
}
