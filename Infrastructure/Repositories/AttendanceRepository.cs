using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class AttendanceRepository :IAttendance
    {
        private readonly ApplicationDBContext _dbcontext;
        public AttendanceRepository (ApplicationDBContext dBContext)
        {
            _dbcontext=dBContext;
        }
        public List<Attendance> GetAllAttendances()
        {
            return _dbcontext.Attendances.ToList();
        }
        public void AddAttendance(Attendance attendance)
        {
            _dbcontext.Attendances.Add(attendance);
            _dbcontext.SaveChanges();
        }
    }
}