namespace RiotApiWrapper.Entities
{
    public class StatEntity
    {
        public ChampionKillEntity ChampionKill { get; private set; }
        public ObjectKillEntity ObjectKill { get; private set; }
        public DamageEntity Damage { get; private set; }
        public int Deaths { get; private set; }
        public int Assists { get; private set; }
        public int BountyLevel { get; private set; }
        public int ItemsPurchased { get; private set; }
        public int LongestTimeSpentLiving { get; private set; }
        public int TotalTimeSpentDead { get; private set; }
    }
}
