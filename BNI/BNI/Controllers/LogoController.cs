using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.LogoRepositories.LogoRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogoRepository _logoRepository;

        public LogoController(AppDbContext dbContext,ILogoRepository logoRepository)
        {
            _dbContext = dbContext;
            _logoRepository = logoRepository;
        }
        // GET: api/<LogoController>
        [HttpGet("get_All_Logo")]
        public IActionResult GetAll()
        {
            // su dung reposity pattern 
            var alllogos = _logoRepository.GetLogos();
            return Ok(alllogos);
        }

        // GET api/<LogoController>/5
        [HttpGet("{id}")]
        public IActionResult GetLogoById(int id)
        {
            var logo = _logoRepository.GetLogo(id);
            return Ok(logo);
        }

        // POST api/<LogoController>
        [HttpPost("add_logo")]
        public async Task<IActionResult> AddLogo([FromForm] AddLogoDTO addLogoDTO)
        {
            try
            {
                var result = await _logoRepository.AddLogoAsync(addLogoDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<LogoController>/5
        [HttpPut("update_logo/{id}")]
        public async Task<IActionResult> UpdateLogo(int id, [FromForm] AddLogoDTO addLogoDTO)
        {
            try
            {
                var result = await _logoRepository.UpdateLogo(id, addLogoDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<LogoController>/5
        [HttpDelete("delete-Logo-by-id/{id}")]
        public IActionResult DeleteLogoById(int id)
        {
            var deleteLogo = _logoRepository.DeleteLogoById(id);
            return Ok(deleteLogo);
        }
        [HttpDelete("delete-all")]
        public async Task<IActionResult> DeleteAll()
        {
            var deleteAll = await _logoRepository.DeleteAll();
            return Ok(deleteAll);
        }
    }
}
