using MacWebApi.Data.Models;

namespace MacWebApi.Services.CategoryServices
{
    public interface ICategoryService
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Category> GetCategoriesNyName(string categoryName);

    }
}
