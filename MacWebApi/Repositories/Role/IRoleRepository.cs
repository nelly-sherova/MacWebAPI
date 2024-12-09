using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Role
{
    public interface IRoleRepository
    {
        ICollection<Data.Models.Role> GetRoles();
    }
}
