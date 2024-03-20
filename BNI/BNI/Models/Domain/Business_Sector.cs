using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Business_Sector
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a business sector.")]
        public string Name { get; set; }

        public List<Member> Member { get; set; }
    }
}
