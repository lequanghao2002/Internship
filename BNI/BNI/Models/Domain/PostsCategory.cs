using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class PostsCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Posts> Posts { get; set; }
    }
}
