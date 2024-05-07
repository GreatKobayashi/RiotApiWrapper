using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test
{
    [TestClass]
    public class MatchEndPointTests
    {
        private static readonly RiotApi _api = new RiotApi(TestUtility.ApiKey);

        [TestMethod]
        public async Task TestGetListAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualMatchList = await api.Match.GetListAsync(Region.Asia, TestUtility.PuuId);

            Assert.AreEqual(20, actualMatchList.Count);
        }

        [TestMethod]
        public async Task TestGetListAsyncOptions()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var jpTimeOffset = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time").BaseUtcOffset;
            var startTime = new DateTimeOffset(2024, 4, 23, 13, 30, 30, jpTimeOffset);
            var endTime = new DateTimeOffset(2024, 4, 25, 23, 30, 30, jpTimeOffset);
            var actualMatchList1 = await api.Match.GetListAsync(Region.Asia, TestUtility.PuuId, startTime, endTime, QueueType.RankedSolo, 0, 10);
            Assert.AreEqual(7, actualMatchList1.Count);

            var actualMatchList2 = await api.Match.GetListAsync(Region.Asia, TestUtility.PuuId, null, endTime, QueueType.RankedSolo, 0, 10);
            Assert.AreEqual(10, actualMatchList2.Count);
        }

        [TestMethod]
        public async Task TestGetInfoAsync()
        {
            var match = await _api.Match.GetInfoAsync(Region.Asia, TestUtility.MatchId);
        }
    }
}
