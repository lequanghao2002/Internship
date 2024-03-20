using BNI.Models.DTO;
using BNI.Models.Domain;

namespace BNI.Respositories
{
    public interface IBusinessSectorRepository
    {
        List<BusinessSectorDTO> GetAll();
        BusinessSectorDTO GetById(int id);
        AddRequestBusinessSector AddBusinessSector(AddRequestBusinessSector businessSector);
        AddRequestBusinessSector UpdateBusinessSector(int businessSectorId, AddRequestBusinessSector businessSector);
        Business_Sector? DeleteBusinessSector(int businessSectorId);
    }
}
