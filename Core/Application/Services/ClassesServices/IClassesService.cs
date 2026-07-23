using Application.DTOs;
using Domain.Entities;
namespace Application.Services.ClassesServices
{
    public interface IClassesService
    {
        Task <List<GetCLassDTO>>GetAllClassesAsync();
        Task AddClassesAsync (AddClassDTO classs);
        Task <GetCLassDTO?> GetClassByIdAsync(int id);
        Task UpdateClassAsync(UpdateClassDTO classs);
        Task DeleteClassAsync(DeleteClassDTO classs);
    }
}