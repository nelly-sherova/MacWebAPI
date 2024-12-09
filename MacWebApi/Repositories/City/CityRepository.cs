using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.City
{
    public class CityRepository : ICityRepository
    {
        private DataContext context;
        public CityRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Data.Models.City> GetCities()
        {
            return context.Cities.OrderBy(c => c.Id).ToList();
        }
    }
}
