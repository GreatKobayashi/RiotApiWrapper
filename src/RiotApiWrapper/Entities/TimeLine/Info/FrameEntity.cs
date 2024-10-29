using RiotApiWrapper.Entities.TimeLine.Info.Frame;
using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.TimeLine.Info
{
    public class FrameEntity
    {
        public List<EventEntity> Events { get; private set; }
        public Dictionary<string, ParticipantFrameEntity> ParticipantFrames { get; private set; }
        public int Timestamp { get; private set; }

        [JsonConstructor]
        public FrameEntity(
            List<EventEntity> events, Dictionary<string, ParticipantFrameEntity> participantFrames, int timestamp)
        {
            Events = events;
            ParticipantFrames = participantFrames;
            Timestamp = timestamp;
        }
    }
}
