using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories.PlatformRepositories.PlatformRepository
{
    public interface IPlatformRepository
    {
        List<PlatformDTO> GetAll();
        PlatformDTO GetById(int id);
        Task<AddRequestPlatformDTO> AddPlatform(AddRequestPlatformDTO platform);
        Task<AddRequestPlatformDTO> UpdatePlatform(int platformId, AddRequestPlatformDTO platform);
        Platform? DeletePlatform(int platformId);
    }
}
