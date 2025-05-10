using RiotApiWrapper.Entities.League;

namespace RiotApiWrapper.Entities
{
    public class LeagueEntity
    {
        public LeagueEntity(string leagueId, List<LeagueItemEntity> entries, string tier, string name, string queue)
        {
            LeagueId = leagueId;
            Entries = entries;
            Tier = tier;
            Name = name;
            Queue = queue;
        }

        public string LeagueId { get; private set; }
        public List<LeagueItemEntity> Entries { get; private set; }
        public string Tier { get; private set; }
        public string Name { get; private set; }
        public string Queue { get; private set; }
    }
}
