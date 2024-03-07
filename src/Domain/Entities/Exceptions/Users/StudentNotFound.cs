namespace Domain.Entities.Exceptions.Users
{
    public class StudentNotFound : GlobalException
    {
        public StudentNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Student Not Found !";
        }
    }
}
