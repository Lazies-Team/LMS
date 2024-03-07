namespace Domain.Entities.Exceptions.Files
{
    public class FileNotFound : GlobalException
    {
        public FileNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "File Not Found !";
        }
    }
}
