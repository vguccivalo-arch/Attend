using Application.Interfaces;
using Domain.Entities;
namespace Application.Services.AttendanceServices
{
    public class AttendanceService :IAttendanceService
    {
       public readonly IAttendance _ATTENDANCE;
       public AttendanceService(IAttendance ATTENDANCE)
        {
            _ATTENDANCE=ATTENDANCE;
        }
        public List<attendance> GetAllAttendances()
        {
            return _ATTENDANCE.GetAllAttendances();
        }

    }
}