namespace Application.DTOs
{
    public  class AddStudentDTO
    {
        public string FullName{get;set;}
        public string Sex{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string Address{get;set;}
        public string ParentNames{get;set;}
        public string ParentPhoneNumber{get;set;}


    }
    public class UpdateStudentDTO
    {
        public int Id{get;set;}
        public string FullName{get;set;}
        public string Sex{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string Address{get;set;}
        public string ParentNames{get;set;}
        public string ParentPhoneNumber{get;set;}
    }
    public class DeleteStudentDTO
    {
        public int Id{get;set;}
    
    }
 public class GetStudentDTO
    {
         public int Id{get;set;}
        public string FullName{get;set;}
        public string Sex{get;set;}
        public DateTime DateOfBirth{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string Address{get;set;}
        public string ParentNames{get;set;}
        public string ParentPhoneNumber{get;set;}
         public string UserAdded{get;set;}
        public DateTime DateAdded{get;set;}
        public string Status{get;set;}



    }
 }