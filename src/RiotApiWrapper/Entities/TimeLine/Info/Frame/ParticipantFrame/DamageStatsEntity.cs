namespace RiotApiWrapper.Entities.TimeLine.Info.Frame.ParticipantFrame
{
    public class DamageStatsEntity
    {
        public DamageStatsEntity(
            int magicDamageDone,
            int magicDamageDoneToChampions,
            int magicDamageTaken,
            int physicalDamageDone,
            int physicalDamageDoneToChampions,
            int physicalDamageTaken,
            int totalDamageDone,
            int totalDamageDoneToChampions,
            int totalDamageTaken,
            int trueDamageDone,
            int trueDamageDoneToChampions,
            int trueDamageTaken)
        {
            MagicDamageDone = magicDamageDone;
            MagicDamageDoneToChampions = magicDamageDoneToChampions;
            MagicDamageTaken = magicDamageTaken;
            PhysicalDamageDone = physicalDamageDone;
            PhysicalDamageDoneToChampions = physicalDamageDoneToChampions;
            PhysicalDamageTaken = physicalDamageTaken;
            TotalDamageDone = totalDamageDone;
            TotalDamageDoneToChampions = totalDamageDoneToChampions;
            TotalDamageTaken = totalDamageTaken;
            TrueDamageDone = trueDamageDone;
            TrueDamageDoneToChampions = trueDamageDoneToChampions;
            TrueDamageTaken = trueDamageTaken;
        }

        public int MagicDamageDone { get; private set; }
        public int MagicDamageDoneToChampions { get; private set; }
        public int MagicDamageTaken { get; private set; }
        public int PhysicalDamageDone { get; private set; }
        public int PhysicalDamageDoneToChampions { get; private set; }
        public int PhysicalDamageTaken { get; private set; }
        public int TotalDamageDone { get; private set; }
        public int TotalDamageDoneToChampions { get; private set; }
        public int TotalDamageTaken { get; private set; }
        public int TrueDamageDone { get; private set; }
        public int TrueDamageDoneToChampions { get; private set; }
        public int TrueDamageTaken { get; private set; }
    }
}
