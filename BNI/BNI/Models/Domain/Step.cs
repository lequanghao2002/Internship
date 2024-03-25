using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Step
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }  = DateTime.Now;
        public int Member_Id { get; set; }
        public Member Member { get; set; }
    }
}
