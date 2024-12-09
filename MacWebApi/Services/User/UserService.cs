using MacWebApi.Interfaces;

namespace MacWebApi.Services.User
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;  
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public ICollection<Data.Models.User> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
