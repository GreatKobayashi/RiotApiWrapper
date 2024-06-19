using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities.Match
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
            SummonerSpell summonerSpel1,
            SummonerSpell summonerSpel2,
            bool win,
            bool afk,
            SummonerEntity summoner,
            PingCountEntity pingCount,
            ChampionEntity champion,
            TotalStatEntity stat,
            CastEntity cast,
            ArenaEntity arena,
            List<int> itemIds,
            int wardId)
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
            Cast = cast;
            Arena = arena;
            ItemIds = itemIds;
            WardId = wardId;
        }

        public int Id { get; private set; }
        public int Placement { get; private set; }
        public int ChampionExp { get; private set; }
        public int ChampionLv { get; private set; }
        public int EarnedGold { get; private set; }
        public int SpentGold { get; private set; }
        public Team Team { get; private set; }
        public Position Position { get; private set; }
        public SummonerSpell SummonerSpel1 { get; private set; }
        public SummonerSpell SummonerSpel2 { get; private set; }
        public bool Win { get; private set; }
        public bool Afk { get; private set; }
        public SummonerEntity Summoner { get; private set; }
        public PingCountEntity PingCount { get; private set; }
        public ChampionEntity Champion { get; private set; }
        public TotalStatEntity Stat { get; private set; }
        public CastEntity Cast { get; private set; }
        public ArenaEntity Arena { get; private set; }
        public List<int> ItemIds { get; private set; }
        public int WardId { get; private set; }
    }
}
