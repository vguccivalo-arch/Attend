using Domain.Entities;
namespace Application.Services.EDucationLevelServices
{
    public interface IEducationLevelService
    {
        public List<EducationLevel>GetAllEducationLevel();
        public void AddEducationLevel(EducationLevel educationLevel);
    }
}