namespace RiotApiWrapper.Entities
{
    public class ChampionKillEntity
    {
        public int Kills { get; private set; }
        public int DoubleKills { get; private set; }
        public int TripleKills { get; private set; }
        public int QuadraKills { get; private set; }
        public int PentaKills { get; private set; }
        public bool FirstBloodKill { get; private set; }
        public bool FirstBloodAssist { get; private set; }
        public int KillingSprees { get; private set; }
        public int LargestKillingSpree { get; private set; }
        public int LargestMultiKill { get; private set; }
        public int SoloKills { get; private set; }
    }
}
