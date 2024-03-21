using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.PlatformRepositories.PlatformRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IPlatformRepository _platformRepository;

        public PlatformController(AppDbContext appDbContext,IPlatformRepository platformRepository)
        {
            _appDbContext = appDbContext;
            _platformRepository = platformRepository;
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var platforms = _platformRepository.GetAll();
            return Ok(platforms);
        }
        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var platform = _platformRepository.GetById(id);
            return Ok(platform);
        }
        [HttpPost("add")]
        public IActionResult AddPlatform([FromBody] AddRequestPlatformDTO platform)
        {
            var newPlatform = _platformRepository.AddPlatform(platform);
            return Ok(newPlatform);
        }
        [HttpPut("update")]
        public IActionResult UpdatePlatform(int platformId, [FromBody] AddRequestPlatformDTO platform)
        {
            var updatedPlatform = _platformRepository.UpdatePlatform(platformId, platform);
            return Ok(updatedPlatform);
        }
        [HttpDelete("delete")]
        public IActionResult DeletePlatform(int id)
        {
            var deletedPlatform = _platformRepository.DeletePlatform(id);
            return Ok(deletedPlatform);
        }
    }
}
