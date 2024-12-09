using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.CityRepository
{
    public class CityRepository : ICityRepository
    {
        private DataContext context;
        public CityRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<City> GetCities()
        {
            return context.Cities.OrderBy(c => c.Id).ToList();
        }

        public City GetCity(int id)
        {
            return context.Cities.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
