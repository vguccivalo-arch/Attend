using Application.Interfaces;
using Domain.Entities;
namespace Infrastructure.Repositories
{
    public class EducationLevelRepository :IEducationLevel
    {
        public List<EducationLevel> GetAllEducationLevel()
        {
            return new List<EducationLevel>
            {    
                new EducationLevel{Id=1,LevelName="Primary",Description="Completion of Primary education"},
                new EducationLevel{Id=2,LevelName="HighSchool",Description="Completion of secondary education"},
                new EducationLevel{Id=3,LevelName="Bachelor",Description="Undergraduate academic degree"},
                 new EducationLevel{Id=4,LevelName="Master",Description="Post-graduate academic degree"},
                  new EducationLevel{Id=5,LevelName="PhD",Description="Highest level of academic degree"}
            };
        }
    }
}