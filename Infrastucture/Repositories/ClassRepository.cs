 using Domain.Entities;
 using Application.interfaces;
namespace Infrastructure.Repositories
{
    public class ClassRepository :Iclass
    {
          public List<Class>GetAllClasses()
         {
             return new List<Class>
        {
            new Class {ClassId=1,ClassName="Class A",Classcode="01A",InstructorName="Mr. Wright",Schoolyear="2025-2026"},
            new Class {ClassId=2,ClassName="Class B",Classcode="02A",InstructorName="Ms. Sharp",Schoolyear="2025-2026"},
            new Class {ClassId=3,ClassName="Class C",Classcode="03A",InstructorName="Ms. Bright",Schoolyear="2025-2026"},
            new Class {ClassId=4,ClassName="Class D",Classcode="04A",InstructorName="Mr. Stone",Schoolyear="2025-2026"},
        };
         }
    }
}