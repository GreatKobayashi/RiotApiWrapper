using RiotApiWrapper.Entities.Match.Info.Team;

namespace RiotApiWrapper.Entities.Match.Info
{
    public class TeamEntity
    {
        public TeamEntity(List<BanEntity> bans, Dictionary<string, ObjectiveEntity> objectives, int teamId, bool win)
        {
            Bans = bans;
            Objectives = objectives;
            TeamId = teamId;
            Win = win;
        }

        public List<BanEntity> Bans { get; private set; }
        public Dictionary<string, ObjectiveEntity> Objectives { get; private set; }
        public int TeamId { get; private set; }
        public bool Win { get; private set; }
    }
}
