using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
    }
}
