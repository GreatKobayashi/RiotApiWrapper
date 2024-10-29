using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Common
{
    public class MetaEntity
    {
        public string DataVersion { get; private set; }
        public string MatchId { get; private set; }
        public List<string> Participants { get; private set; }

        [JsonConstructor]
        public MetaEntity(string dataVersion, string matchId, List<string> participants)
        {
            DataVersion = dataVersion;
            MatchId = matchId;
            Participants = participants;
        }
    }
}
