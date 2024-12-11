using MacWebApi.Data.Models;

namespace MacWebApi.Services.RoleServices
{
    public interface IRoleService
    {
        ICollection<Data.Models.Role> GetRoles();
        Role GetRole(int roleId);
    }
}
