namespace RiotApiWrapper.Entities
{
    public class TeamObjectiveEntity
    {
        public TeamObjectiveEntity(bool first, int kills)
        {
            First = first;
            Kills = kills;
        }

        public bool First { get; private set; }
        public int Kills { get; private set; }
    }
}
