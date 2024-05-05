namespace RiotApiWrapper.Entities
{
    public class ObjectKillEntity
    {
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
        public int WardKills { get; private set; }
        public bool FirstTowerKill { get; private set; }
        public bool FirstTowerAssist { get; private set; }
        public int ObjectivesSteals { get; private set; }
        public int ObjectivesStealAssists { get; private set; }
    }
}
