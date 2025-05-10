using RiotApiWrapper.Entities.Common;
using RiotApiWrapper.Entities.TimeLine.Info.Frame.ParticipantFrame;

namespace RiotApiWrapper.Entities.TimeLine.Info.Frame
{
    public class ParticipantFrameEntity
    {
        public ParticipantFrameEntity(
            ChampionStatsEntity championStats,
            int currentGold,
            DamageStatsEntity damageStats,
            int goldPerSecond,
            int jungleMinionsKilled,
            int level,
            int minionsKilled,
            int participantId,
            PositionEntity position,
            int timeEnemySpentControlled,
            int totalGold,
            int xp)
        {
            ChampionStats = championStats;
            CurrentGold = currentGold;
            DamageStats = damageStats;
            GoldPerSecond = goldPerSecond;
            JungleMinionsKilled = jungleMinionsKilled;
            Level = level;
            MinionsKilled = minionsKilled;
            ParticipantId = participantId;
            Position = position;
            TimeEnemySpentControlled = timeEnemySpentControlled;
            TotalGold = totalGold;
            Xp = xp;
        }

        public ChampionStatsEntity ChampionStats { get; private set; }
        public int CurrentGold { get; private set; }
        public DamageStatsEntity DamageStats { get; private set; }
        public int GoldPerSecond { get; private set; }
        public int JungleMinionsKilled { get; private set; }
        public int Level { get; private set; }
        public int MinionsKilled { get; private set; }
        public int ParticipantId { get; private set; }
        public PositionEntity Position { get; private set; }
        public int TimeEnemySpentControlled { get; private set; }
        public int TotalGold { get; private set; }
        public int Xp { get; private set; }
    }
}
