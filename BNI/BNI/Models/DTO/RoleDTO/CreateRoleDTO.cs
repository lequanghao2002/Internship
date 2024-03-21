using System.ComponentModel.DataAnnotations;

namespace BNI.Models.DTO.RoleDTO
{
    public class CreateRoleDTO
    {
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }
    }
}
