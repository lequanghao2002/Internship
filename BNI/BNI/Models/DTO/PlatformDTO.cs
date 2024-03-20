using BNI.Models.Domain;

namespace BNI.Models.DTO
{
    public class PlatformDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Contacts { get; set; }
    }
    public class AddRequestPlatformDTO
    {
        public string Name { get; set; }
    }
}
