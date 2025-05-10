namespace RiotApiWrapper.Entities
{
    public class LeagueEntryEntity
    {
        public LeagueEntryEntity(
            string leagueId,
            string queueType,
            string tier,
            string rank,
            string summonerId,
            string puuid,
            int leaguePoints,
            int wins,
            int losses,
            bool veteran,
            bool inactive,
            bool freshBlood,
            bool hotStreak)
        {
            LeagueId = leagueId;
            QueueType = queueType;
            Tier = tier;
            Rank = rank;
            SummonerId = summonerId;
            Puuid = puuid;
            LeaguePoints = leaguePoints;
            Wins = wins;
            Losses = losses;
            Veteran = veteran;
            Inactive = inactive;
            FreshBlood = freshBlood;
            HotStreak = hotStreak;
        }

        public string LeagueId { get; private set; }
        public string QueueType { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string SummonerId { get; private set; }
        public string Puuid { get; private set; }
        public int LeaguePoints { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public bool Veteran { get; private set; }
        public bool Inactive { get; private set; }
        public bool FreshBlood { get; private set; }
        public bool HotStreak { get; private set; }
    }
}
