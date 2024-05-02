using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities
{
    public class RiotApiEntity
    {
        private readonly string _apiKey;
        private readonly ApiClient _apiClient = new();
        private readonly Dictionary<string, string> _defaultQueries;

        public RiotApiEntity(string apiKey)
        {
            _apiKey = apiKey;
            _defaultQueries = new()
            {
                { "api_key", _apiKey }
            };
        }

        public async Task<AccountEntity> GetAccountByGameIdAsync(Region region, string riotId, string tagLine)
        {
            return await _apiClient.GetAsync<AccountEntity>(
                $"https://{region}.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{riotId}/{tagLine}", _defaultQueries);
        }

        public async Task<List<string>> GetMatchListAsync(
            Region region,
            string puuId,
            DateTimeOffset? startTime = null,
            DateTimeOffset? endTime = null,
            QueueType? queue = null,
            int start = 0,
            int count = 20)
        {
            long? startTimeLong = null;
            long? endTimeLong = null;
            if (startTime != null)
            {
                startTimeLong = ((DateTimeOffset)startTime).ToUnixTimeSeconds();
            }
            if (endTime != null)
            {
                endTimeLong = ((DateTimeOffset)endTime).ToUnixTimeSeconds();
            }

            return await GetMatchListAsync(
                region, puuId, startTimeLong, endTimeLong, queue, start, count);
        }

        private async Task<List<string>> GetMatchListAsync(
            Region region,
            string puuId,
            long? startTime,
            long? endTime,
            QueueType? queue,
            int start = 0,
            int count = 20)
        {
            var queries = new Dictionary<string, string>(_defaultQueries);
            if (startTime != null)
            {
                queries.Add("startTime", startTime.ToString()!);
            }
            if (endTime != null)
            {
                queries.Add("endTime", endTime.ToString()!);
            }
            if (queue != null)
            {
                queries.Add("queue", ((int)queue).ToString());
            }
            queries.Add("start", start.ToString());
            queries.Add("count", count.ToString());
            return await _apiClient.GetAsync<List<string>>(
                $"https://{region}.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuId}/ids", queries);
        }
    }
}
