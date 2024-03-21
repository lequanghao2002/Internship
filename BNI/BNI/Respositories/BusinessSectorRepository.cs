using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace BNI.Respositories
{
    public class BusinessSectorRepository : IBusinessSectorRepository
    {
        private readonly AppDbContext _dbContext;

        public BusinessSectorRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public AddRequestBusinessSector AddBusinessSector(AddRequestBusinessSector businessSector)
        {
            var ExistingBusinessSector = _dbContext.Business_Sector.FirstOrDefault(x => x.Name == businessSector.Name);
            if (ExistingBusinessSector != null)
            {
                throw new Exception("Business Sector already exists");
            }
            else
            {
                var newbusinessSector = new Business_Sector
                {
                    Name = businessSector.Name
                };
                _dbContext.Business_Sector.Add(newbusinessSector);
                _dbContext.SaveChanges();
            }
            return businessSector;
        }

        public Business_Sector? DeleteBusinessSector(int businessSectorId)
        {
            var deleteBusinessSector = _dbContext.Business_Sector.Find(businessSectorId);
            if(deleteBusinessSector != null)
            {
                _dbContext.Business_Sector.Remove(deleteBusinessSector);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Business Sector không tồn tại");
            }
            return deleteBusinessSector;
        }

        public List<BusinessSectorDTO> GetAll()
        {
            var list = _dbContext.Business_Sector.ToList();
            if(list != null)
            {
                var businessSectors = _dbContext.Business_Sector.Select(b => new BusinessSectorDTO()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Members = b.Member.Select(Member => $"{Member.FirstName}{Member.LastName}").ToList()
                }).ToList();
                return businessSectors;
            }
            else
            {
                throw new Exception("Business Sector không tồn tại");
            }
        }

        public BusinessSectorDTO GetById(int id)
        {
            var getBusinessSector = _dbContext.Business_Sector.Include(p => p.Member).FirstOrDefault(x => x.Id == id);
            var businessSectorDTO = new BusinessSectorDTO()
            {
                Id = getBusinessSector.Id,
                Name = getBusinessSector.Name,
                Members = getBusinessSector.Member.Select(Member => $"{Member.FirstName}{Member.LastName}").ToList()        
               
            };
            return businessSectorDTO;
        }

        public AddRequestBusinessSector UpdateBusinessSector(int businessSectorId, AddRequestBusinessSector businessSector)
        {
            var UpdateBusinessSector = _dbContext.Business_Sector.FirstOrDefault(x => x.Id == businessSectorId);
            if(UpdateBusinessSector == null)
            {
                throw new Exception($"Không tìm thấy Business Sector với ID {businessSectorId}");
            }
            UpdateBusinessSector.Name = businessSector.Name;
            _dbContext.SaveChanges();

            return businessSector;
        }
    }
}
