using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }
        public int ParentID { get; set; }
        public int Posts_ID { get; set; }
        [ForeignKey("Posts_ID")]
        public Posts Posts { get; set; }
        public int User_ID { get; set; }
        [ForeignKey("User_ID")]
        public User User { get; set; }
    }
}
