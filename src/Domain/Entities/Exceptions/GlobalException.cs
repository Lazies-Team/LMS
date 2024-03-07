using System.Net;

namespace Domain.Entities.Exceptions
{
    public class GlobalException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public string TitleMessage { get; set; } = string.Empty;
    }
}
