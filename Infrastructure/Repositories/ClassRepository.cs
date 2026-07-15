 using Domain.Entities;
 using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class ClassRepository :Iclass
    {
          public List<Class>GetAllClasses()
         {
             return new List<Class>
        {
            new Class {Id=1,ClassName="Class A",Classcode="01A",InstructorName="Mr. Wright",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
            new Class {Id=2,ClassName="Class B",Classcode="02A",InstructorName="Ms. Sharp",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
            new Class {Id=3,ClassName="Class C",Classcode="03A",InstructorName="Ms. Bright",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
            new Class {Id=4,ClassName="Class D",Classcode="04A",InstructorName="Mr. Stone",faculty="Software developpement",Department="Computer Engineering",Schoolyear="2025-2026",useradded="Admin",DateAdded=new DateTime(2026,5,5),Status="Active"},
        };
         }
    }
}