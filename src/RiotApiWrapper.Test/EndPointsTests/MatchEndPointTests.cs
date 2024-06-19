using RiotApiWrapper.Entities.Match.MatchTimeLine.Events;
using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test.EndPointsTests
{
    [TestClass]
    public class MatchEndPointTests
    {
        private static readonly RiotApi _api = new RiotApi(TestUtility.ApiKey);

        [TestMethod]
        public async Task TestGetListAsync()
        {
            var actualMatchList = await _api.Match.GetIdListAsync(Region.Asia, TestUtility.PuuId);

            Assert.AreEqual(20, actualMatchList.Count);
        }

        [TestMethod]
        public async Task TestGetIdListAsyncOptions()
        {
            var jpTimeOffset = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time").BaseUtcOffset;
            var startTime = new DateTimeOffset(2024, 4, 23, 13, 30, 30, jpTimeOffset);
            var endTime = new DateTimeOffset(2024, 4, 25, 23, 30, 30, jpTimeOffset);
            var actualMatchList1 = await _api.Match.GetIdListAsync(Region.Asia, TestUtility.PuuId, startTime, endTime, QueueType.RankedSolo, 0, 10);
            Assert.AreEqual(7, actualMatchList1.Count);

            var actualMatchList2 = await _api.Match.GetIdListAsync(Region.Asia, TestUtility.PuuId, null, endTime, QueueType.RankedSolo, 0, 10);
            Assert.AreEqual(10, actualMatchList2.Count);
        }

        [TestMethod]
        public async Task TestGetInfoAsync()
        {
            var match = await _api.Match.GetInfoAsync(Region.Asia, TestUtility.MatchId);
        }

        [TestMethod]
        public async Task TestGetInfoManyTimesAsync()
        {
            var offset = 0;
            for (var i = 0; i < 100; i++)
            {
                var matchList = await _api.Match.GetIdListAsync(Region.Asia, TestUtility.PuuId, null, null, null, offset);
                foreach (var matchId in matchList)
                {
                    var match = await _api.Match.GetInfoAsync(Region.Asia, matchId);
                }
                offset += 20;
            }
        }

        [TestMethod]
        public async Task TestGetTimeLineAsync()
        {
            var timeLine = await _api.Match.GetTimeLineAsync(Region.Asia, TestUtility.MatchId);
            var evolve = timeLine.LevelUpEvents.Where(x => x is SkillEvolveEventEntity).ToList();
        }
    }
}
