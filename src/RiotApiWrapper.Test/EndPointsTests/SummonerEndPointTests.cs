using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test.EndPointsTests
{
    [TestClass]
    public class SummonerEndPointTests
    {
        [TestMethod]
        public async Task TestGetAccountByGameIdAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualSummoner = await api.Summoner.GetByPuuIdAsync(Platform.JP1, TestUtility.PuuId);

            Assert.AreEqual(TestUtility.SummonerId, actualSummoner.Id);
        }
    }
}
