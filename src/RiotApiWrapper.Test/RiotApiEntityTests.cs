using RiotApiWrapper.Entities;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test
{
    [TestClass]
    public class RiotApiEntityTests
    {
        [TestMethod]
        public async Task TestGetAccountByGameIdAsync()
        {
            var api = new RiotApiEntity(TestUtility.ApiKey);
            var actualAccount = await api.GetAccountByGameIdAsync(Region.Asia, "GreatKobayashi", "JP1");

            Assert.AreEqual(TestUtility.PuuId, actualAccount.PuuId);
        }

        [TestMethod]
        public async Task TestGetMatchListAsync()
        {
            var api = new RiotApiEntity(TestUtility.ApiKey);
            var actualMatchList = await api.GetMatchListAsync(Region.Asia, TestUtility.PuuId);

            Assert.AreEqual(20, actualMatchList.Count);
        }

        [TestMethod]
        public async Task TestGetMatchListAsyncOptions()
        {
            var api = new RiotApiEntity(TestUtility.ApiKey);
            var jpTimeOffset = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time").BaseUtcOffset;
            var startTime = new DateTimeOffset(2024, 4, 23, 13, 30, 30, jpTimeOffset);
            var endTime = new DateTimeOffset(2024, 4, 25, 23, 30, 30, jpTimeOffset);
            var actualMatchList1 = await api.GetMatchListAsync(Region.Asia, TestUtility.PuuId, startTime, endTime, QueueType.RankedSolo, 0, 10);
            Assert.AreEqual(7, actualMatchList1.Count);

            var actualMatchList2 = await api.GetMatchListAsync(Region.Asia, TestUtility.PuuId, null, endTime, QueueType.RankedSolo, 0, 10);
            Assert.AreEqual(10, actualMatchList2.Count);
        }
    }
}
