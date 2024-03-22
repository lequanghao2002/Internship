using BNI.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Models.DTO
{
    public class EventDTO
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Address { get; set; }
        public string OrganizerName { get; set; }
        public string OrganizerEmail { get; set; }
        [FromForm(Name = "Titles")]
        public List<TitleDTO> Titles { get; set; }
    }
    
    public class TitleDTO
    {
        public string Title { get; set; }
        public List<string> ImagePaths { get; set; }
    }
    public class AddEventDTO
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Address { get; set; }
        public string OrganizerName { get; set; }
        public string OrganizerEmail { get; set; }
    }
    
    public class AddTitleDTO
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public List<IFormFile> ImagePaths { get; set; }
    }
}
