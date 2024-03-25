using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories.StepsRepositories
{
    public interface IStepsRepository
    {
        Task<AddStepDTO> CreateStepAsync(AddStepDTO addStepDTO);
        Task<StepsDTO> GetStepAsync(int id);
        Task<List<StepsDTO>> GetStepsAsync();
        Task<AddStepDTO> UpdateStepAsync(int id,AddStepDTO step);
        Task<Step> DeleteStepAsync(int id);
    }
}
