using Domain.Entities;
using Application.Interfaces;
namespace Infrastructure.Repositories
{
    public class AttendanceRepository :IAttendance
    {
        public List<Attendance> GetAllAttendances()
        {
            return new List<Attendance>
            {
                new Attendance{Id=1,ClassId=2,Date=new DateTime(2026/7/7),Status="Present"}
            };
        }
    }
}