using BNI.Data;
using BNI.Models.DTO;
using BNI.Respositories.PostCategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsCategoryController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IPostCategoryRepository _postCategory;

        public PostsCategoryController(AppDbContext dbContext,IPostCategoryRepository postCategory)
        {
            _dbContext = dbContext;
            _postCategory = postCategory;
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddCategoryPost([FromBody] AddRequestPostsCategoryDTO categoryPosts)
        {
            var newCategoryPosts = await _postCategory.AddCategoryPost(categoryPosts);
            return Ok(newCategoryPosts);
        }
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var categoryPosts = _postCategory.categoryPosts();
            return Ok(categoryPosts);
        }
        [HttpGet("get-by-id")]
        public IActionResult GetById(int id)
        {
            var categoryPost = _postCategory.categoryPost(id);
            return Ok(categoryPost);
        }
        [HttpPut("update")]
        public async Task<IActionResult> UpdateCategoryPost(int categoryPostsId, [FromBody] AddRequestPostsCategoryDTO categoryPosts)
        {
            var updatedCategoryPosts = await _postCategory.UpdateCategoryPost(categoryPostsId, categoryPosts);
            return Ok(updatedCategoryPosts);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteCategoryPost(int id)
        {
            var deletedCategoryPosts = await _postCategory.DeleteCategoryPost(id);
            return Ok(deletedCategoryPosts);
        }
        [HttpDelete("delete-all")]
        public async Task<IActionResult> DeleteAll()
        {
            var deletedCategoryPosts = await _postCategory.DeleteAll();
            return Ok(deletedCategoryPosts);
        }
    }
}
