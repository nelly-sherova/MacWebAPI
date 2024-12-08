namespace MacWebApi.Services.Category
{
    public interface ICategoryService
    {
        ICollection<Data.Models.Category> GetCategories();
    }
}
