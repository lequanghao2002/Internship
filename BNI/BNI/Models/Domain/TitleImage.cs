using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class TitleImage
    {
        [Key]
        public int Id { get; set; }
        public int EventTitleId { get; set; }
        public string ImagePath { get; set; }

        // Navigation property
        public EventTitle EventTitle { get; set; }
    }
}
