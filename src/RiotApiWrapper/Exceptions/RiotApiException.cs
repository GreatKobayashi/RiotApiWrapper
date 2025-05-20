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

        public HttpStatusCode? HttpStatusCode
        {
            get
            {
                if (InnerException is HttpRequestException httpException)
                {
                    return httpException.StatusCode;
                }
                else if (InnerException is RiotApiException riotException)
                {
                    return riotException.HttpStatusCode;
                }
                return null;
            }
        }
    }
}
