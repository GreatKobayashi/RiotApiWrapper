namespace RiotApiWrapper.Entities.Match
{
    public class TotalStatEntity
    {
        public TotalStatEntity(ChampionKillEntity championKill, ObjectKillEntity objectKill, TotalDamageEntity damage, int deaths, int assists, int bountyLevel, int itemsPurchased, int longestTimeSpentLiving, int totalTimeSpentDead)
        {
            ChampionKill = championKill;
            ObjectKill = objectKill;
            Damage = damage;
            Deaths = deaths;
            Assists = assists;
            BountyLevel = bountyLevel;
            ItemsPurchased = itemsPurchased;
            LongestTimeSpentLiving = longestTimeSpentLiving;
            TotalTimeSpentDead = totalTimeSpentDead;
        }

        public ChampionKillEntity ChampionKill { get; private set; }
        public ObjectKillEntity ObjectKill { get; private set; }
        public TotalDamageEntity Damage { get; private set; }
        public int Deaths { get; private set; }
        public int Assists { get; private set; }
        public int BountyLevel { get; private set; }
        public int ItemsPurchased { get; private set; }
        public int LongestTimeSpentLiving { get; private set; }
        public int TotalTimeSpentDead { get; private set; }
    }
}
