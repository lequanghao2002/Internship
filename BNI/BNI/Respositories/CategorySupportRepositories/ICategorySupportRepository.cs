using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories.CategorySupportRepositories.CategorySupportRepository
{
    public interface ICategorySupportRepository
    {
        List<CategoySupportDTO> categorySupports();
        CategoySupportDTO categorySupport(int id);

        Task<AddRequestCategoySupportDTO> AddCategorySupport(AddRequestCategoySupportDTO addRequest);
        Task<AddRequestCategoySupportDTO?> UpdateCategorySupport(int categoySupportId, AddRequestCategoySupportDTO categoySupport);
        Category_Support? DeleteCategorySupport(int categoySupportId);
        Task<Category_Support?> DeleteAll();
    }
}
