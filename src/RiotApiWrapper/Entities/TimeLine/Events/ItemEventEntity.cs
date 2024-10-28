using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class ItemEventEntity : EventFrameEntity
    {
        public ItemEventEntity(int participantId, TimeSpan timeStamp, PurchaseEventType type, int itemId) : base(participantId, timeStamp)
        {
            EventType = type;
            ItemId = itemId;
        }

        public PurchaseEventType EventType { get; private set; }
        public int ItemId { get; private set; }
    }
}
