using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities
{
    public class ParticipantEntity
    {
        public int Id { get; private set; }
        public Position Position { get; private set; }
        public ChampionEntity Champion { get; private set; }
        public Team Team { get; private set; }
        public bool Win { get; private set; }
        public bool Afk { get; private set; }
        public AccountEntity Account { get; private set; }
        public PingCountEntity PingCount { get; private set; }
        public StatEntity Stat { get; private set; }
        public int Placement { get; private set; }
        public List<Item> Items { get; private set; }
        public SummonerSpel SummonerSpel1 { get; private set; }
        public SummonerSpel SummonerSpel2 { get; private set; }
        public int ChampionExp { get; private set; }
        public int ChampionLv { get; private set; }
        public int EarnedGold { get; private set; }
        public int SpentGold { get; private set; }
    }
}
