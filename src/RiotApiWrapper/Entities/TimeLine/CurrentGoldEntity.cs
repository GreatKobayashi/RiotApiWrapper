namespace RiotApiWrapper.Entities.Match.MatchTimeLine
{
    public class CurrentGoldEntity
    {
        public CurrentGoldEntity(int having, int total, int perSecond, int jungleMonstersKilled, int minionsKilled)
        {
            Having = having;
            Total = total;
            PerSecond = perSecond;
            JungleMonstersKilled = jungleMonstersKilled;
            MinionsKilled = minionsKilled;
        }

        public int Having { get; private set; }
        public int Total { get; private set; }
        public int PerSecond { get; private set; }
        public int JungleMonstersKilled { get; private set; }
        public int MinionsKilled { get; private set; }
    }
}
