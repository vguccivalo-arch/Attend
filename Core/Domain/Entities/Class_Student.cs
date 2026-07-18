namespace Domain.Entities
{
    public class classstudent
    {   
        public int Id{get;set;}
        public int ClasssId{get;set;}
        
       public int StudentId{get;set;}

       public Classs Classs{get;set;}
       public Student Student{get;set;}

    }
}