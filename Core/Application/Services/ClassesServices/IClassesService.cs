using Application.DTOs;
using Domain.Entities;
namespace Application.Services.ClassesServices
{
    public interface IClassesService
    {
        public List<GetCLassDTO>GetAllClasses();
        public void AddClasses (AddClassDTO classs);
        public GetCLassDTO? GetClassById(int id);
        public void UpdateClass(UpdateClassDTO classs);
        public void DeleteClass(DeleteClassDTO classs);
    }
}