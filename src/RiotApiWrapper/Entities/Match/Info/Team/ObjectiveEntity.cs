namespace RiotApiWrapper.Entities.Match.Info.Team
{
    public class ObjectiveEntity
    {
        public ObjectiveEntity(bool first, int kills)
        {
            First = first;
            Kills = kills;
        }

        public bool First { get; private set; }
        public int Kills { get; private set; }
    }
}
