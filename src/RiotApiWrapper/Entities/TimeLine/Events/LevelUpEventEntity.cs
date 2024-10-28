namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class LevelUpEventEntity : EventFrameEntity
    {
        public LevelUpEventEntity(int participantId, TimeSpan timeStamp, int level)
            : base(participantId, timeStamp)
        {
            Level = level;
        }

        protected LevelUpEventEntity(int participantId, int skillSlot, TimeSpan timeStamp)
            : base(participantId, timeStamp)
        {
            SkillSlot = skillSlot;
        }

        public int Level { get; private set; }
        public int? SkillSlot { get; private set; }

        public void UseSkillPoint(int slot)
        {
            SkillSlot = slot;
        }
    }
}
