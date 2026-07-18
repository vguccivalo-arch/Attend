using Domain.Entities;
namespace Application.Interfaces
{
    public interface IEducationLevel
    {
        public List<EducationLevel>GetAllEducationLevel();
        public void AddEducationLevel(EducationLevel educationLevel);
    }
}