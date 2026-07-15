using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Repositories;
using System.Buffers;
namespace Infrastructure.DependencyInjection
{
    
    public static class ServiceContainer
    {
         public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
          
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ATTENDCON"))
            );
            services.AddScoped<IStudent, StudentRepository>();
            services.AddScoped<Iclass, ClassRepository>();
            services.AddScoped<IAttendance, AttendanceRepository>();
            services.AddScoped<IClassStudent,ClassStudentRepository>();
            services.AddScoped<IEducationLevel,EducationLevelRepository>();
            return services;

        }
    }
}