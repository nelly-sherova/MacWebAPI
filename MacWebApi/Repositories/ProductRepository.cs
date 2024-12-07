using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context; 
        public ProductRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Product> GetProducts()
        {
            return context.Products.OrderBy(p => p.Id).ToList();  
        }
    }
}
