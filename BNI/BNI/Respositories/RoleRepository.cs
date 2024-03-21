using AutoMapper;
using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO.RoleDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace BNI.Respositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public RoleRepository(AppDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetRoleDTO>> GetAll()
        {
            var listRolesDomain = _dbContext.Role.AsQueryable();
            var listRoleDomain = _mapper.Map<List<GetRoleDTO>>(listRolesDomain);

            return listRoleDomain;
        }

        public async Task<GetRoleDTO> GetById(int id)
        {
            var roleDomainById = await _dbContext.Role.FirstOrDefaultAsync(role => role.Id == id);

            if (roleDomainById != null)
            {
                var roleDTO = _mapper.Map<GetRoleDTO>(roleDomainById);

                return roleDTO;
            }
            else
            {
                return null;
            }

        }

        public async Task<CreateRoleDTO> Create(CreateRoleDTO createRoleDTO)
        {
            var createRoleDomain = _mapper.Map<Role>(createRoleDTO);

            await _dbContext.Role.AddAsync(createRoleDomain);
            await _dbContext.SaveChangesAsync();

            return createRoleDTO;
        }

        public async Task<CreateRoleDTO> Update(CreateRoleDTO createRoleDTO, int id)
        {
            var updateRoleDomain = await _dbContext.Role.FirstOrDefaultAsync(role => role.Id == id);
            if (updateRoleDomain != null)
            {
                updateRoleDomain.Name = createRoleDTO.Name;
                updateRoleDomain.NormalizedName = createRoleDTO.Name.ToUpper();

                await _dbContext.SaveChangesAsync();
            }
            else
            {
                return null!;
            }
            return createRoleDTO;
        }

        public async Task<bool> Delete(int id)
        {
            var deleteRoleDomain = await _dbContext.Role.FirstOrDefaultAsync(role => role.Id == id);
            if (deleteRoleDomain != null)
            {
                _dbContext.Role.Remove(deleteRoleDomain);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
