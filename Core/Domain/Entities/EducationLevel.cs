namespace Domain.Entities
{
    public class EducationLevel
    {
        public int Id{get;set;}
        public string LevelName{get;set;}
        public string Description { get; set; }
        // navigation property
        public ICollection<Classs>Classes{get;set;}
    }
}