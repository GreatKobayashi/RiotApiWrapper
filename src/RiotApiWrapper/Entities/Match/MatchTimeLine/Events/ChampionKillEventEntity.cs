namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class ChampionKillEventEntity : EventFrameEntity
    {
        public ChampionKillEventEntity(int participantId, TimeSpan timeStamp, int victimId, int bounty, int killStreakLength, List<int> assistIds)
            : base(participantId, timeStamp)
        {
            VictimId = victimId;
            Bounty = bounty;
            KillStreakLength = killStreakLength;
            AssistIds = assistIds;
        }

        public int VictimId { get; private set; }
        public int Bounty { get; private set; }
        public int KillStreakLength { get; private set; }
        public List<int> AssistIds { get; private set; }
        public int MultiKillLength { get; internal set; } = 1;
        public bool IsFirstBlood { get; internal set; } = false;
    }
}
