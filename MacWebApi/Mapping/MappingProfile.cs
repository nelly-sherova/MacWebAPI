using AutoMapper;
using MacWebApi.Data.Models;
using MacWebApi.DTOs;

namespace MacWebApi.Mapping
{
    public class MappingProfile : Profile 
    {
        public MappingProfile() 
        {
            CreateMap<Category, CategoryDto>(); 
            CreateMap<City, CityDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<Product, ProductDto>();   
            CreateMap<Role, RoleDto>();
            CreateMap<User, UserDto>(); 
        }
    }
}
