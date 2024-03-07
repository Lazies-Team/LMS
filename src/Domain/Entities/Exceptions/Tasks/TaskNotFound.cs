namespace Domain.Entities.Exceptions.Tasks
{
    public class TaskNotFound : GlobalException
    {
        public TaskNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Task Not Found !";
        }
    }
}
