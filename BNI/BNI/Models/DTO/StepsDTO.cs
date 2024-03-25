namespace BNI.Models.DTO
{
    public class StepsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Member { get; set; }
    }
    public class AddStepDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Member_Id { get; set; }
    }
}
