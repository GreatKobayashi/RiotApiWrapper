using RiotApiWrapper.Entities;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.EndPoints
{
    public class AccountEndPoint
    {
        private readonly ApiClient _apiClient;

        public AccountEndPoint(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<AccountEntity> GetByGameIdAsync(Region region, string riotId, string tagLine)
        {
            return await _apiClient.GetAsync<AccountEntity>(
                $"https://{region}.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{riotId}/{tagLine}");
        }
    }
}
