using RiotApiWrapper.Entities;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.EndPoints
{
    public class SummonerEndPoint : EndPointBase
    {
        internal SummonerEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<SummonerEntity> GetByPuuIdAsync(Platform platform, string puuId)
        {
            return await ApiClient.GetAsync<SummonerEntity>(
                $"https://{platform}.api.riotgames.com/lol/summoner/v4/summoners/by-puuid/{puuId}");
        }
    }
}
