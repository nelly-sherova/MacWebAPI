using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;
        public UserRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Data.Models.User> GetUsers()
        {
            return context.Users.OrderBy(x => x.Id).ToList();
        }
    }
}
