using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.TimeLine.Info
{
    public class ParticipantEntity
    {
        public int ParticipantId { get; private set; }
        public string Puuid { get; private set; }

        [JsonConstructor]
        public ParticipantEntity(int participantId, string puuid)
        {
            ParticipantId = participantId;
            Puuid = puuid;
        }
    }
}
