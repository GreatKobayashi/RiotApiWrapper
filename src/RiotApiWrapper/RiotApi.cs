using RiotApiWrapper.EndPoints;

namespace RiotApiWrapper
{
    public class RiotApi
    {
        public RiotApi(string apiKey)
        {
            var apiClient = new ApiClient(apiKey);
            Match = new MatchEndPoint(apiClient);
            Account = new AccountEndPoint(apiClient);
            Summoner = new SummonerEndPoint(apiClient);
            League = new LeagueEndPoint(apiClient);
        }

        public MatchEndPoint Match { get; private set; }
        public AccountEndPoint Account { get; private set; }
        public SummonerEndPoint Summoner { get; private set; }
        public LeagueEndPoint League { get; private set; }
    }
}
