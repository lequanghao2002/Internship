using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNI.Models.Domain
{
    public class Events
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Header { get; set; } = string.Empty;
        public string Title_1 { get; set; } = string.Empty;
        public string Title_2 { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Address { get; set; } = string.Empty;

        public IEnumerable<EventsRegister> EventsRegister { get; set; }
    }
}
