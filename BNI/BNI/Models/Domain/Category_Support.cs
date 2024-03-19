using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Category_Support
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = " Không bỏ trống tiêu đề ")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
