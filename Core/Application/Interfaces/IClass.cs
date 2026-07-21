using Domain.Entities;
namespace Application.Interfaces
{
    public interface Iclass
    {
       public List<Classs>GetAllClasses();
       public void AddClasses (Classs classs);
       public Classs? GetClassById(int id);
    }
}