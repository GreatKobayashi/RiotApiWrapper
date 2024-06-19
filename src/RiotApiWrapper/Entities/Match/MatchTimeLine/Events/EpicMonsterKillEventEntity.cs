using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class EpicMonsterKillEventEntity : EventFrameEntity
    {
        public EpicMonsterKillEventEntity(int participantId, TimeSpan timeStamp, Team team, EpicMonster monster, int bounty, List<int> assistIds)
            : base(participantId, timeStamp)
        {
            KillerTeam = team;
            Monster = monster;
            Bounty = bounty;
            AssistIds = assistIds;
        }

        public Team KillerTeam { get; private set; }
        public EpicMonster Monster { get; private set; }
        public int Bounty { get; private set; }
        public List<int> AssistIds { get; private set; }
        public bool GivenDragonSoul { get; internal set; } = false;
    }
}
