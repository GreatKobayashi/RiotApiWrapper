using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities
{
    public class TeamEntity
    {
        public TeamEntity(Team team, bool win, bool surrender, bool earlySurrender, List<BanEntity> bans, TeamObjectivesEntity objectives)
        {
            Team = team;
            Win = win;
            Surrender = surrender;
            EarlySurrender = earlySurrender;
            Bans = bans;
            Objectives = objectives;
        }

        public Team Team { get; private set; }
        public bool Win { get; private set; }
        public bool Surrender { get; private set; }
        public bool EarlySurrender { get; private set; }
        public List<BanEntity> Bans { get; private set; }
        public TeamObjectivesEntity Objectives { get; private set; }
    }
}
