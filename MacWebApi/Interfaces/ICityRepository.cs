using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public interface ICityRepository
    {
        ICollection<City> GetCities();
    }
}
