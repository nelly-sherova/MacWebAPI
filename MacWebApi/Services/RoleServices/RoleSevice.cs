using MacWebApi.Data.Models;
using MacWebApi.Repositories.RoleRepositories;

namespace MacWebApi.Services.RoleServices
{
    public class RoleSevice : IRoleService
    {
        private IRoleRepository roleRepository;
        public RoleSevice(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public Role GetRole(int roleId)
        {
            return roleRepository.GetRole(roleId);
        }

        public ICollection<Role> GetRoles()
        {
            return roleRepository.GetRoles();
        }
    }
}
