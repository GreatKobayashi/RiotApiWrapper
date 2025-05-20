using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test.EndPointsTests
{
    [TestClass]
    public class AccountEndPointTests
    {
        [TestMethod]
        public async Task TestGetAccountByGameIdAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualAccount = await api.Account.GetByGameIdAsync(Region.Asia, "GreatKobayashi", "JP1");

            Assert.AreEqual(TestUtility.PuuId, actualAccount.PuuId);
        }

        [TestMethod]
        public async Task TestGetAccountByGameIdAsyncNotFound()
        {
            try
            {
                var api = new RiotApi(TestUtility.ApiKey);
                var actualAccount = await api.Account.GetByGameIdAsync(Region.Asia, "GreatKobayashi", "rrr");

                Assert.Fail();
            }
            catch (RiotApiException ex)
            {
                Assert.AreEqual("Account Not Found.", ex.Message);
            }
        }
    }
}
