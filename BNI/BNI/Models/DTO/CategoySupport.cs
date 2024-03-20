namespace BNI.Models.DTO
{
    public class CategoySupportDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
    public class AddRequestCategoySupportDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
