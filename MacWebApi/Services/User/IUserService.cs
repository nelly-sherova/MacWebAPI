namespace MacWebApi.Services.User
{
    public interface IUserService
    {
        ICollection<Data.Models.User> GetUsers();
    }
}
