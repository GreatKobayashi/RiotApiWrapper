using RiotApiWrapper.Entities;
using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;
using System.Diagnostics;
using System.Net;

namespace RiotApiWrapper.EndPoints
{
    public class MatchEndPoint : EndPointBase
    {
        internal MatchEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<List<string>> GetIdsAsync(
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

            return await GetIdsAsync(
                region, puuId, startTimeLong, endTimeLong, queue, start, count);
        }

        private async Task<List<string>> GetIdsAsync(
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
            return await ApiClient.GetAsync<List<string>>(
                $"https://{region}.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuId}/ids", queries);
        }

        public async Task<MatchEntity> GetInfoAsync(Region region, string matchId)
        {
            try
            {
                return await ApiClient.GetAsync<MatchEntity>($"https://{region}.api.riotgames.com/lol/match/v5/matches/{matchId}");
            }
            catch (ApiClientException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    throw new RiotApiException("Match Not Found.", ex);
                }
                throw;
            }
        }

        public async Task<TimelineEntity> GetTimeLineAsync(Region region, string matchId)
        {
            try
            {
                return await ApiClient.GetAsync<TimelineEntity>($"https://{region}.api.riotgames.com/lol/match/v5/matches/{matchId}/timeline");
            }
            catch (ApiClientException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    throw new RiotApiException("Match Not Found.", ex);
                }
                throw;
            }
        }
    }
}
