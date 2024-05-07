using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities
{
    public class ParticipantEntity
    {
        public ParticipantEntity(
            int id,
            int placement,
            int championExp,
            int championLv,
            int earnedGold,
            int spentGold,
            Team team,
            Position position,
            SummonerSpel summonerSpel1,
            SummonerSpel summonerSpel2,
            bool win,
            bool afk,
            SummonerEntity summoner,
            PingCountEntity pingCount,
            ChampionEntity champion,
            StatEntity stat,
            List<int> itemIds)
        {
            Id = id;
            Placement = placement;
            ChampionExp = championExp;
            ChampionLv = championLv;
            EarnedGold = earnedGold;
            SpentGold = spentGold;
            Team = team;
            Position = position;
            SummonerSpel1 = summonerSpel1;
            SummonerSpel2 = summonerSpel2;
            Win = win;
            Afk = afk;
            Summoner = summoner;
            PingCount = pingCount;
            Champion = champion;
            Stat = stat;
            ItemIds = itemIds;
        }

        public int Id { get; private set; }
        public int Placement { get; private set; }
        public int ChampionExp { get; private set; }
        public int ChampionLv { get; private set; }
        public int EarnedGold { get; private set; }
        public int SpentGold { get; private set; }
        public Team Team { get; private set; }
        public Position Position { get; private set; }
        public SummonerSpel SummonerSpel1 { get; private set; }
        public SummonerSpel SummonerSpel2 { get; private set; }
        public bool Win { get; private set; }
        public bool Afk { get; private set; }
        public SummonerEntity Summoner { get; private set; }
        public PingCountEntity PingCount { get; private set; }
        public ChampionEntity Champion { get; private set; }
        public StatEntity Stat { get; private set; }
        public List<int> ItemIds { get; private set; }
    }
}
