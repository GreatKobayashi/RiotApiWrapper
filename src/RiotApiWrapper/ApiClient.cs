using RiotApiWrapper.Exceptions;
using System.Net.Http.Json;

namespace RiotApiWrapper
{
    public class ApiClient
    {
        private HttpClient _client = new();

        public async Task<T> GetAsync<T>(string url, Dictionary<string, string>? queries = null)
        {
            var requestUrl = url;
            if (queries != null)
            {
                requestUrl += "?";
                foreach (var query in queries)
                {
                    requestUrl += $"{query.Key}={query.Value}&";
                }
            }
            var response = await _client.GetFromJsonAsync<T>(requestUrl);

            if (response != null)
            {
                return response;
            }
            else
            {
                throw new InternalException("Response is null.");
            }
        }
    }
}
