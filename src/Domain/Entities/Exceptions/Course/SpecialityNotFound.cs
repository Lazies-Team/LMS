namespace Domain.Entities.Exceptions.Course
{
    public class SpecialityNotFound : GlobalException
    {
        public SpecialityNotFound() 
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Specialty Not Found !";
        }
    }
}
