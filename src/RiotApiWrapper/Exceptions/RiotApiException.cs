using System.Net;

namespace RiotApiWrapper.Exceptions
{
    public class RiotApiException : Exception
    {
        internal RiotApiException(string errorCause) : base(errorCause)
        {
        }

        internal RiotApiException(string errorCause, Exception innerException) : base(errorCause, innerException)
        {
        }

        public HttpStatusCode? HttpStatusCode => (InnerException as HttpRequestException)?.StatusCode;
    }
}
