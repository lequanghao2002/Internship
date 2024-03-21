using AutoMapper;
using BNI.Data;
using FashionShop.Models.DTO.UserDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BNI.Respositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        private readonly ITokenRepository _tokenRepository;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext dbContext, UserManager<User> userManager, ITokenRepository tokenRepository, IMapper mapper)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _tokenRepository = tokenRepository;
            _mapper = mapper;
        }

        public async Task<List<GetUserDTO>> GetAllUser()
        {
            var listUsersDomain = _dbContext.User.AsQueryable();

            //if (!searchByName.IsNullOrEmpty())
            //{
            //    listUsersDomain = listUsersDomain.Where(u => u.FullName.Contains(searchByName));
            //}

            //if (!filterUser.IsNullOrEmpty())
            //{
            //    listUsersDomain = listUsersDomain.Where(u => _dbContext.UserUsers
            //            .Where(ur => ur.UserId == filterUser)
            //            .Select(ur => ur.UserId)
            //            .Contains(u.Id)
            //    );
            //}       

            var listUsersDTO = _mapper.Map<List<GetUserDTO>>(listUsersDomain);
            return listUsersDTO;
        }

        public async Task<GetUserDTO> GetUserById(int id)
        {
            var user = await _dbContext.User.SingleOrDefaultAsync(u => u.Id == id);

            if (user != null)
            {
               var userDTO = _mapper.Map<GetUserDTO>(user);

                return userDTO;
            }

            return null;
        }

        public async Task<bool> RegisterAccountUser(RegisterRequestDTO registerRequestDTO)
        {
            var user = new User
            {
                FullName = registerRequestDTO.FullName,
                Email = registerRequestDTO.Email,
                UserName = registerRequestDTO.Email,
                Role_ID = 2
            };

            var result = await _userManager.CreateAsync(user, registerRequestDTO.Password);

            if (result.Succeeded)
            {
                await _dbContext.SaveChangesAsync();
                return true;

            }
            return false;
        }

        public async Task<string> Login(LoginRequestDTO loginRequestDTO)
        {
            var checkUser = await _userManager.FindByEmailAsync(loginRequestDTO.Email);

            if (checkUser != null)
            {
                var checkPassword = await _userManager.CheckPasswordAsync(checkUser, loginRequestDTO.Password);
                if (checkPassword)
                {
                    var Roles = await _dbContext.Role.SingleOrDefaultAsync(r => r.Id == checkUser.Role_ID);
                    if (Roles != null)
                    {
                        var jwtToken = _tokenRepository.CreateJWTToken(checkUser, Roles.Name);

                        return jwtToken;
                    }
                }
            }

            return null;
        }

        public async Task<UpdateUserDTO> Update(UpdateUserDTO updateUserDTO, int id)
        {
            var userDomain = await _dbContext.User.FirstOrDefaultAsync(u => u.Id == id);

            if (userDomain != null)
            {
                userDomain.FullName = updateUserDTO.FullName;
                userDomain.Email = updateUserDTO.Email;
                userDomain.PhoneNumber = updateUserDTO.PhoneNumber;

                await _dbContext.SaveChangesAsync();
                return updateUserDTO;
            }
            else
            {
                return null!;
            }
        }

        public async Task<bool> Delete(int id)
        {
            var deleteUserDomain = await _dbContext.User.FirstOrDefaultAsync(User => User.Id == id);
            if (deleteUserDomain != null)
            {
                _dbContext.User.Remove(deleteUserDomain);
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
