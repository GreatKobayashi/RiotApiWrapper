using RiotApiWrapper.Entities.Common;
using RiotApiWrapper.Entities.TimeLine;
using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities
{
    public class TimelineEntity
    {
        public MetaEntity Metadata { get; private set; }
        public InfoEntity Info { get; private set; }

        [JsonConstructor]
        public TimelineEntity(MetaEntity metadata, InfoEntity info)
        {
            Metadata = metadata;
            Info = info;
        }
    }
}
