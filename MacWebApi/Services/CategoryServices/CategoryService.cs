using MacWebApi.Data.Models;
using MacWebApi.Repositories;
using MacWebApi.Repositories.CategoryRepositories;

namespace MacWebApi.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public ICollection<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

        public ICollection<Category> GetCategoriesNyName(string categoryName)
        {
            return categoryRepository.GetCategories().Where(c => c.Name.Contains(categoryName)).ToList();
        }

        Category ICategoryService.GetCategory(int id)
        {
            return categoryRepository.GetCategory(id);
        }
    }
}
