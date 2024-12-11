using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.RoleRepositories
{
    public interface IRoleRepository
    {
        ICollection<Role> GetRoles();
        Role GetRole(int id);
    }
}
