using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.Role
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext context;
        public RoleRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Data.Models.Role> GetRoles()
        {
            return context.Roles.OrderBy(r => r.Id).ToList();
        }
    }
}
