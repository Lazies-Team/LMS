namespace Domain.Entities.Exceptions.Users
{
    public class UserNotFound : GlobalException
    {
        public UserNotFound() 
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "User Not Found !";
        }
    }
}
