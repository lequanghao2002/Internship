using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace BNI.Respositories.PostCategoryRepository
{
    public class PostCategoryRepository : IPostCategoryRepository
    {
        private readonly AppDbContext _dbContext;
        public PostCategoryRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<PostsCategoryDTO> AddCategoryPost(AddRequestPostsCategoryDTO categoryPosts)
        {
            var newCategoryPosts = new PostsCategory
            {
                Name = categoryPosts.Name
            };
            _dbContext.PostsCategory.Add(newCategoryPosts);
            await _dbContext.SaveChangesAsync();
            return new PostsCategoryDTO
            {
                Name = newCategoryPosts.Name
            };
        }
        public async Task<PostsCategoryDTO> UpdateCategoryPost(int categoryPostsId, AddRequestPostsCategoryDTO categoryPosts)
        {
            var categoryPostsToUpdate = await _dbContext.PostsCategory.FindAsync(categoryPostsId);
            categoryPostsToUpdate.Name = categoryPosts.Name;
            await _dbContext.SaveChangesAsync();
            return new PostsCategoryDTO
            {
                Name = categoryPostsToUpdate.Name
            };
        }
        public async Task<PostsCategoryDTO> DeleteCategoryPost(int id)
        {
            var categoryPostToDelete = await _dbContext.PostsCategory.FindAsync(id);
            _dbContext.PostsCategory.Remove(categoryPostToDelete);
            await _dbContext.SaveChangesAsync();
            return new PostsCategoryDTO
            {
                Name = categoryPostToDelete.Name
            };
        }
        public async Task<PostsCategoryDTO> DeleteAll()
        {
            var categoryPostsToDelete = await _dbContext.PostsCategory.ToListAsync();
            _dbContext.PostsCategory.RemoveRange(categoryPostsToDelete);
            await _dbContext.SaveChangesAsync();
            return null;
        }
        public List<PostsCategoryDTO> categoryPosts()
        {
            return  _dbContext.PostsCategory.Select(x => new PostsCategoryDTO
            {
                Id = x.ID,
                Name = x.Name
            }).ToList();
        }
        public PostsCategoryDTO categoryPost(int id)
        {
            var categoryPosts =  _dbContext.PostsCategory.Find(id);
            return new PostsCategoryDTO
            {
                Id = categoryPosts.ID,
                Name = categoryPosts.Name
            };
        }
    }
}
