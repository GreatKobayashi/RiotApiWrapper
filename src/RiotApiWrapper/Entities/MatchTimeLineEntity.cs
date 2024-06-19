using RiotApiWrapper.Entities.Match.MatchTimeLine;
using RiotApiWrapper.Entities.Match.MatchTimeLine.Events;

namespace RiotApiWrapper.Entities
{
    public class MatchTimeLineEntity
    {
        public MatchTimeLineEntity(List<EventFrameEntity> allEvents, List<ItemEventEntity> itemEvents, List<LevelUpEventEntity> levelUpEvents, List<WardEventEntity> wardEvents, List<ChampionKillEventEntity> championKillEvents, List<BuildingKillEventEntity> buildingKillEvents, List<EpicMonsterKillEventEntity> epicMonsterKillEvents, List<StatPerMinuteEntity> statPerMinute)
        {
            AllEvents = allEvents;
            ItemEvents = itemEvents;
            LevelUpEvents = levelUpEvents;
            WardEvents = wardEvents;
            ChampionKillEvents = championKillEvents;
            BuildingKillEvents = buildingKillEvents;
            EpicMonsterKillEvents = epicMonsterKillEvents;
            StatPerMinute = statPerMinute;
        }

        public List<EventFrameEntity> AllEvents { get; private set; }
        public List<ItemEventEntity> ItemEvents { get; private set; }
        public List<LevelUpEventEntity> LevelUpEvents { get; private set; }
        public List<WardEventEntity> WardEvents { get; private set; }
        public List<ChampionKillEventEntity> ChampionKillEvents { get; private set; }
        public List<BuildingKillEventEntity> BuildingKillEvents { get; private set; }
        public List<EpicMonsterKillEventEntity> EpicMonsterKillEvents { get; private set; }
        public List<StatPerMinuteEntity> StatPerMinute { get; private set; }
    }
}
