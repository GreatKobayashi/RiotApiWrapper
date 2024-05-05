using RiotApiWrapper.Exceptions;
using System.Net.Http.Json;
using System.Text.Json;

namespace RiotApiWrapper
{
    public class ApiClient
    {
        private HttpClient _client = new();
        private readonly string _apiKey;
        private readonly Dictionary<string, string> _defaultQueries;

        public ApiClient(string apiKey)
        {
            _apiKey = apiKey;
            _defaultQueries = new()
            {
                { "api_key", _apiKey }
            };
        }

        public async Task<T> GetAsync<T>(string url, Dictionary<string, string>? queries = null)
        {
            var requestUrl = url;
            var formedQueries = (queries ?? []).Concat(_defaultQueries).ToDictionary(c => c.Key, c => c.Value);

            requestUrl += "?";
            foreach (var query in formedQueries)
            {
                requestUrl += $"{query.Key}={query.Value}&";
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

        public async Task GetTest(string url, Dictionary<string, string>? queries = null)
        {
            var requestUrl = url;
            var formedQueries = (queries ?? []).Concat(_defaultQueries).ToDictionary(c => c.Key, c => c.Value);

            requestUrl += "?";
            foreach (var query in formedQueries)
            {
                requestUrl += $"{query.Key}={query.Value}&";
            }
            var response = await _client.GetStringAsync(requestUrl);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            if (response != null)
            {
                var deserialised = JsonSerializer.Deserialize<Dictionary<string, object>>(response, options);
                var test = JsonSerializer.Deserialize<Dictionary<string, object>>(deserialised?["metadata"].ToString(), options);
            }
            else
            {
                throw new InternalException("Response is null.");
            }
        }
    }
}
