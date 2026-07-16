using System.Security.Cryptography.X509Certificates;
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
    }
}