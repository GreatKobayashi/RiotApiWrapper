using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test.EndPointsTests
{
    [TestClass]
    public class AccountEndPointTests
    {
        private static readonly RiotApi _api = new RiotApi(TestUtility.ApiKey);

        [TestMethod]
        public async Task TestGetAccountByGameIdAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualAccount = await api.Account.GetByGameIdAsync(Region.Asia, "GreatKobayashi", "JP1");

            Assert.AreEqual(TestUtility.PuuId, actualAccount.PuuId);
        }
    }
}
