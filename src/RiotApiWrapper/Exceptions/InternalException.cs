namespace RiotApiWrapper.Exceptions
{
    public class InternalException : Exception
    {
        public InternalException(string errorCause) : base(errorCause)
        {
        }

        public InternalException(string errorCause, Exception innerException) : base(errorCause, innerException)
        {
        }

        protected InternalException() { }
    }
}
