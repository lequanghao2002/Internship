using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Pronoun { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Introducer { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string TaxAddress { get; set; } = string.Empty;
        public string BillingAddress { get; set; } = string.Empty;
        public string BillingCompany { get; set; } = string.Empty;
        public string BillingEmail { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address_1 { get; set; } = string.Empty;
        public string Address_2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public int User_ID { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        public int BusinessSector_ID { get; set; }
        [ForeignKey("BusinessSector_ID")]
        public Business_Sector Business_Sector { get; set; }

        public int MembershipTerm_ID { get; set; }
        [ForeignKey("MembershipTerm_ID")]
        public Membership_Term Membership_Term { get; set; }

        public int ReferenceInformation_ID { get; set; }
        [ForeignKey("ReferenceInformation_ID ")]
        public Reference_Information Reference_Information { get; set; }

        public int AdditionalInformation_ID { get; set; }
        [ForeignKey("AdditionalInformation_ID")]
        public AddtionalInformation AddtionalInformation { get; set; }
    }
}
