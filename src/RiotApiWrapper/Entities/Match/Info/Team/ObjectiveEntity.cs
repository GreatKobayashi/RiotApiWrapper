using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match.Info.Team
{
    public class ObjectiveEntity
    {
        public bool First { get; private set; }
        public int Kills { get; private set; }

        [JsonConstructor]
        public ObjectiveEntity(bool first, int kills)
        {
            First = first;
            Kills = kills;
        }
    }
}
