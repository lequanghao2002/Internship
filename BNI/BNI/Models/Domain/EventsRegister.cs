using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNI.Models.Domain
{
    public class EventsRegister
    {
        [Key]
        public int Event_ID { get; set; }
        [ForeignKey("Event_ID")] 
        public Events Events { get; set; }

        public int User_ID { get; set; }
        [ForeignKey("User_ID")]
        public User User { get; set; }

        public DateTime AddDate { get; set; }
        public bool Cancel { get; set; } = false;
    }
}
