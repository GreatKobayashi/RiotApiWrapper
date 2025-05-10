using RiotApiWrapper.Entities;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.EndPoints
{
    public class LeagueEndPoint : EndPointBase
    {
        private static Dictionary<Queue, string> _queueUrlPairs = new()
        {
            { Queue.RankedSolo, "RANKED_SOLO_5x5" },
            { Queue.RankedFlex, "RANKED_FLEX_SR" },
        };

        internal LeagueEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<List<LeagueEntryEntity>> GetEntriesByPuuIdAsync(Platform platform, string puuId)
        {
            return await ApiClient.GetAsync<List<LeagueEntryEntity>>(
                $"https://{platform}.api.riotgames.com/lol/league/v4/entries/by-puuid/{puuId}");
        }

        public async Task<List<LeagueEntryEntity>> GetEntriesByRankAsync(Platform platform, Queue queue, Tier tier, Division division, int page = 1)
        {
            var queries = new Dictionary<string, string>() { { "page", page.ToString() } };

            return await ApiClient.GetAsync<List<LeagueEntryEntity>>(
                $"https://{platform}.api.riotgames.com/lol/league/v4/entries/{_queueUrlPairs[queue]}/{tier.ToString().ToUpper()}/{division}", queries);
        }

        public async Task<LeagueEntity> GetByLeagueIdAsync(Platform platform, string leagueId)
        {
            return await ApiClient.GetAsync<LeagueEntity>(
                $"https://{platform}.api.riotgames.com/lol/league/v4/leagues/{leagueId}");
        }

        public async Task<LeagueEntity> GetEliteLeagueAsync(Platform platform, Queue queue, EliteLeague league)
        {
            return await ApiClient.GetAsync<LeagueEntity>(
                $"https://{platform}.api.riotgames.com/lol/league/v4/{league.ToString().ToLower()}leagues/by-queue/{_queueUrlPairs[queue]}");
        }
    }
}
