using BNI.Data;
using BNI.Models.Domain;
using BNI.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace BNI.Respositories.StepsRepositories
{
    public class StepsRepository : IStepsRepository
    {
        private readonly AppDbContext _context;

        public StepsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<AddStepDTO> CreateStepAsync(AddStepDTO addStepDTO)
        {
            var step = new Step
            {
                Title = addStepDTO.Title,
                Description = addStepDTO.Description,
                Member_Id = addStepDTO.Member_Id
            };
            _context.Step.Add(step);
            await _context.SaveChangesAsync();
            return addStepDTO;
        }

        public async Task<Step> DeleteStepAsync(int id)
        {
            var deleteStep = _context.Step.FirstOrDefault(x => x.Id == id);
            _context.Step.Remove(deleteStep);
            await _context.SaveChangesAsync();
            return deleteStep;
        }

        public async Task<StepsDTO> GetStepAsync(int id)
        {
            var get = _context.Step.FirstOrDefault(x => x.Id == id);
            var stepsDTO = new StepsDTO
            {
                Id = get.Id,
                Title = get.Title,
                Description = get.Description,
                Member = get.Member.FirstName + " " + get.Member.LastName
            };
            return stepsDTO;
        }

        public async Task<List<StepsDTO>> GetStepsAsync()
        {
            var allSteps = _context.Step.ToList();
            var stepsDTO = allSteps.Select(x => new StepsDTO
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Member = x.Member.FirstName + " " + x.Member.LastName
            }).ToList();
            return stepsDTO;
        }

        public async Task<AddStepDTO> UpdateStepAsync(int id, AddStepDTO step)
        {
            var updateStep = _context.Step.FirstOrDefault(x => x.Id == id);
            updateStep.Title = step.Title;
            updateStep.Description = step.Description;
            updateStep.Member_Id = step.Member_Id;
            await _context.SaveChangesAsync();
            return step;

        }
    }
}
