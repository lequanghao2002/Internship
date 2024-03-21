using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BNI.Respositories.CategorySupportRepositories.CategorySupportRepository
{
    public class CategorySupportRepository : ICategorySupportRepository
    {
        private readonly AppDbContext _dbContext;

        public CategorySupportRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<AddRequestCategoySupportDTO> AddCategorySupport(AddRequestCategoySupportDTO addRequest)
        {
            var newSupportCategory = new Category_Support
            {
                Title = addRequest.Title,
                Description = addRequest.Description
            };
            if (addRequest.Image.Length > 0)
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Category", newSupportCategory.Title);
                Directory.CreateDirectory(folderPath);
                var uniqueFileName = "Image" + addRequest.Image.FileName;
                var imagePath = Path.Combine(folderPath, uniqueFileName);
                using (var stream = File.Create(imagePath))
                {
                    await addRequest.Image.CopyToAsync(stream);
                }
                newSupportCategory.Image = uniqueFileName;
            }
            else
            {
                newSupportCategory.Image = "";
            }
            _dbContext.Category_Support.Add(newSupportCategory);
            _dbContext.SaveChanges();
            return addRequest;
        }

        public CategoySupportDTO categorySupport(int id)
        {
            var categoySupport = _dbContext.Category_Support.FirstOrDefault(c => c.Id == id);
            if (categoySupport != null)
            {
                return new CategoySupportDTO()
                {
                    Id = categoySupport.Id,
                    Title = categoySupport.Title,
                    Description = categoySupport.Description,
                    Image = categoySupport.Image
                };
            }
            return null;
        }

        public List<CategoySupportDTO> categorySupports()
        {
            var categoySupports = _dbContext.Category_Support.Select(c => new CategoySupportDTO()
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                Image = c.Image
            }).ToList();
            return categoySupports;
        }

        public Category_Support? DeleteCategorySupport(int categoySupportId)
        {
            var categoySupport = _dbContext.Category_Support.Find(categoySupportId);
            if (!string.IsNullOrEmpty(categoySupport.Title))
            {
                var previousImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Logo", categoySupport.Title);
                if (Directory.Exists(previousImagePath))
                {
                    Directory.Delete(previousImagePath, true);
                }
            }
            if (categoySupport != null)
            {
                _dbContext.Category_Support.Remove(categoySupport);
                _dbContext.SaveChanges();
            }
            return categoySupport;
        }

        public async Task<AddRequestCategoySupportDTO?> UpdateCategorySupport(int categoySupportId, AddRequestCategoySupportDTO categoySupport)
        {
            var CategorySupportDomain = _dbContext.Category_Support.FirstOrDefault(x => x.Id == categoySupportId);
            if (CategorySupportDomain != null)
            {
                // Save the old folder name
                var oldFolderName = CategorySupportDomain.Title;
                var oldFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Category", oldFolderName);

                // Update folder name
                CategorySupportDomain.Title = categoySupport.Title;

                if (categoySupport.Image != null && categoySupport.Image.Length > 0)
                {
                    // Use the new folder name to create the folder path
                    var newFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Category", categoySupport.Title);

                    // Create directory if it doesn't exist
                    if (!Directory.Exists(newFolderPath))
                    {
                        Directory.CreateDirectory(newFolderPath);
                    }

                    var uniqueFileName = "Image" + categoySupport.Image.FileName;
                    var imagePath = Path.Combine(newFolderPath, uniqueFileName);
                    using (var stream = File.Create(imagePath))
                    {
                        await categoySupport.Image.CopyToAsync(stream);
                    }
                    CategorySupportDomain.Title = uniqueFileName;

                    // Delete the old folder if it exists
                    if (Directory.Exists(oldFolderPath))
                    {
                        Directory.Delete(oldFolderPath, true);
                    }
                }

                _dbContext.Category_Support.Update(CategorySupportDomain);
                await _dbContext.SaveChangesAsync();
            }

            return categoySupport;
        }
        public async Task<Category_Support?> DeleteAll()
        {
            var allCateogires = _dbContext.Category_Support.ToList();
            foreach (var category in allCateogires)
            {
                if (!string.IsNullOrEmpty(category.Title))
                {
                    var previousImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Category", category.Title);
                    if (File.Exists(previousImagePath))
                    {
                        File.Delete(previousImagePath);
                    }
                }
            }

            // Xóa tất cả các thư mục trong thư mục "Logo"
            var logoFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "Category");
            if (Directory.Exists(logoFolderPath))
            {
                Directory.Delete(logoFolderPath, true); // Đặt tham số thứ hai là true để xóa cả thư mục con và nội dung bên trong
            }

            _dbContext.Category_Support.RemoveRange(allCateogires);
            await _dbContext.SaveChangesAsync();
            return null;
        }
    }
}
