using Domain.Entities;
namespace Application.Services.ClassesServices
{
    public interface IClassesService
    {
        public List<Classs>GetAllClasses();
        public void AddClasses (Classs classs);
    }
}