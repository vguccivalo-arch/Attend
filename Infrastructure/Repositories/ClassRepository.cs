 using Domain.Entities;
 using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class ClassRepository :Iclass
    {
          public List<Classs>GetAllClasses()
         {
             return new List<Classs>
        {
            new Classs {Id=1,ClassName="Class A",Classcode="01A",InstructorName="Mr. Wright",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
            new Classs {Id=2,ClassName="Class B",Classcode="02A",InstructorName="Ms. Sharp",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
            new Classs {Id=3,ClassName="Class C",Classcode="03A",InstructorName="Ms. Bright",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
            new Classs {Id=4,ClassName="Class D",Classcode="04A",InstructorName="Mr. Stone",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
        };
         }
    }
}