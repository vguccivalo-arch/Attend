using Domain.Entities;
using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class ClassStudentRepository : IClassStudent
    {
        public List<classstudent> GetAllClassStudent()
        {
            return new List<classstudent>
            {
                new classstudent{Id=1,ClassId=1,StudentId=2}
              
            };
        }
    }
}