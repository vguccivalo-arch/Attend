
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
        public List<Classs>GetAllClasses()
        {
            return _Classs.GetAllClasses(); 
        
        }
        public void AddClasses(Classs classs)
        {
            _Classs.AddClasses(classs);
        }
    }
}