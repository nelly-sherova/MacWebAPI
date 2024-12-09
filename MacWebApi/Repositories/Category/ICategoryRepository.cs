using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Category
{
    public interface ICategoryRepository
    {
        ICollection<Data.Models.Category> GetCategories();
    }
}
