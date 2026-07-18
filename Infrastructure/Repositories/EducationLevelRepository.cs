using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class EducationLevelRepository :IEducationLevel
    {
       public readonly ApplicationDBContext _dbcontext;
       public EducationLevelRepository(ApplicationDBContext dBContext)
        {
            _dbcontext=dBContext;
        }
        public List<EducationLevel>GetAllEducationLevel()
        {
            return _dbcontext.EducationLevels.ToList();
        }
        public void AddEducationLevel(EducationLevel educationLevel)
        {
            _dbcontext.EducationLevels.Add(educationLevel);
            _dbcontext.SaveChanges();
        }
    }
}