namespace RiotApiWrapper.Exceptions
{
    public class RiotApiException : InternalException
    {
        public RiotApiException(InternalException internalException) : base(internalException.Message, internalException)
        {
            ErrorCode = GetErrorCode(internalException);
        }

        public string ErrorCode { get; private set; }

        private string GetErrorCode(InternalException internalException)
        {
            switch (internalException.Message)
            {
                case "Response is null.":
                    return "RequestError";
            }

            return "";
        }
    }
}
