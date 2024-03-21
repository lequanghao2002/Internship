namespace BNI.Models.DTO
{
    public class LogoDTO
    {
        public int LogoID { get; set; }
        public string NameLogo { get; set; }
        public string ImageLogo { get; set; }
    }
    public class AddLogoDTO
    {
        public string NameLogo { get; set; }
        public IFormFile Image { get; set; }
    }
}
