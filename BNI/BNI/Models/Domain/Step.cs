using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Step
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Member_Id { get; set; }
        public Member Member { get; set; }
    }
}
