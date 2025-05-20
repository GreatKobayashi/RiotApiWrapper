using RiotApiWrapper.Entities;
using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;
using System.Diagnostics;
using System.Net;

namespace RiotApiWrapper.EndPoints
{
    public class SummonerEndPoint : EndPointBase
    {
        internal SummonerEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<SummonerEntity> GetByPuuIdAsync(Platform platform, string puuId)
        {
            try
            {
                return await ApiClient.GetAsync<SummonerEntity>(
                    $"https://{platform}.api.riotgames.com/lol/summoner/v4/summoners/by-puuid/{puuId}");
            }
            catch (ApiClientException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    throw new RiotApiException("Summoner Not Found.", ex);
                }
                throw;
            }
        }
    }
}
