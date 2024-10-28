namespace RiotApiWrapper.Entities.Match.MatchTimeLine
{
    public class StatPerMinuteEntity
    {
        public StatPerMinuteEntity(TimeSpan timeStamp, List<CurrentChampionStatEntity> currentChampionStats)
        {
            TimeStamp = timeStamp;
            ChampionStats = currentChampionStats;
        }

        public TimeSpan TimeStamp { get; private set; }
        public List<CurrentChampionStatEntity> ChampionStats { get; private set; }
    }
}
