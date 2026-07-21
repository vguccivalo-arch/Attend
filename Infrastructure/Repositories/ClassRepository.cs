 using Domain.Entities;
 using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
namespace Infrastructure.Repositories
{
    public class ClassRepository :Iclass
    {
        private readonly ApplicationDBContext _dbcontext;
        public ClassRepository(ApplicationDBContext dBContext)
        {
            _dbcontext=dBContext;
        }
          public List<Classs>GetAllClasses()
         {
             return _dbcontext.classes.ToList();
         }
        public void AddClasses(Classs classs)
        {
            _dbcontext.classes.Add(classs);
            _dbcontext.SaveChanges();
        }
        public Classs? GetClassById(int id)
        {
    return _dbcontext.classes.FirstOrDefault(CC => CC.Id==id);
        }

    }
}