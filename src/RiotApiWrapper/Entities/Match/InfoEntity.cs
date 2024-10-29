using RiotApiWrapper.Entities.Match.Info;
using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities.Match
{
    public class InfoEntity
    {
        public string EndOfGameResult { get; private set; }

        /// <summary>
        /// Second
        /// </summary>
        public long GameCreation { get; private set; }

        /// <summary>
        /// UnixMilliseconds
        /// </summary>
        public int GameDuration { get; private set; }

        /// <summary>
        /// UnixMilliseconds
        /// </summary>
        public long GameEndTimestamp { get; private set; }

        public int GameId { get; private set; }
        public string GameMode { get; private set; }
        public string GameName { get; private set; }

        /// <summary>
        /// UnixMilliseconds
        /// </summary>
        public long GameStartTimestamp { get; private set; }

        public string GameType { get; private set; }
        public string GameVersion { get; private set; }
        public int MapId { get; private set; }
        public List<ParticipantEntity> Participants { get; private set; }
        public string PlatformId { get; private set; }
        public int QueueId { get; private set; }
        public List<TeamEntity> Teams { get; private set; }
        public string TournamentCode { get; private set; }

        [JsonConstructor]
        public InfoEntity(
            string endOfGameResult,
            long gameCreation,
            int gameDuration,
            long gameEndTimestamp,
            int gameId,
            string gameMode,
            string gameName,
            long gameStartTimestamp,
            string gameType,
            string gameVersion,
            int mapId,
            List<ParticipantEntity> participants,
            string platformId,
            int queueId,
            List<TeamEntity> teams,
            string tournamentCode)
        {
            EndOfGameResult = endOfGameResult;
            GameCreation = gameCreation;
            GameDuration = gameDuration;
            GameEndTimestamp = gameEndTimestamp;
            GameId = gameId;
            GameMode = gameMode;
            GameName = gameName;
            GameStartTimestamp = gameStartTimestamp;
            GameType = gameType;
            GameVersion = gameVersion;
            MapId = mapId;
            Participants = participants;
            PlatformId = platformId;
            QueueId = queueId;
            Teams = teams;
            TournamentCode = tournamentCode;
        }
    }
}
