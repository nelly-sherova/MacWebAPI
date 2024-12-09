using MacWebApi.Data.Models;
using MacWebApi.Repositories.CityRepository;

namespace MacWebApi.Services.CityServices
{
    public class CityService : ICityService
    {
        private ICityRepository cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public ICollection<City> GetCities()
        {
            return cityRepository.GetCities();
        }

        public City GetCity(int id)
        {
            return cityRepository.GetCity(id);
        }
    }
}
