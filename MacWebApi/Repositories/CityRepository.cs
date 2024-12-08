using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
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
            return context.Cities.OrderBy(c=>c.Id).ToList();    
        }
    }
}
