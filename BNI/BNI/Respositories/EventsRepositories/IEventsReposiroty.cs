using BNI.Models.DTO;

namespace BNI.Respositories.EventsRepositories
{
    public interface IEventsReposiroty
    {
        Task<AddEventDTO> CreateEventAsync(AddEventDTO addEventDTO);
    }
}
