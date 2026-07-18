namespace Domain.Entities
{
    public class StudentAttendance
    {
        public int Id{get;set;}
        public int AttendanceId{get;set;}
        public TimeOnly Time{get;set;}
        public string Status{get;set;}

       
        public Attendance Attendance{get;set;}
    }
}