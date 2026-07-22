using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface Iclass
    {
       public List<GetCLassDTO>GetAllClasses();
       public void AddClasses (AddClassDTO classs);
       public GetCLassDTO? GetClassById(int id);
       public void UpdateClass(UpdateClassDTO classs);
       public void DeleteClass(DeleteClassDTO classs);
    }
}