using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
     public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options): base(options)
        {
        }
        public DbSet<Student> Students{get;set;}
         public DbSet<Class> classs{get;set;}


    }
}