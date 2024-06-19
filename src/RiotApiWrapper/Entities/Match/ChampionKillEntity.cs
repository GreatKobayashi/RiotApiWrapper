namespace RiotApiWrapper.Entities.Match
{
    public class ChampionKillEntity
    {
        public ChampionKillEntity(int kills, int doubleKills, int tripleKills, int quadraKills, int pentaKills, int killingSprees, int largestKillingSpree, int largestMultiKill, int soloKills, bool firstBloodKill, bool firstBloodAssist)
        {
            Kills = kills;
            DoubleKills = doubleKills;
            TripleKills = tripleKills;
            QuadraKills = quadraKills;
            PentaKills = pentaKills;
            KillingSprees = killingSprees;
            LargestKillingSpree = largestKillingSpree;
            LargestMultiKill = largestMultiKill;
            SoloKills = soloKills;
            FirstBloodKill = firstBloodKill;
            FirstBloodAssist = firstBloodAssist;
        }

        public int Kills { get; private set; }
        public int DoubleKills { get; private set; }
        public int TripleKills { get; private set; }
        public int QuadraKills { get; private set; }
        public int PentaKills { get; private set; }
        public int KillingSprees { get; private set; }
        public int LargestKillingSpree { get; private set; }
        public int LargestMultiKill { get; private set; }
        public int SoloKills { get; private set; }
        public bool FirstBloodKill { get; private set; }
        public bool FirstBloodAssist { get; private set; }
    }
}
