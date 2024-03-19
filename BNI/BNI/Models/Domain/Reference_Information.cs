using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Reference_Information
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng điền một .")]
        public string Reference_1 { get; set; }
        public string Reference_2 { get; set; }

        public Member Member { get; set; }
    }
}
