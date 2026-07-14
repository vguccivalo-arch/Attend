 using Domain.Entities;
 using Application.interfaces;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
    public List<Student>GetAllStudents()
      {
        return new List <Student>
        {
        new Student{Id=1, Name ="Mugisha Aime", Sex ="Male", DateOfBirth= new DateTime(1999,5,5),Phone="07876555454",Email="Mugame@gmail.com"},
         new Student{Id=2, Name ="Irebe Kelly", Sex ="Male", DateOfBirth= new DateTime(2000,5,5),Phone="07876555454",Email="Mugame@gmail.com"},
          new Student{Id=3, Name ="Gaju Bruce", Sex ="Male", DateOfBirth= new DateTime(2007,5,5),Phone="07876555454",Email="Mugame@gmail.com"},
           new Student{Id=4, Name ="Cyubahiro Quintin", Sex ="Male", DateOfBirth= new DateTime(1992,5,5),Phone="07876555454",Email="Mugame@gmail.com"}
        };
            
    }
    }
    
}