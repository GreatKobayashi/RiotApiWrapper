namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class EventFrameEntity
    {
        public EventFrameEntity(int participantId, TimeSpan timeStamp)
        {
            ParticipantId = participantId;
            TimeStamp = timeStamp;
        }

        public int ParticipantId { get; private set; }
        public TimeSpan TimeStamp { get; private set; }
    }
}
