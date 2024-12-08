namespace MacWebApi.Services.City
{
    public interface ICityService
    {
        ICollection<Data.Models.City> GetCities();
    }
}
