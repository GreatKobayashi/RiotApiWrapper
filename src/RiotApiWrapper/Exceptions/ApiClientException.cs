namespace RiotApiWrapper.Exceptions
{
    public class ApiClientException : RiotApiException
    {
        internal ApiClientException(string errorCause) : base(errorCause)
        {
        }

        internal ApiClientException(string errorCause, Exception innerException) : base(errorCause, innerException)
        {
        }
    }
}
