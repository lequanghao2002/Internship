using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorySupportController : ControllerBase
    {
        private readonly ICategorySupportRepository _categorySupportRepository;
        private readonly AppDbContext _dbContext;

        public CategorySupportController(ICategorySupportRepository categorySupport,AppDbContext dbContext)
        {
            _categorySupportRepository = categorySupport;
            _dbContext = dbContext;
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddCategoySupport([FromForm] AddRequestCategoySupportDTO categoySupport)
        {
            var newCategoySupport = await _categorySupportRepository.AddCategorySupport(categoySupport);
            return Ok(newCategoySupport);
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var categoySupports = _categorySupportRepository.categorySupports();
            return Ok(categoySupports);
        }
        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var categoySupport = _categorySupportRepository.categorySupport(id);
            return Ok(categoySupport);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateCategoySupport(int categoySupportId, [FromForm] AddRequestCategoySupportDTO categoySupport)
        {
            var updatedCategoySupport = await _categorySupportRepository.UpdateCategorySupport(categoySupportId, categoySupport);
            return Ok(updatedCategoySupport);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteCategoySupport(int id)
        {
            var deletedCategoySupport = _categorySupportRepository.DeleteCategorySupport(id);
            return Ok(deletedCategoySupport);
        }
        [HttpDelete("delete-all")]
        public async Task<IActionResult> DeleteAll()
        {
            var deletedCategoySupport = await _categorySupportRepository.DeleteAll();
            return Ok(deletedCategoySupport);
        }
    }
}
