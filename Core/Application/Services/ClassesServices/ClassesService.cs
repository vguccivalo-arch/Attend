
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
 namespace Application.Services.ClassesServices
{
    public class ClassesService :IClassesService
    {
       private readonly Iclass _Classs;
       public ClassesService(Iclass classs)
        {
        _Classs=classs;
        }
        public List<GetCLassDTO>GetAllClasses()
        {
            return _Classs.GetAllClasses(); 
        
        }
        public void AddClasses(AddClassDTO classs)
        {
            _Classs.AddClasses(classs);
        }
        public GetCLassDTO? GetClassById(int id)
        {
            return _Classs.GetClassById(id);
        }
        public void UpdateClass(UpdateClassDTO classs)
        {
            _Classs.UpdateClass(classs);
        }
        public void DeleteClass(DeleteClassDTO classs)
        {
            _Classs.DeleteClass(classs);
        }
    }
}