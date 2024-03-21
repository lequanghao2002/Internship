using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories.PostCategoryRepository
{
    public interface IPostCategoryRepository
    {
        Task<PostsCategoryDTO> AddCategoryPost(AddRequestPostsCategoryDTO categoryPosts);
        Task<PostsCategoryDTO> UpdateCategoryPost(int categoryPostsId, AddRequestPostsCategoryDTO categoryPosts);
        Task<PostsCategoryDTO> DeleteCategoryPost(int id);
        Task<PostsCategoryDTO> DeleteAll();
        List<PostsCategoryDTO> categoryPosts();
        PostsCategoryDTO categoryPost(int id);
    }
}
