using AutoMapper;
using BNI.Models.Domain;
using BNI.Models.DTO.RoleDTO;
using FashionShop.Models.DTO.UserDTO;

namespace BNI
{
    public class AutoMapperProfilecs : Profile
    {
        public AutoMapperProfilecs()        
        {
            CreateMap<User, GetUserDTO>();
            CreateMap<User, UpdateUserDTO>().ReverseMap();

            CreateMap<Role, GetRoleDTO>().ReverseMap();
            CreateMap<Role, CreateRoleDTO>().ReverseMap();
        }
    }
}
