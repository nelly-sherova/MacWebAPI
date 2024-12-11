using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;
        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        public Product GetProduct(int productId)
        {
            return context.Products.Where(p => p.Id == productId).FirstOrDefault();
        }

        public ICollection<Product> GetProducts()
        {
            return context.Products.OrderBy(p => p.Id).ToList();
        }

    }
}
