 using Domain.Entities;
 using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Application.DTOs;
using Microsoft.VisualBasic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Infrastructure.Repositories
{
    public class ClassRepository :Iclass
    {
        private readonly ApplicationDBContext _dbcontext;
        public ClassRepository(ApplicationDBContext dBContext)
        {
            _dbcontext=dBContext;
        }
          public async Task <List<GetCLassDTO>>GetAllClassesAsync()
         {
             return await _dbcontext.classes.Select (cc => new GetCLassDTO
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



             } ).ToListAsync();
         }
        public async Task AddClassesAsync(AddClassDTO classs)
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

            }); await _dbcontext.SaveChangesAsync();
           
        }
        public async Task <GetCLassDTO?> GetClassByIdAsync(int id)
        {
    return await _dbcontext.classes.Where (cc=> cc.Id == id ).Select (cc => new GetCLassDTO
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
    } ).FirstOrDefaultAsync(CC => CC.Id==id);
        }
       public async  Task UpdateClassAsync(UpdateClassDTO classs)
        {
           var existingclass =await _dbcontext.classes.FirstOrDefaultAsync(cc => cc.Id == classs.Id);
           if(existingclass !=null)
            {
                existingclass.ClassName=classs.ClassName;
               existingclass.Classcode=classs.Classcode;
               existingclass.InstructorName=classs.InstructorName;
               existingclass.Department=classs.Department;
               existingclass.Schoolyear=classs.Schoolyear;
               existingclass.EducationLevelId=classs.EducationLevelId; 

             await  _dbcontext.SaveChangesAsync();
            }
        }
        public async Task DeleteClassAsync(DeleteClassDTO classs)
        {
            var existingclass =await _dbcontext.classes.FirstOrDefaultAsync(cc=> cc.Id ==classs.Id);
            if(existingclass != null)
            {
                existingclass.Status="Deleted";
               await  _dbcontext.SaveChangesAsync();
            }
        }
    }
}