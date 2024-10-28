using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match
{
    public class Meta2Entity
    {
        public string DataVersion { get; private set; }
        public string MatchId { get; private set; }
        public List<string> Participants { get; private set; }

        [JsonConstructor]
        public Meta2Entity(string dataVersion, string matchId, List<string> participants)
        {
            DataVersion = dataVersion;
            MatchId = matchId;
            Participants = participants;
        }
    }
}
