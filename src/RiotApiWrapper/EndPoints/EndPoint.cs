using System.Text.Json;

namespace RiotApiWrapper.EndPoints
{
    public abstract class EndPoint
    {
        public EndPoint(ApiClient apiClient)
        {
            ApiClient = apiClient;
        }

        protected readonly ApiClient ApiClient;
        protected static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }
}
