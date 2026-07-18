using Domain.Entities;
using Application.Services.ClassStudentServices;
namespace Application.Interfaces
{
    public interface IClassStudent
    {
        public List<classstudent>GetAllClassStudent();
        public void AddClassStudent (classstudent classStudent);
    }
}