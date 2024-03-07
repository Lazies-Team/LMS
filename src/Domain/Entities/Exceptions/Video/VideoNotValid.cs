namespace Domain.Entities.Exceptions.Video
{
    public class VideoNotValid : GlobalException
    {
        public VideoNotValid()
        {
            StatusCode = System.Net.HttpStatusCode.BadRequest;
            TitleMessage = "Video Format Not Valid !";
        }
    }
}
