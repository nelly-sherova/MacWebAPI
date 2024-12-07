using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
    }
}
