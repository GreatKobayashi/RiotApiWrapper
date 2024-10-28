using RiotApiWrapper.Entities.Match;
using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities
{
    public class MatchEntity
    {
        public Meta2Entity Metadata { get; private set; }
        public InfoEntity Info { get; private set; }

        [JsonConstructor]
        public MatchEntity(Meta2Entity metadata, InfoEntity info)
        {
            Metadata = metadata;
            Info = info;
        }
    }
}
