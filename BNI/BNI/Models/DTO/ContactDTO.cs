using BNI.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BNI.Models.DTO
{
    public class ContactDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng điền đầy đủ Tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng thông tin công việc")]
        public string Job { get; set; }

        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string YearExperience { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public bool MemberOfCSJ { get; set; }
        public string SupportInformation { get; set; }
        public string PlatformName { get; set; }
    }
    public class AddRequestContactDTO
    {
        public string FullName { get; set; }
        public string Job { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string YearExperience { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public bool MemberOfCSJ { get; set; }
        public string SupportInformation { get; set; }
        public int Platform_Id { get; set; }
    }
}
