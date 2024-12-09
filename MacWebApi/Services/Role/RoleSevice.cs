using MacWebApi.Interfaces;

namespace MacWebApi.Services.Role
{
    public class RoleSevice : IRoleService
    {
        private IRoleRepository roleRepository; 
        public RoleSevice(IRoleRepository roleRepository) 
        {
            this.roleRepository = roleRepository;
        }
        public ICollection<Data.Models.Role> GetRoles()
        {
            return roleRepository.GetRoles();
        }
    }
}
