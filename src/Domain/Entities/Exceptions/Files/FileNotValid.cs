namespace Domain.Entities.Exceptions.Files
{
    public class FileNotValid : GlobalException
    {
        public FileNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "File Format Not Valid !";
        }
    }
}
