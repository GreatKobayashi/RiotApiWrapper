using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class WardEventEntity : EventFrameEntity
    {
        public WardEventEntity(int participantId, TimeSpan timeStamp, WardType ward, WardEventType eventType)
            : base(participantId, timeStamp)
        {
            Ward = ward;
            EventType = eventType;
        }

        public WardType Ward { get; private set; }
        public WardEventType EventType { get; private set; }
    }
}
