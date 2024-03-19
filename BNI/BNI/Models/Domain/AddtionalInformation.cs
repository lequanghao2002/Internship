using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BNI.Models.Domain
{
    public class AddtionalInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string BusinessHours { get; set; } = string.Empty;
        public string InceptionDate { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;
        public bool Condition_1 { get; set; }
        public bool Condition_2 { get; set; }
        public string Condition_3 { get; set; } = string.Empty;
        public bool Condition_4 { get; set; }
        public bool Condition_5 { get; set; }
        public string Condition_6 { get; set; } = string.Empty;
        public string Condition_7 { get; set; } = string.Empty;
        public bool Condition_8 { get; set; }
    }
}
