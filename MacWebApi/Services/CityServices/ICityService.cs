using MacWebApi.Data.Models;

namespace MacWebApi.Services.CityServices
{
    public interface ICityService
    {
        ICollection<City> GetCities();
        City GetCity(int  id);
    }
}
