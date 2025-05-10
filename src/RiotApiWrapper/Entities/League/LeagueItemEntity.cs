namespace RiotApiWrapper.Entities.League
{
    public class LeagueItemEntity
    {
        public LeagueItemEntity(
            string summonerId,
            string puuid,
            int leaguePoints,
            string rank,
            int wins,
            int losses,
            bool veteran,
            bool inactive,
            bool freshBlood,
            bool hotStreak)
        {
            SummonerId = summonerId;
            Puuid = puuid;
            LeaguePoints = leaguePoints;
            Rank = rank;
            Wins = wins;
            Losses = losses;
            Veteran = veteran;
            Inactive = inactive;
            FreshBlood = freshBlood;
            HotStreak = hotStreak;
        }

        public string SummonerId { get; private set; }
        public string Puuid { get; private set; }
        public int LeaguePoints { get; private set; }
        public string Rank { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public bool Veteran { get; private set; }
        public bool Inactive { get; private set; }
        public bool FreshBlood { get; private set; }
        public bool HotStreak { get; private set; }
    }
}
