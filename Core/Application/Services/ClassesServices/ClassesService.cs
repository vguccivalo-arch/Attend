
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
        public async Task <List<GetCLassDTO>>GetAllClassesAsync()
        {
            return await _Classs.GetAllClassesAsync(); 
        
        }
        public async Task AddClassesAsync(AddClassDTO classs)
        {
           await  _Classs.AddClassesAsync(classs);
        }
        public async Task <GetCLassDTO?> GetClassByIdAsync(int id)
        {
            return await  _Classs.GetClassByIdAsync(id);
        }
        public async Task UpdateClassAsync(UpdateClassDTO classs)
        {
           await  _Classs.UpdateClassAsync(classs);
        }
        public async Task  DeleteClassAsync(DeleteClassDTO classs)
        {
           await  _Classs.DeleteClassAsync(classs);
        }
    }
}