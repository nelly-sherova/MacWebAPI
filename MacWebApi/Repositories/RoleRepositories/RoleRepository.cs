using MacWebApi.Data;
using MacWebApi.Data.Models;

namespace MacWebApi.Repositories.RoleRepositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext context;
        public RoleRepository(DataContext context)
        {
            this.context = context;
        }

        public Role GetRole(int id)
        {
            return context.Roles.Where(r => r.Id == id).FirstOrDefault();
        }

        public ICollection<Role> GetRoles()
        {
            return context.Roles.OrderBy(r => r.Id).ToList();
        }
    }
}
