using RiotApiWrapper.Entities.TimeLine.Info.Frame;

namespace RiotApiWrapper.Entities.TimeLine.Info
{
    public class FrameEntity
    {
        public FrameEntity(
            List<EventEntity> events, Dictionary<string, ParticipantFrameEntity> participantFrames, int timestamp)
        {
            Events = events;
            ParticipantFrames = participantFrames;
            Timestamp = timestamp;
        }

        public List<EventEntity> Events { get; private set; }
        public Dictionary<string, ParticipantFrameEntity> ParticipantFrames { get; private set; }
        public int Timestamp { get; private set; }
    }
}
