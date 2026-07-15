using Domain.Entities;
using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class AttendanceRepository :IAttendance
    {
        public List<attendance> GetAllAttendances()
        {
            return new List<attendance>
            {
                new attendance{Id=1,StudentId=1,ClassId=2,Date=new DateTime(2026/7/7),Time=new TimeOnly(15,09),Status="Present"}
            };
        }
    }
}