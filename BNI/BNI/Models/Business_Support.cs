using System.ComponentModel.DataAnnotations;

namespace BNI.Models
{
    public class Business_Support
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a business sector.")]
        public string CEOName { get; set; }
        public string CompanyName { get; set; }
        public string Profession { get; set; }
        public string Address { get; set; }
        public string link { get; set; }
        public string Description { get; set; }
        IFormFile Logo { get; set; }
        IFormFile Image { get; set; }
        IFormFile QRCode { get; set; }
        IFormFile Document { get; set; }

        public int Category_Support_Id { get; set; }
        public Category_Support Category_Support { get; set; }
        public List<Step> Steps { get; set; }
        //public int Member_Id { get; set; }
        //public Member Member { get; set; }
        
    }
}
