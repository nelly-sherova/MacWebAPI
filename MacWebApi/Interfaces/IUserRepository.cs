using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public class IUserRepository
    {
        ICollection<User> GetUsers();
    }
}
