using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.User
{
    public interface IUserRepository
    {
        ICollection<Data.Models.User> GetUsers();
    }
}
