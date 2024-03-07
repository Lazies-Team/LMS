namespace Domain.Entities.Exceptions.Tasks
{
    public class TaskResultNotFound : GlobalException
    {
        public TaskResultNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Task Result Not Found !";
        }
    }
}
