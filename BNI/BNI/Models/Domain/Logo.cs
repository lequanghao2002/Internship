using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Logo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng điền tên.")]
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
