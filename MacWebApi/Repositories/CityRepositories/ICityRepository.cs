using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.CityRepository
{
    public interface ICityRepository
    {
        ICollection<City> GetCities();
        City GetCity(int id);
    }
}
