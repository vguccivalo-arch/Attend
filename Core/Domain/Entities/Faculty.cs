namespace Domain.Entities
{
    public class faculty
    {
        public int Id{get;set;}
        public string FacultyName{get;set;}
       

        public ICollection<Classs> classses {get;set;}
       
      
    }
}