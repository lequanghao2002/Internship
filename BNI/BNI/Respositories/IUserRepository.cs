using FashionShop.Models.DTO.UserDTO;

namespace BNI.Respositories
{
    public interface IUserRepository
    {
        public Task<List<GetUserDTO>> GetAllUser();
        public Task<GetUserDTO> GetUserById(int id);

        public Task<bool> RegisterAccountUser(RegisterRequestDTO registerRequestDTO);

        public Task<string> Login(LoginRequestDTO loginRequestDTO);

        public Task<UpdateUserDTO> Update(UpdateUserDTO updateUserDTO, int id);
        public Task<bool> Delete(int id);
    }
}
