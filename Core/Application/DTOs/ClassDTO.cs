namespace Application.DTOs
{
    public class AddClassDTO
    {
        public string ClassName{get;set;}
        public string Classcode{get;set;}
        public string InstructorName{get;set;}
        
        public string Department{get;set;}
        public string Schoolyear{get;set;}
        public int EducationLevelId{get;set;}
        public int FacultyId{get;set;}
        

    }
    public class UpdateClassDTO
    {
         public int Id{get;set;}
         public string ClassName{get;set;}
        public string Classcode{get;set;}
        public string InstructorName{get;set;}
        
        public string Department{get;set;}
        public string Schoolyear{get;set;}
        public int EducationLevelId{get;set;}
        
    }
    public class DeleteClassDTO
    {
         public int Id{get;set;}
        
    }
    public class GetCLassDTO
    {
        public int Id{get;set;}
        public string ClassName{get;set;}
        public string Classcode{get;set;}
        public string InstructorName{get;set;}
        
        public string Department{get;set;}
        public string Schoolyear{get;set;}
        public string useradded{ get; set; }
        public  DateTime DateAdded{ get; set; }
        public string Status{ get; set; }
        public int EducationLevelId{get;set;}
        public int FacultyId{get;set;}

    }
}