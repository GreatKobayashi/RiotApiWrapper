using RiotApiWrapper.Entities;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.EndPoints
{
    public class AccountEndPoint : EndPoint
    {
        public AccountEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<AccountEntity> GetByGameIdAsync(Region region, string riotId, string tagLine)
        {
            return await ApiClient.GetAsync<AccountEntity>(
                $"https://{region}.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{riotId}/{tagLine}");
        }
    }
}
