namespace Domain.Entities.Exceptions.Users
{
    public class TeacherNotFound : GlobalException
    {
        public TeacherNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Teacher Not Found !";
        }
    }
}
