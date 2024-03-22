using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class EventTitle
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Title { get; set; } = string.Empty;

        // Navigation property
        public List<TitleImage> TitleImages { get; set; }
        public Events Event { get; set; }
    }
}
