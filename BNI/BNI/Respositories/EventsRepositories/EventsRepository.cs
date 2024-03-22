using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Pkcs;

namespace BNI.Respositories.EventsRepositories
{
    public class EventsRepository : IEventsReposiroty
    {
        private readonly AppDbContext _context;

        public EventsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AddEventDTO> CreateEventAsync(AddEventDTO addEventDTO)
        {
            //var newEvent = new Events
            //{
            //    Title = addEventDTO.Title,
            //    StartTime = addEventDTO.StartTime,
            //    EndTime = addEventDTO.EndTime,
            //    Address = addEventDTO.Address,
            //    OrganizerName = addEventDTO.OrganizerName,
            //    OrganizerEmail = addEventDTO.OrganizerEmail,
            //    CreatedTime = DateTime.Now
            //};

            //_context.Events.Add(newEvent);
            //await _context.SaveChangesAsync();

            //foreach (var titleDTO in addEventDTO.Titles)
            //{
            //    var newEventTitle = new EventTitle
            //    {
            //        Title = titleDTO.Title,
            //        EventId = newEvent.ID // Set EventId for the new EventTitle
            //    };

            //    _context.EventTitle.Add(newEventTitle);
            //    await _context.SaveChangesAsync(); // Save changes to get the newEventTitle.Id

            //    foreach (var imageDTO in titleDTO.ImagePaths)
            //    {
            //        var newTitleImage = new TitleImage
            //        {
            //            EventTitleId = newEventTitle.Id // Set EventTitleId for the new TitleImage
            //        };

            //        if (imageDTO.Image != null && imageDTO.Image.Length > 0)
            //        {
            //            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Events", "Titles", "Title", titleDTO.Title);
            //            Directory.CreateDirectory(folderPath);
            //            var uniqueFileName = Guid.NewGuid().ToString() + "_" + imageDTO.Image.FileName;
            //            var imagePath = Path.Combine(folderPath, uniqueFileName);

            //            using (var stream = File.Create(imagePath))
            //            {
            //                await imageDTO.Image.CopyToAsync(stream);
            //            }

            //            newTitleImage.ImagePath = imagePath; // Save the image path to the new TitleImage
            //        }
            //        else
            //        {
            //            newTitleImage.ImagePath = ""; // Or handle if no image is sent from the client
            //        }

            //        _context.TitleImage.Add(newTitleImage);
            //    }
            //}

            //await _context.SaveChangesAsync(); // Save changes to the database

            //return addEventDTO;
            return null;
        }


    }
}
