using BNI.Models.DTO.RoleDTO;
using Microsoft.AspNetCore.Identity;

namespace BNI.Respositories
{
    public interface IRoleRepository
    {
        public Task<List<GetRoleDTO>> GetAll();
        public Task<CreateRoleDTO> Create(CreateRoleDTO createRoleDTO);
        public Task<GetRoleDTO> GetById(int id);
        public Task<CreateRoleDTO> Update(CreateRoleDTO createRoleDTO, int id);
        public Task<bool> Delete(int id);
    }
}
