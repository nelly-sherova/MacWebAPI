using MacWebApi.Data;
using MacWebApi.Data.Models;
using MacWebApi.Interfaces;

namespace MacWebApi.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext context; 
        public RoleRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Role> GetRoles()
        {
            return context.Roles.OrderBy(r => r.Id).ToList();
        }
    }
}
