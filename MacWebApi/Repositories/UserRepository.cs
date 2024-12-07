using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context; 
        public UserRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<User> GetUsers()
        {
            return context.Users.OrderBy(x => x.Id).ToList();
        }
    }
}
