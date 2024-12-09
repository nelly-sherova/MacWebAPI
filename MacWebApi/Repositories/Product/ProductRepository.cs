using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;
        public ProductRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Data.Models.Product> GetProducts()
        {
            return context.Products.OrderBy(p => p.Id).ToList();
        }
    }
}
