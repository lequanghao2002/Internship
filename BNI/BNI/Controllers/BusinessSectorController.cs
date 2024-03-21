using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.BusinessSectorRepositories.BusinessSectorRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessSectorController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IBusinessSectorRepository _businessSector;

        public BusinessSectorController(AppDbContext dbContext,IBusinessSectorRepository businessSector)
        {
            _dbContext = dbContext;
            _businessSector = businessSector;
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var businessSectors = _businessSector.GetAll();
            return Ok(businessSectors);
        }
        [HttpPost("add")]
        public IActionResult AddBusinessSector([FromBody] AddRequestBusinessSector businessSector)
        {
            var newBusinessSector = _businessSector.AddBusinessSector(businessSector);
            return Ok(newBusinessSector);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteBusinessSector(int id)
        {
            var deletedBusinessSector = _businessSector.DeleteBusinessSector(id);
            return Ok(deletedBusinessSector);
        }
        [HttpPut("update")]
        public IActionResult UpdateBusinessSector(int businessSectorId, [FromBody] AddRequestBusinessSector businessSector)
        {
            var updatedBusinessSector = _businessSector.UpdateBusinessSector(businessSectorId, businessSector);
            return Ok(updatedBusinessSector);
        }
        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var businessSector = _businessSector.GetById(id);
            return Ok(businessSector);
        }

    }
}
