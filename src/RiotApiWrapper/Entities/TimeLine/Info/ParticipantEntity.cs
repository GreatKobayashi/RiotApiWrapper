namespace RiotApiWrapper.Entities.TimeLine.Info
{
    public class ParticipantEntity
    {
        public ParticipantEntity(int participantId, string puuid)
        {
            ParticipantId = participantId;
            Puuid = puuid;
        }

        public int ParticipantId { get; private set; }
        public string Puuid { get; private set; }
    }
}
