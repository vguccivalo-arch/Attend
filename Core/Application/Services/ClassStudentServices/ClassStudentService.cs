using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.ClassStudentServices
{
    public class ClassStudentService : IClassStudentService
    {
        public readonly IClassStudent _CLASSSTUDENT;
        public  ClassStudentService(IClassStudent CLASSSTUDENT)
        {
            _CLASSSTUDENT = CLASSSTUDENT;
        }
       public List<classstudent>GetAllClassStudent()
        {
            return _CLASSSTUDENT.GetAllClassStudent();
        }
    }
}