using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BNI.Respositories.LogoRepositories.LogoRepository
{
    public class LogoRepository : ILogoRepository
    {
        private readonly AppDbContext _dbContext;

        public LogoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<AddLogoDTO> AddLogoAsync([FromForm] AddLogoDTO addLogoDTO)
        {
            var logo = new Logo { Name = addLogoDTO.NameLogo };
            if (addLogoDTO.Image.Length > 0)
            {

                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo", addLogoDTO.NameLogo);
                Directory.CreateDirectory(folderPath);
                var uniqueFileName = "Image" + addLogoDTO.Image.FileName;
                var imagePath = Path.Combine(folderPath, uniqueFileName);
                using (var stream = File.Create(imagePath))
                {
                    await addLogoDTO.Image.CopyToAsync(stream);
                }
                logo.Path = uniqueFileName;
            }
            else
            {
                logo.Path = "";
            }
            _dbContext.Logo.Add(logo);
            _dbContext.SaveChanges();
            return addLogoDTO;

        }

        public Logo? DeleteLogoById(int id)
        {
            var LogoDomain = _dbContext.Logo.FirstOrDefault(n => n.Id == id);
            if (!string.IsNullOrEmpty(LogoDomain.Path))
            {
                var previousImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo", LogoDomain.Name);
                if (Directory.Exists(previousImagePath))
                {
                    Directory.Delete(previousImagePath, true);
                }
            }

            if (LogoDomain != null)
            {
                _dbContext.Logo.Remove(LogoDomain);
                _dbContext.SaveChanges();
            }
            return LogoDomain;
        }

        public LogoDTO GetLogo(int logoID)
        {
            var logoDomain = _dbContext.Logo.Where(x => x.Id == logoID);
            var logoDTO = logoDomain.Select(logo => new LogoDTO()
            {
                LogoID = logo.Id,
                NameLogo = logo.Name,
                ImageLogo = logo.Path
            }).FirstOrDefault();
            return logoDTO;
        }

        public List<LogoDTO> GetLogos()
        {
            var allLogos = _dbContext.Logo.Select(Logos => new LogoDTO()
            {
                LogoID = Logos.Id,
                NameLogo = Logos.Name,
                ImageLogo = Logos.Path
            }).ToList();
            return allLogos;
        }

        public async Task<AddLogoDTO?> UpdateLogo(int logoID, AddLogoDTO addLogoDTO)
        {
            var logoDomain = _dbContext.Logo.FirstOrDefault(x => x.Id == logoID);
            if (logoDomain != null)
            {
                // Save the old folder name
                var oldFolderName = logoDomain.Name;
                var oldFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo", oldFolderName);

                // Update folder name
                logoDomain.Name = addLogoDTO.NameLogo;

                if (addLogoDTO.Image != null && addLogoDTO.Image.Length > 0)
                {
                    // Use the new folder name to create the folder path
                    var newFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo", addLogoDTO.NameLogo);

                    // Create directory if it doesn't exist
                    if (!Directory.Exists(newFolderPath))
                    {
                        Directory.CreateDirectory(newFolderPath);
                    }

                    var uniqueFileName = "Image" + addLogoDTO.Image.FileName;
                    var imagePath = Path.Combine(newFolderPath, uniqueFileName);
                    using (var stream = File.Create(imagePath))
                    {
                        await addLogoDTO.Image.CopyToAsync(stream);
                    }
                    logoDomain.Path = uniqueFileName;

                    // Delete the old folder if it exists
                    if (Directory.Exists(oldFolderPath))
                    {
                        Directory.Delete(oldFolderPath, true);
                    }
                }

                _dbContext.Logo.Update(logoDomain);
                await _dbContext.SaveChangesAsync();
            }

            return addLogoDTO;
        }


        public async Task<Logo?> DeleteAll()
        {
            var allLogos = _dbContext.Logo.ToList();
            foreach (var logo in allLogos)
            {
                if (!string.IsNullOrEmpty(logo.Path))
                {
                    var previousImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo", logo.Path);
                    if (File.Exists(previousImagePath))
                    {
                        File.Delete(previousImagePath);
                    }
                }
            }

            // Xóa tất cả các thư mục trong thư mục "Logo"
            var logoFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo");
            if (Directory.Exists(logoFolderPath))
            {
                Directory.Delete(logoFolderPath, true); // Đặt tham số thứ hai là true để xóa cả thư mục con và nội dung bên trong
            }

            _dbContext.Logo.RemoveRange(allLogos);
            await _dbContext.SaveChangesAsync();
            return null;
        }
    }

}
