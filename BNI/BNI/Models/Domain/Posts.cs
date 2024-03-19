using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNI.Models.Domain
{
    public class Posts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int PostsCategory_ID { get; set; }
        [ForeignKey("PostsCategory_ID")]
        public PostsCategory PostsCategory { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime TimeStart { get; set; }
        public int View { get; set; }
        public int Member_ID { get; set; }
        [ForeignKey("Member_ID")]
        public Member Member { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
