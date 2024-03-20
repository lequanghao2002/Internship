using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNI.Models.Domain
{
    public class Contact
    {
        [Key]
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
        public string Position { get; set; } //chức vụ
        public bool MemberOfCSJ { get; set; }
        public string SupportInformation { get; set; }
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
