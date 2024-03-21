using BNI.Models.Domain;
using BNI.Models.DTO;

namespace BNI.Respositories.LogoRepositories.LogoRepository
{
    public interface ILogoRepository
    {
        List<LogoDTO> GetLogos();
        LogoDTO GetLogo(int logoID);
        Task<AddLogoDTO> AddLogoAsync(AddLogoDTO addLogoDTO);
        Task<AddLogoDTO?> UpdateLogo(int logoID, AddLogoDTO addLogoDTO);
        Logo? DeleteLogoById(int logoID);
        Task<Logo?> DeleteAll();
    }
}
