using Domain.Entities;
using Application.Interfaces;
namespace Application.Services.EDucationLevelServices
{
    public class  EDucationLevelService : IEducationLevelService
    {
    private readonly IEducationLevel _EDUCATIONLEVEL;
    public EDucationLevelService (IEducationLevel EDUCATIONLEVEL)
    {
        _EDUCATIONLEVEL = EDUCATIONLEVEL;
    }
    public List<EducationLevel> GetAllEducationLevel()
    {
        return _EDUCATIONLEVEL.GetAllEducationLevel();
    }
    public void AddEducationLevel(EducationLevel educationLevel)
        {
            _EDUCATIONLEVEL.AddEducationLevel(educationLevel);
        }
    }

}