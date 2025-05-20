using RiotApiWrapper.Exceptions;
using System.Net;
using System.Net.Http.Json;

namespace RiotApiWrapper
{
    internal class ApiClient
    {
        private HttpClient _client = new();
        private readonly string _apiKey;
        private readonly Dictionary<string, string> _defaultQueries;

        internal ApiClient(string apiKey)
        {
            _apiKey = apiKey;
            _defaultQueries = new()
            {
                { "api_key", _apiKey }
            };
        }

        internal async Task<T> GetAsync<T>(string url, Dictionary<string, string>? queries = null)
        {
            var requestUrl = url;
            var formedQueries = (queries ?? []).Concat(_defaultQueries).ToDictionary(c => c.Key, c => c.Value);

            requestUrl += "?";
            foreach (var query in formedQueries)
            {
                requestUrl += $"{query.Key}={query.Value}&";
            }

            try
            {
                var response = await _client.GetFromJsonAsync<T>(requestUrl);

                if (response != null)
                {
                    return response;
                }
                else
                {
                    throw new RiotApiException("Response is null.");
                }
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        if (ex.Message == "Unknown apikey")
                        {
                            throw new ApiClientException("Unknown Api key. It will be activated a few minutes after the Api key regeneration");
                        }
                        break;
                    case HttpStatusCode.Forbidden:
                        throw new ApiClientException("Invalid Api key.");
                    case HttpStatusCode.TooManyRequests:
                        throw new ApiClientException("Over the request limit.");
                }
                throw new ApiClientException(ex.Message, ex);
            }
        }
    }
}
