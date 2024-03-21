using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Cmp;

namespace BNI.Respositories.PlatformRepositories.PlatformRepository
{
    public class PlatformRepository  : IPlatformRepository
    {
        private readonly AppDbContext _appDbContext;

        public PlatformRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<AddRequestPlatformDTO> AddPlatform(AddRequestPlatformDTO platform)
        {
            var newPlatform = new Platform
            {
                Name = platform.Name
            };
            _appDbContext.Platform.Add(newPlatform);
            await _appDbContext.SaveChangesAsync();
            return platform;
        }

        public Platform DeletePlatform(int platformId)
        {
            var platform = _appDbContext.Platform.Find(platformId);
            if (platform != null)
            {
                _appDbContext.Platform.Remove(platform);
                _appDbContext.SaveChanges();
            }
            return platform;
        }

        public List<PlatformDTO> GetAll()
        {
            var platforms = _appDbContext.Platform.Select(p => new PlatformDTO()
            {
                Id = p.Platform_Id,
                Name = p.Name,
                Contacts = p.Contacts.Select(c => c.FullName).ToList()

            }).ToList();
            return platforms;
        }

        public PlatformDTO GetById(int id)
        {
            var platform = _appDbContext.Platform.
                Include(p => p.Contacts).FirstOrDefault(x => x.Platform_Id == id);
            var platformDTO = new PlatformDTO
            {
                Id = platform.Platform_Id,
                Name = platform.Name,
                Contacts = platform.Contacts.Select(c => c.FullName).ToList()
            };
            return platformDTO;

        }

        public async Task<AddRequestPlatformDTO> UpdatePlatform(int platformId, AddRequestPlatformDTO platform)
        {
            var platformToUpdate = _appDbContext.Platform.FirstOrDefault(x => x.Platform_Id == platformId);
            if (platformToUpdate != null)
            {
                // Kiểm tra và cập nhật tên nếu giá trị mới từ DTO không phải là null
                if (platform.Name != null)
                {
                    platformToUpdate.Name = platform.Name;
                }
                // Cập nhật các trường khác tương tự

                await _appDbContext.SaveChangesAsync();
            }
            return platform;
        }
    }
}
