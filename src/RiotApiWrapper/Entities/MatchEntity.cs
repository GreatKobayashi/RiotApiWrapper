namespace RiotApiWrapper.Entities
{
    public class MatchEntity
    {
        public MatchEntity(MetaEntity meta, List<ParticipantEntity> participants, List<TeamEntity> teams)
        {
            Meta = meta;
            Participants = participants;
            Teams = teams;
        }

        public MetaEntity Meta { get; private set; }
        public List<ParticipantEntity> Participants { get; private set; }
        public List<TeamEntity> Teams { get; private set; }
    }
}
