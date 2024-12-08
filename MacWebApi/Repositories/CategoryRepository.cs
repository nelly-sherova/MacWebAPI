using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private  DataContext _context; 
        public CategoryRepository(DataContext context) 
        {
            _context = context;
        }
        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }
    }
}
