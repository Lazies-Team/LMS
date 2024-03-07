namespace Domain.Entities.Exceptions.Homeworks
{
    public class HomeworkNotFound : GlobalException
    {
        public HomeworkNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "HomeWork Not Found !";
        }
    }
}
