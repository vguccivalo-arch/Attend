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
         public DbSet<Classs> classes{get;set;}
         public DbSet<Attendance>Attendances{get;set;}

         public DbSet<classstudent>ClassStudent{get;set;}
         public DbSet<EducationLevel>EducationLevels{get;set;}
         public DbSet<faculty>Faculties{get;set;}
         public DbSet<StudentAttendance>StudentAttendances{get;set;}


    }
}