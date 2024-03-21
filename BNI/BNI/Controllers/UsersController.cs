using BNI.Respositories;
using FashionShop.Models.DTO.UserDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;

        public UsersController(UserManager<User> userManager, IUserRepository userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }

        [HttpGet("get-list-users")]
        public async Task<IActionResult> GetListUsers()
        {
            try
            {
                var listUsers = await _userRepository.GetAllUser();

                return Ok(listUsers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get-user-by-id/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                var user = await _userRepository.GetUserById(id);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("register-user")]
        public async Task<IActionResult> RegisterUser(RegisterRequestDTO registerUserRequestDTO)
        {
            try
            {
                var checkEmail = await _userManager.FindByEmailAsync(registerUserRequestDTO.Email);
                if (checkEmail != null)
                {
                    return BadRequest("Email đã tồn tại, vui lòng nhập email khác");
                }

                if (registerUserRequestDTO.Password != registerUserRequestDTO.RePassword)
                {
                    return BadRequest("Mật khẩu và nhập lại mật khẩu không khớp");
                }

                var accountMember = await _userRepository.RegisterAccountUser(registerUserRequestDTO);
                if (accountMember == true)
                {
                    return Ok("Tạo tài khoản người dùng thành công");
                }
                else
                {
                    return BadRequest("Tạo tài khoản người dùng không thành công");
                }
            }
            catch
            {
                return BadRequest("Tạo tài khoản người dùng không thành công");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDTO loginRequestDTO)
        {
            try
            {
                var loginAccount = await _userRepository.Login(loginRequestDTO);

                if (loginAccount != null)
                {
                    return Ok(loginAccount);
                }
                else
                {
                    return BadRequest("Đăng nhập không thành công");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("update-user/{id}")]
        public async Task<IActionResult> UpdateUser(UpdateUserDTO updateUserDTO, int id)
        {
            try
            {
                var userById = await _userManager.FindByIdAsync(id.ToString());
                var checkEmail = await _userManager.FindByEmailAsync(updateUserDTO.Email);

                if (checkEmail != null && checkEmail.Email != userById.Email)
                {
                    return BadRequest("Email đã tồn tại, vui lòng nhập email khác");
                }

                var updateUser = await _userRepository.Update(updateUserDTO, id);
                if (updateUser != null)
                {
                    return Ok("Chỉnh sửa tài khoản thành công");
                }
                else
                {
                    return BadRequest("Chỉnh sửa tài khoản không thành công");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete-user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var deleteUser = await _userRepository.Delete(id);
                if (deleteUser != null)
                {
                    return Ok(deleteUser);
                }
                else
                {
                    return BadRequest($"Không tìm thấy user có id = {id}");
                }
            }
            catch
            {
                return BadRequest("Xóa user không thành công");
            }
        }
    }
}
