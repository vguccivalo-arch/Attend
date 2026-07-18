using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    public class ClassStudentRepository : IClassStudent

    {
        private readonly ApplicationDBContext _dbcontext;
        public ClassStudentRepository(ApplicationDBContext dBContext)
        {
            _dbcontext=dBContext;
        }
        public List<classstudent> GetAllClassStudent()
        {
            return _dbcontext.ClassStudent.ToList();
        }
        public void AddClassStudent(classstudent classtudent)
        {
            _dbcontext.ClassStudent.Add(classtudent);
            _dbcontext.SaveChanges();
        }
    }
}