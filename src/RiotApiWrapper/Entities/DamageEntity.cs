namespace RiotApiWrapper.Entities
{
    public class DamageEntity
    {
        public DamageEntity(
            int totalDamageDealt,
            int damageDealtToBuildings,
            int damageDealtToObjectives,
            int damageDealtToTurrets,
            int totalDamageDealtToChampions,
            int selfMitigated, int magicDamageDealt, int magicDamageDealtToChampions, int magicDamageTaken, int physicalDamageDealt, int physicalDamageDealtToChampions, int physicalDamageTaken, int damageShieldedOnTeammates, int totalDamageTaken, int totalHeal, int totalUnitsHealed, int healsOnTeammates, int totalTimeCCDealt, int timeCCingOthers, int trueDamageDealt, int trueDamageDealtToChampions, int trueDamageTaken, int largestCriticalStrike)
        {
            TotalDamageDealt = totalDamageDealt;
            DamageDealtToBuildings = damageDealtToBuildings;
            DamageDealtToObjectives = damageDealtToObjectives;
            DamageDealtToTurrets = damageDealtToTurrets;
            TotalDamageDealtToChampions = totalDamageDealtToChampions;
            SelfMitigated = selfMitigated;
            MagicDamageDealt = magicDamageDealt;
            MagicDamageDealtToChampions = magicDamageDealtToChampions;
            MagicDamageTaken = magicDamageTaken;
            PhysicalDamageDealt = physicalDamageDealt;
            PhysicalDamageDealtToChampions = physicalDamageDealtToChampions;
            PhysicalDamageTaken = physicalDamageTaken;
            DamageShieldedOnTeammates = damageShieldedOnTeammates;
            TotalDamageTaken = totalDamageTaken;
            TotalHeal = totalHeal;
            TotalUnitsHealed = totalUnitsHealed;
            HealsOnTeammates = healsOnTeammates;
            TotalTimeCCDealt = totalTimeCCDealt;
            TimeCCingOthers = timeCCingOthers;
            TrueDamageDealt = trueDamageDealt;
            TrueDamageDealtToChampions = trueDamageDealtToChampions;
            TrueDamageTaken = trueDamageTaken;
            LargestCriticalStrike = largestCriticalStrike;
        }

        public int TotalDamageDealt { get; private set; }
        public int DamageDealtToBuildings { get; private set; }
        public int DamageDealtToObjectives { get; private set; }
        public int DamageDealtToTurrets { get; private set; }
        public int TotalDamageDealtToChampions { get; private set; }
        public int SelfMitigated { get; private set; }
        public int MagicDamageDealt { get; private set; }
        public int MagicDamageDealtToChampions { get; private set; }
        public int MagicDamageTaken { get; private set; }
        public int PhysicalDamageDealt { get; private set; }
        public int PhysicalDamageDealtToChampions { get; private set; }
        public int PhysicalDamageTaken { get; private set; }
        public int DamageShieldedOnTeammates { get; private set; }
        public int TotalDamageTaken { get; private set; }
        public int TotalHeal { get; private set; }
        public int TotalUnitsHealed { get; private set; }
        public int HealsOnTeammates { get; private set; }
        public int TotalTimeCCDealt { get; private set; }
        public int TimeCCingOthers { get; private set; }
        public int TrueDamageDealt { get; private set; }
        public int TrueDamageDealtToChampions { get; private set; }
        public int TrueDamageTaken { get; private set; }
        public int LargestCriticalStrike { get; private set; }
    }
}
