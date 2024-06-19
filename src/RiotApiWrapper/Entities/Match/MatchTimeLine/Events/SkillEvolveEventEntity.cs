namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class SkillEvolveEventEntity : LevelUpEventEntity
    {
        public SkillEvolveEventEntity(int participantId, TimeSpan timeStamp, int skillSlot) : base(participantId, skillSlot, timeStamp)
        {
        }
    }
}
