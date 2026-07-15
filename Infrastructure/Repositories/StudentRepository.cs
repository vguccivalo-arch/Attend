 using Domain.Entities;
 using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudent
    {
    public List<Student>GetAllStudents()
      {
        return new List <Student>
        {
        new Student{Id=1, FullName ="Mugisha Aime", Sex ="Male", DateOfBirth= new DateTime(1999,5,5),Phone="07876555454",Email="Mugame@gmail.com", RegNumber= "24-S09-0012",Address="Kigali",ParentNames="Manzi Benet", Parentphonenumber= "07876555454",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
         new Student{Id=2, FullName ="Irebe Kelly", Sex ="Male", DateOfBirth= new DateTime(2000,5,5),Phone="07876555454",Email="Mugame@gmail.com", RegNumber= "24-S09-0017",Address="Kigali",ParentNames="Hirwa aime malik", Parentphonenumber= "07889965588",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
          new Student{Id=3, FullName ="Gaju Bruce", Sex ="Male", DateOfBirth= new DateTime(2007,5,5),Phone="07876555454",Email="Mugame@gmail.com", RegNumber= "24-S09-0018",Address="Kigali",ParentNames="Maniriho", Parentphonenumber= "0797655554",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
           new Student{Id=4, FullName ="Cyubahiro Quintin", Sex ="Male", DateOfBirth= new DateTime(1992,5,5),Phone="07876555454",Email="Mugame@gmail.com", RegNumber= "24-S09-0015",Address="Kigali",ParentNames="Nezerwa john", Parentphonenumber= "07996555478",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"}
        };
            
    }
    }
    
}