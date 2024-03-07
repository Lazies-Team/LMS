namespace Domain.Entities.Exceptions.Images
{
    public class ImageNotValid : GlobalException
    {
        public ImageNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Image Format Not Valid !";
        }
    }
}
