using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.EventsRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsReposiroty _eventsReposiroty;
        private readonly AppDbContext _dbContext;

        public EventsController(IEventsReposiroty eventsReposiroty,AppDbContext dbContext)
        {
            _eventsReposiroty = eventsReposiroty;
            _dbContext = dbContext;
        }
        [HttpPost("ADD")]
        [Consumes("application/x-www-form-urlencoded")]
        public async Task<IActionResult> AddEvent([FromForm] AddEventDTO addEventDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _eventsReposiroty.CreateEventAsync(addEventDTO);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
