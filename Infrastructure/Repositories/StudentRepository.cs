 using Domain.Entities;
 using Application.Interfaces;
 using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
      private readonly ApplicationDBContext _dbcontext;
      public StudentRepository(ApplicationDBContext dBContext)
    {
      _dbcontext=dBContext;
    }
    public List<Student>GetAllStudents()
      {
        return _dbcontext.Students.ToList();
            
    }
    public void AddStudent(Student student)
    {
      _dbcontext.Students.Add(student);
      _dbcontext.SaveChanges();
    }
    public Student GetStudentById(int id)
        {
            return _dbcontext.Students.FirstOrDefault(s => s.Id == id);

        }
    }
    
}