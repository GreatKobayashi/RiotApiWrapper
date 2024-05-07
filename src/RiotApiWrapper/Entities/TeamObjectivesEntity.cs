namespace RiotApiWrapper.Entities
{
    public class TeamObjectivesEntity
    {
        public TeamObjectivesEntity(TeamObjectiveEntity baron, TeamObjectiveEntity champion, TeamObjectiveEntity dragon, TeamObjectiveEntity voidGrub, TeamObjectiveEntity inhibitor, TeamObjectiveEntity riftHerald, TeamObjectiveEntity tower)
        {
            Baron = baron;
            Champion = champion;
            Dragon = dragon;
            VoidGrub = voidGrub;
            Inhibitor = inhibitor;
            RiftHerald = riftHerald;
            Tower = tower;
        }

        public TeamObjectiveEntity Baron { get; private set; }
        public TeamObjectiveEntity Champion { get; private set; }
        public TeamObjectiveEntity Dragon { get; private set; }
        public TeamObjectiveEntity VoidGrub { get; private set; }
        public TeamObjectiveEntity Inhibitor { get; private set; }
        public TeamObjectiveEntity RiftHerald { get; private set; }
        public TeamObjectiveEntity Tower { get; private set; }
    }
}
