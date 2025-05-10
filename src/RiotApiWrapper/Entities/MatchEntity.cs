using RiotApiWrapper.Entities.Common;
using RiotApiWrapper.Entities.Match;

namespace RiotApiWrapper.Entities
{
    public class MatchEntity
    {
        public MatchEntity(MetaEntity metadata, InfoEntity info)
        {
            Metadata = metadata;
            Info = info;
        }

        public MetaEntity Metadata { get; private set; }
        public InfoEntity Info { get; private set; }
    }
}
