using Application.Services.ClassesServices;
using Application.Services.StudentServices;
using Application.Services.AttendanceServices;
using Application.Services.EDucationLevelServices;
using Application.Services.ClassStudentServices;
using Microsoft.Extensions.DependencyInjection;
namespace Application.DependencyInjection
{
    public static class ServiceContainer
    {
      public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClassesService, ClassesService>();
            services.AddScoped<IAttendanceService, AttendanceService>();
            services.AddScoped<IClassStudentService, ClassStudentService>();
            services.AddScoped<IEducationLevelService, EDucationLevelService>();
            return services;
        }
    }
}