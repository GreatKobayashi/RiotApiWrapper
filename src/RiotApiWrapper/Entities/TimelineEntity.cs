using RiotApiWrapper.Entities.Common;
using RiotApiWrapper.Entities.TimeLine;

namespace RiotApiWrapper.Entities
{
    public class TimelineEntity
    {
        public TimelineEntity(MetaEntity metadata, InfoEntity info)
        {
            Metadata = metadata;
            Info = info;
        }

        public MetaEntity Metadata { get; private set; }
        public InfoEntity Info { get; private set; }
    }
}
