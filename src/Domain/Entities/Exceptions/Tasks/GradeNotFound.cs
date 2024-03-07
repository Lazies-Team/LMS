namespace Domain.Entities.Exceptions.Tasks
{
    public class GradeNotFound : GlobalException
    {
        public GradeNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Grade Not Found";
        }
    }
}
