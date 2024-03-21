namespace BNI.Models.DTO
{
    public class BusinessSectorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }

    }
    public class AddRequestBusinessSector
    {
        public string Name { get; set; }
    }
}
