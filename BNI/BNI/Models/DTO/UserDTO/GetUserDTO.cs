using System.Diagnostics.Eventing.Reader;

namespace FashionShop.Models.DTO.UserDTO
{
    public class GetUserDTO
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string VAT { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string Zip { get; set; } 
        public string Country { get; set; }       
    }
}
