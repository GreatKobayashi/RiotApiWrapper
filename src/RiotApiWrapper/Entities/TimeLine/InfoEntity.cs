using RiotApiWrapper.Entities.TimeLine.Info;

namespace RiotApiWrapper.Entities.TimeLine
{
    public class InfoEntity
    {
        public InfoEntity(
            string endOfGameResult, int frameInterval, List<FrameEntity> frames, int gameId, List<ParticipantEntity> participants)
        {
            EndOfGameResult = endOfGameResult;
            FrameInterval = frameInterval;
            Frames = frames;
            GameId = gameId;
            Participants = participants;
        }

        public string EndOfGameResult { get; private set; }
        /// <summary>
        /// Millisecond
        /// </summary>
        public int FrameInterval { get; private set; }
        /// <summary>
        /// Index 0 : At the start of the game
        /// Index 1 : 0 ~ 60 seconds
        /// Index 2 : 60 ~ 120 seconds ..
        /// </summary>
        public List<FrameEntity> Frames { get; private set; }
        public int GameId { get; private set; }
        public List<ParticipantEntity> Participants { get; private set; }
    }
}
