namespace Domain.Entities
{
    public class attendance
    {
        public int Id{get;set;}
        public int StudentId{get;set;}
        public int ClassId{get;set;}
        public DateTime Date{get;set;}
        public TimeOnly Time{get;set;}
        public string Status{get;set;}
        
    }
}