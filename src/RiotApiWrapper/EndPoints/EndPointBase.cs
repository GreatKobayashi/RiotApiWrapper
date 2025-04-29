using System.Text.Json;

namespace RiotApiWrapper.EndPoints
{
    public abstract class EndPointBase
    {
        internal EndPointBase(ApiClient apiClient)
        {
            ApiClient = apiClient;
        }

        private protected readonly ApiClient ApiClient;
        protected static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }
}
