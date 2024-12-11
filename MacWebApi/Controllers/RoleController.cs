using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;
using MacWebApi.Services.RoleServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MacWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRoleService _roleService; 
        public RoleController(IMapper mapper, IRoleService roleService)
        {
            _mapper = mapper;
            _roleService = roleService;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Role>))]
        public IActionResult GetRoles()
        {
            var roles = _mapper.Map<List<RoleDto>>(_roleService.GetRoles());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(roles);
        }
        [HttpGet("{roleId}")]
        [ProducesResponseType(200, Type=typeof(Role))]
        [ProducesResponseType(400)]
        public IActionResult GetRole(int roleId)
        {
            var role = _mapper.Map<Role>(_roleService.GetRole(roleId));
            if (!ModelState.IsValid)    
                return BadRequest(ModelState);
            return Ok(role);    
        }
    }
}
