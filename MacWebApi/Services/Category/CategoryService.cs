using MacWebApi.Interfaces;
using MacWebApi.Repositories;

namespace MacWebApi.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private  ICategoryRepository categoryRepository; 
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public ICollection<Data.Models.Category> GetCategories()
        {
           return categoryRepository.GetCategories();
        }
    }
}
