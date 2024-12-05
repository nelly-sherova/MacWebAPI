using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
    }
}
