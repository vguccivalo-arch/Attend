 using Domain.Entities;
 using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Application.DTOs;
using Microsoft.VisualBasic;
using System.Data.Common;
using System.Runtime.CompilerServices;
namespace Infrastructure.Repositories
{
    public class ClassRepository :Iclass
    {
        private readonly ApplicationDBContext _dbcontext;
        public ClassRepository(ApplicationDBContext dBContext)
        {
            _dbcontext=dBContext;
        }
          public List<GetCLassDTO>GetAllClasses()
         {
             return _dbcontext.classes.Select (cc => new GetCLassDTO
             {
                 Id=cc.Id,
                 ClassName=cc.ClassName,
                 Classcode=cc.Classcode,
                 InstructorName=cc.InstructorName,
                 Department=cc.Department,
                 Schoolyear=cc.Schoolyear,
                 useradded=cc.useradded,
                 DateAdded=cc.DateAdded,
                 Status=cc.Status,
                 EducationLevelId=cc.EducationLevelId,
                 FacultyId=cc.FacultyId



             } ).ToList();
         }
        public void AddClasses(AddClassDTO classs)
        {
            _dbcontext.classes.Add(new Classs
            {
                ClassName=classs.ClassName,
                Classcode=classs.Classcode,
                InstructorName=classs.InstructorName,
                Department=classs.Department,
                Schoolyear=classs.Schoolyear,
                EducationLevelId=classs.EducationLevelId,
                FacultyId=classs.FacultyId

            }); _dbcontext.SaveChanges();
           
        }
        public GetCLassDTO? GetClassById(int id)
        {
    return _dbcontext.classes.Where (cc=> cc.Id == id ).Select (cc => new GetCLassDTO
    {
         Id=cc.Id,
                 ClassName=cc.ClassName,
                 Classcode=cc.Classcode,
                 InstructorName=cc.InstructorName,
                 Department=cc.Department,
                 Schoolyear=cc.Schoolyear,
                 useradded=cc.useradded,
                 DateAdded=cc.DateAdded,
                 Status=cc.Status,
                 EducationLevelId=cc.EducationLevelId,
                 FacultyId=cc.FacultyId
    } ).FirstOrDefault(CC => CC.Id==id);
        }
       public void UpdateClass(UpdateClassDTO classs)
        {
           var existingclass = _dbcontext.classes.FirstOrDefault(cc => cc.Id == classs.Id);
           if(existingclass !=null)
            {
                existingclass.ClassName=classs.ClassName;
               existingclass.Classcode=classs.Classcode;
               existingclass.InstructorName=classs.InstructorName;
               existingclass.Department=classs.Department;
               existingclass.Schoolyear=classs.Schoolyear;
               existingclass.EducationLevelId=classs.EducationLevelId; 

               _dbcontext.SaveChanges();
            }
        }
        public void DeleteClass(DeleteClassDTO classs)
        {
            var existingclass =_dbcontext.classes.FirstOrDefault(cc=> cc.Id ==classs.Id);
            if(existingclass != null)
            {
                existingclass.Status="Deleted";
                _dbcontext.SaveChanges();
            }
        }
    }
}