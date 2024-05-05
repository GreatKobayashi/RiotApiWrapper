using RiotApiWrapper.Entities;
using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;
using System.Text.Json;

namespace RiotApiWrapper
{
    public class RiotApi
    {
        private readonly ApiClient _apiClient;

        public RiotApi(string apiKey)
        {
            _apiClient = new ApiClient(apiKey);
        }

        public async Task<AccountEntity> GetAccountByGameIdAsync(Region region, string riotId, string tagLine)
        {
            return await _apiClient.GetAsync<AccountEntity>(
                $"https://{region}.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{riotId}/{tagLine}");
        }

        #region Match
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
            var queries = new Dictionary<string, string>();
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

        public async Task GetMatchInfoAsync()
        {
            var response = await _apiClient.GetAsync<Dictionary<string, JsonElement>>($"https://asia.api.riotgames.com/lol/match/v5/matches/JP1_443761075");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var originalMetadata = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["metadata"].GetString()!, options);
            var originalInfo = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["info"].GetString()!, options);

            if (originalMetadata == null || originalInfo == null)
            {
                throw new InternalException("Unexpected response.");
            }

            var metaData = new MetaEntity(
                originalMetadata["dataVersion"].GetString()!,
                originalInfo["gameVersion"].GetString()!,
                originalInfo["gameName"].GetString()!,
                originalInfo["endOfGameResult"].GetString()!,
                originalInfo["tournamentCode"].GetString()!,
                originalInfo["gameId"].GetInt32(),
                DateTimeOffset.FromUnixTimeMilliseconds(originalInfo["gameCreation"].GetInt64()).DateTime,
                DateTimeOffset.FromUnixTimeMilliseconds(originalInfo["gameStartTimestamp"].GetInt64()).DateTime,
                DateTimeOffset.FromUnixTimeMilliseconds(originalInfo["gameEndTimestamp"].GetInt64()).DateTime,
                new TimeSpan(0, 0, originalInfo["gameDuration"].GetInt32()),
                Enum.Parse<GameMode>(originalInfo["gameMode"].GetString()!, true),
                Enum.Parse<GameType>(originalInfo["gameType"].GetString()!.Replace("_", ""), true),
                (Map)originalInfo["mapId"].GetInt32(),
                Enum.Parse<Platform>(originalInfo["platformId"].GetString()!, true),
                (QueueType)originalInfo["queueId"].GetInt32());
        }
        #endregion
    }
}
