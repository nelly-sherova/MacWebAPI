using MacWebApi.Repositories.City;

namespace MacWebApi.Services.City
{
    public class CityService : ICityService
    {
        private  ICityRepository cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public ICollection<Data.Models.City> GetCities()
        {
            return cityRepository.GetCities();
        }
    }
}
