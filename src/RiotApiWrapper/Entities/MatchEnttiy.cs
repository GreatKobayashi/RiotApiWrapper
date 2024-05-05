namespace RiotApiWrapper.Entities
{
    public class MatchEnttiy
    {
        public MetaEntity Meta { get; private set; }
        public List<ParticipantEntity> Participants { get; private set; }
        public List<TeamEntity> Teams { get; private set; }
    }
}
