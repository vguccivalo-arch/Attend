namespace Core.Application.Services.StudentServices

{
    public class StudentService:IStudentService
    {
      public List<Student>GetAllStudents()
      {
        return new List <Student>
        {
        new Student{Id=1, Name ="Mugisha Aime", Sex ="Male", DateofBirth= new DateTime(1999,5,5),Phone="07876555454",Email="Mugame@gmail.com"},
         new Student{Id=2, Name ="Irebe Kelly", Sex ="Male", DateofBirth= new DateTime(2000,5,5),Phone="07876555454",Email="Mugame@gmail.com"},
          new Student{Id=3, Name ="Gaju Bruce", Sex ="Male", DateofBirth= new DateTime(2007,5,5),Phone="07876555454",Email="Mugame@gmail.com"},
           new Student{Id=4, Name ="Cyubahiro Quintin", Sex ="Male", DateofBirth= new DateTime(1992,5,5),Phone="07876555454",Email="Mugame@gmail.com"}
        };
            
      }

    }
      public class Student {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Sex{get;set; }
        public DateTime DateofBirth {get;set;}
        public string Phone {get;set;}
        public string Email{get;set;}
    }


}