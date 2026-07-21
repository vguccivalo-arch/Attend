 using Domain.Entities;
 using Application.Interfaces;
 using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Application.DTOs;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
      private readonly ApplicationDBContext _dbcontext;
      public StudentRepository(ApplicationDBContext dBContext)
    {
      _dbcontext=dBContext;
    }
    public List<GetStudentDTO>GetAllStudents()
      {
        return _dbcontext.Students.Select( s => new GetStudentDTO
        {
               Id=s.Id,
               FullName=s.FullName,
               Sex=s.Sex,
               DateOfBirth=s.DateOfBirth,
               Phone=s.Phone,
               Email=s.Email,
               Address=s.Address,
               ParentNames=s.ParentNames,
               ParentPhoneNumber=s.ParentPhoneNumber,
               UserAdded=s.UserAdded,
               DateAdded=s.DateAdded,
               Status=s.Status,
       
        } ).ToList();
            
    }
    public void AddStudent(AddStudentDTO student)
    {
      _dbcontext.Students.Add(new Student
      {
        FullName=student.FullName,
        Sex=student.Sex,
        DateOfBirth=student.DateOfBirth,
        Phone=student.Phone,
        Email=student.Email,
        Address=student.Address,
        ParentNames=student.ParentNames,
        ParentPhoneNumber=student.ParentPhoneNumber,
        UserAdded="Admin",
        DateAdded=DateTime.UtcNow,
        Status="Active"
      });
      _dbcontext.SaveChanges();
    }
    public GetStudentDTO? GetStudentById(int id)
        {
            return _dbcontext.Students.Where (s => s.Id == id).Select(s=> new GetStudentDTO
            {
               Id=s.Id,
               FullName=s.FullName,
               Sex=s.Sex,
               DateOfBirth=s.DateOfBirth,
               Phone=s.Phone,
               Email=s.Email,
               Address=s.Address,
               ParentNames=s.ParentNames,
               ParentPhoneNumber=s.ParentPhoneNumber,
               UserAdded=s.UserAdded,
               DateAdded=s.DateAdded,
               Status=s.Status,
            } ).FirstOrDefault(s => s.Id == id);

        }
        public void UpdateStudent(UpdateStudentDTO student)
    {
      //  _dbcontext.Students.Update(student);
      // _dbcontext.SaveChanges();
      var ExistingStudent=_dbcontext.Students.FirstOrDefault(s => s.Id ==student.Id);
      if (ExistingStudent != null)
      {
        ExistingStudent.FullName=student.FullName;
        ExistingStudent.DateOfBirth=student.DateOfBirth;
        ExistingStudent.Email=student.Email;


        _dbcontext.SaveChanges();
      }
    }
   public void DeleteStudent(DeleteStudentDTO student)
{
    var existingStudent = _dbcontext.Students.FirstOrDefault(ss => ss.Id == student.Id);
    
    if (existingStudent != null)
    {
        existingStudent.Status = "Deleted";
        _dbcontext.SaveChanges();
    }
}
    }
    
}