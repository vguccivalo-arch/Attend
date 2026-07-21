using Domain.Entities;

namespace Application.Services.ClassStudentServices
{
    public interface IClassStudentService
    {
        public List<classstudent>GetAllClassStudent();
        public void AddClassStudent (classstudent classStudent);
        
        
    }
}