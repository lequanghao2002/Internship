using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.StepsRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepsController : ControllerBase
    {
        private readonly IStepsRepository _steps;
        private readonly AppDbContext _dbContext;

        public StepsController(AppDbContext dbContext, IStepsRepository steps)
        {
            _steps = steps;
            _dbContext = dbContext;
        }

        [HttpPost("ADD")]
        public async Task<IActionResult> AddStep([FromForm] AddStepDTO addStepDTO)
        {
            if(string.IsNullOrEmpty(addStepDTO.Title))
            {
                ModelState.AddModelError("Title", "Vui lòng nhập tiêu đề cho bước");
            }
            // Kiểm tra hợp lệ cho các trường thông tin của bước
            if (string.IsNullOrEmpty(addStepDTO.Description))
            {
                ModelState.AddModelError("Description", "Vui lòng nhập mô tả cho bước");
            }
            if (addStepDTO.Member_Id != null)
            {
                ModelState.AddModelError("Member", "Member Đã Tồn Tại");
            }

            // Kiểm tra hợp lệ của ModelState
            if (ModelState.IsValid)
            {
                // Nếu hợp lệ, tiếp tục xử lý
                var result = await _steps.CreateStepAsync(addStepDTO);
                return Ok(result);
            }

            // Nếu ModelState không hợp lệ, trả về BadRequest với ModelState chứa thông tin lỗi
            return BadRequest(ModelState);
        }


        [HttpGet("GET")]
        public async Task<IActionResult> GetSteps()
        {
            var result = await _steps.GetStepsAsync();
            return Ok(result);
        }

        [HttpGet("GET/{id}")]
        public async Task<IActionResult> GetStep(int id)
        {
            var result = await _steps.GetStepAsync(id);
            return Ok(result);
        }

        [HttpDelete("DELETE/{id}")]
        public async Task<IActionResult> DeleteStep(int id)
        {
            var result = await _steps.DeleteStepAsync(id);
            return Ok(result);
        }

        [HttpPut("UPDATE")]
        public async Task<IActionResult> UpdateStep(int id, [FromForm] AddStepDTO step)
        {
            if (ModelState.IsValid)
            {
                var result = await _steps.UpdateStepAsync(id, step);
                return Ok(result);
            }
            return BadRequest(ModelState);
        }
    }
}
