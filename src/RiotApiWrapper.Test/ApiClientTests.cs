using RiotApiWrapper.Entities;

namespace RiotApiWrapper.Test
{
    [TestClass]
    public class ApiClientTests
    {
        [TestMethod]
        public async Task TestGetAsync()
        {
            var client = new ApiClient(TestUtility.ApiKey);
            var actualAccount = await client.GetAsync<AccountEntity>(
                "https://asia.api.riotgames.com/riot/account/v1/accounts/by-riot-id/GreatKobayashi/JP1");

            Assert.AreEqual(TestUtility.PuuId, actualAccount.PuuId);
        }
    }
}