using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
{
    public class CityReppository : ICityRepository
    {
        private readonly DataContext context; 
        public CityReppository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<City> GetCities()
        {
            return context.Cities.OrderBy(c=>c.Id).ToList();    
        }
    }
}
