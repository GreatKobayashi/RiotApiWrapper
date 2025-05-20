using RiotApiWrapper.Entities;
using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;
using System.Net;

namespace RiotApiWrapper.EndPoints
{
    public class AccountEndPoint : EndPointBase
    {
        internal AccountEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<AccountEntity> GetByGameIdAsync(Region region, string riotId, string tagLine)
        {
            try
            {
                return await ApiClient.GetAsync<AccountEntity>(
                    $"https://{region}.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{riotId}/{tagLine}");
            }
            catch (ApiClientException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    throw new RiotApiException("Account Not Found.", ex);
                }
                throw;
            }
        }
    }
}
