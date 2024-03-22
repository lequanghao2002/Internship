using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNI.Models.Domain
{
    public class Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime StartTime { get; set; } = new DateTime();
        public DateTime EndTime { get; set; }   = new DateTime();
        public DateTime CreatedTime { get; set; } = new DateTime();
        public string Address { get; set; } = string.Empty;
        public string OrganizerName { get; set; } = string.Empty;
        public string OrganizerEmail { get; set; } = string.Empty;

        // Navigation property
        public List<EventTitle> EventTitles { get; set; }

        public IEnumerable<EventsRegister> EventsRegister { get; set; }
    }
}
