using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities.Match.MatchTimeLine.Events
{
    public class BuildingKillEventEntity : EventFrameEntity
    {
        public BuildingKillEventEntity(int participantId, TimeSpan timeStamp, BuildingType type, List<int> assistIds, int bounty, Lane lane, Team team)
            : base(participantId, timeStamp)
        {
            Type = type;
            AssistIds = assistIds;
            Bounty = bounty;
            Lane = lane;
            KillerTeam = team;
        }

        public BuildingType Type { get; private set; }
        public List<int> AssistIds { get; private set; }
        public int Bounty { get; private set; }
        public Lane Lane { get; private set; }
        public Team KillerTeam { get; private set; }
    }
}
