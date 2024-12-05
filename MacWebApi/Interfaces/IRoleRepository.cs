using MacWebApi.Data.Models;

namespace MacWebApi.Interfaces
{
    public interface IRoleRepository
    {
        ICollection<Role> GetRoles();
    }
}
