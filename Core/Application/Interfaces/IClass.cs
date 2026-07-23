using Domain.Entities;
using Application.DTOs;
namespace Application.Interfaces
{
    public interface Iclass
    {
       Task <List<GetCLassDTO>>GetAllClassesAsync();
        Task AddClassesAsync (AddClassDTO classs);
       Task  <GetCLassDTO?> GetClassByIdAsync(int id);
       Task UpdateClassAsync(UpdateClassDTO classs);
       Task DeleteClassAsync(DeleteClassDTO classs);
    }
}