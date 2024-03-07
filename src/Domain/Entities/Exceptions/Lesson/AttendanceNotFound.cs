namespace Domain.Entities.Exceptions.Lesson
{
    public class AttendanceNotFound : GlobalException
    {
        public AttendanceNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Attendance Not Found !";
        }
    }
}
