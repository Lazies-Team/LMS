namespace Domain.Entities.Exceptions.Password
{
    public class PaswordNotValid : GlobalException
    {
        public PaswordNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Password Must be 8 Letters and Uppercase Letter !";
        }
    }
}
