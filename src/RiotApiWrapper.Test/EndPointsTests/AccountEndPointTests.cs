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
            var actualAccount = await api.Account.GetByGameIdAsync(Region.Asia, "裸だったら何が悪い", "5444");

            Assert.AreEqual(TestUtility.PuuId, actualAccount.PuuId);
        }
    }
}
