using RiotApiWrapper.Misc;

namespace RiotApiWrapper.Entities
{
    public class MetaEntity
    {
        public MetaEntity(
            string dataVersion,
            string gameVersion,
            string gameName,
            string endOfGameResult,
            string tournamentCode,
            int gameId,
            DateTime gameCreationDate,
            DateTime gameStartDate,
            DateTime gameEndDate,
            TimeSpan gameDuration,
            GameMode gameMode,
            GameType gameType,
            Map map,
            Platform platform,
            QueueType queue)
        {
            DataVersion = dataVersion;
            GameVersion = gameVersion;
            GameName = gameName;
            EndOfGameResult = endOfGameResult;
            TournamentCode = tournamentCode;
            GameId = gameId;
            GameCreationDate = gameCreationDate;
            GameStartDate = gameStartDate;
            GameEndDate = gameEndDate;
            GameDuration = gameDuration;
            GameMode = gameMode;
            GameType = gameType;
            Map = map;
            Platform = platform;
            Queue = queue;
        }

        public string DataVersion { get; private set; }
        public string GameVersion { get; private set; }
        public string GameName { get; private set; }
        public string EndOfGameResult { get; private set; }
        public string TournamentCode { get; private set; }
        public int GameId { get; private set; }
        public DateTime GameCreationDate { get; private set; }
        public DateTime GameStartDate { get; private set; }
        public DateTime GameEndDate { get; private set; }
        public TimeSpan GameDuration { get; private set; }
        public GameMode GameMode { get; private set; }
        public GameType GameType { get; private set; }
        public Map Map { get; private set; }
        public Platform Platform { get; private set; }
        public QueueType Queue { get; private set; }
    }
}
