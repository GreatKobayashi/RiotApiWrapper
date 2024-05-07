namespace RiotApiWrapper.Entities
{
    public class SummonerEntity : AccountEntity
    {
        public SummonerEntity(string summonerId, string? accountId, string puuId, int profileIconId, int summonerLevel, string gameName, string tagLine) : base(puuId, gameName, tagLine)
        {
            SummonerId = summonerId;
            AccountId = accountId;
            ProfileIconId = profileIconId;
            SummonerLevel = summonerLevel;
        }

        public string SummonerId { get; private set; }
        public string? AccountId { get; private set; }
        public int ProfileIconId { get; private set; }
        public int SummonerLevel { get; private set; }
    }
}
