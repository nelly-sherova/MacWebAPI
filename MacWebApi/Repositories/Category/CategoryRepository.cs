using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Data.Models.Category> GetCategories()
        {
            return _context.Categories.OrderBy(c => c.Id).ToList();
        }

    }
}
