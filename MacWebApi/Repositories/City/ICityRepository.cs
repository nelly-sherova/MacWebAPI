using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.City
{
    public interface ICityRepository
    {
        ICollection<Data.Models.City> GetCities();
    }
}
