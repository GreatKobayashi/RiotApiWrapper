namespace RiotApiWrapper.Entities
{
    public class SummonerEntity
    {
        public SummonerEntity(string id, string accountId, string puuid, int profileIconId, long revisionDate, int summonerLevel)
        {
            Id = id;
            AccountId = accountId;
            Puuid = puuid;
            ProfileIconId = profileIconId;
            RevisionDate = revisionDate;
            SummonerLevel = summonerLevel;
        }

        public string Id { get; private set; }
        public string AccountId { get; private set; }
        public string Puuid { get; private set; }
        public int ProfileIconId { get; private set; }
        public long RevisionDate { get; private set; }
        public int SummonerLevel { get; private set; }
    }
}