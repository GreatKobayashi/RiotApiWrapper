namespace RiotApiWrapper.Entities.Match
{
    public class ObjectKillEntity
    {
        public ObjectKillEntity(int riftHeraldKillAssists, int baronKills, int baronKillAssists, int dragonKills, int dragonKillAssists, int inhibitorKills, int inhibitorKillAssists, int turretKills, int turretKillAssists, int nexusKills, int nexusKillAssists, int objectivesSteals, int objectivesStealAssists, bool firstTowerKill, bool firstTowerAssist)
        {
            RiftHeraldKillAssists = riftHeraldKillAssists;
            BaronKills = baronKills;
            BaronKillAssists = baronKillAssists;
            DragonKills = dragonKills;
            DragonKillAssists = dragonKillAssists;
            InhibitorKills = inhibitorKills;
            InhibitorKillAssists = inhibitorKillAssists;
            TurretKills = turretKills;
            TurretKillAssists = turretKillAssists;
            NexusKills = nexusKills;
            NexusKillAssists = nexusKillAssists;
            ObjectivesSteals = objectivesSteals;
            ObjectivesStealAssists = objectivesStealAssists;
            FirstTowerKill = firstTowerKill;
            FirstTowerAssist = firstTowerAssist;
        }

        public int RiftHeraldKillAssists { get; private set; }
        public int BaronKills { get; private set; }
        public int BaronKillAssists { get; private set; }
        public int DragonKills { get; private set; }
        public int DragonKillAssists { get; private set; }
        public int InhibitorKills { get; private set; }
        public int InhibitorKillAssists { get; private set; }
        public int TurretKills { get; private set; }
        public int TurretKillAssists { get; private set; }
        public int NexusKills { get; private set; }
        public int NexusKillAssists { get; private set; }
        public int ObjectivesSteals { get; private set; }
        public int ObjectivesStealAssists { get; private set; }
        public bool FirstTowerKill { get; private set; }
        public bool FirstTowerAssist { get; private set; }
    }
}
