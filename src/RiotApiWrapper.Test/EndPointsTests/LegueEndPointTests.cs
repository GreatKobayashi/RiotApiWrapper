using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Test.EndPointsTests
{
    [TestClass]
    public class LegueEndPointTests
    {
        [TestMethod]
        public async Task TestGetEntriesByPuuIdAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualLeagues = await api.League.GetEntriesByPuuIdAsync(Platform.JP1, TestUtility.PuuId);

            Assert.IsTrue(actualLeagues.Count > 0);
        }

        [TestMethod]
        public async Task TestGetEntriesByRankAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualEntries = await api.League.GetEntriesByRankAsync(Platform.JP1, Queue.RankedSolo, Tier.Platinum, Division.I);

            Assert.IsTrue(actualEntries.Count > 0);
        }

        [TestMethod]
        public async Task TestGetByLeagueIdAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualLeague = await api.League.GetByLeagueIdAsync(Platform.JP1, TestUtility.LeagueId);

            Assert.IsNotNull(actualLeague);
        }

        [TestMethod]
        public async Task TestGetEliteLeagueAsync()
        {
            var api = new RiotApi(TestUtility.ApiKey);
            var actualLeague = await api.League.GetEliteLeagueAsync(Platform.JP1, Queue.RankedSolo, EliteLeague.Master);

            Assert.IsNotNull(actualLeague);
        }
    }
}
