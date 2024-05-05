using RiotApiWrapper.Misc;
using System.Text.Json.Serialization;

namespace RiotApiWrapper.Entities
{
    public class MatchInfoEntity
    {
        public MatchInfoEntity(
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
            QueueType queueId,
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

        [JsonInclude]
        public string EndOfGameResult { get; private set; }
        [JsonInclude]
        public long GameCreation { get; private set; }
        [JsonInclude]
        public int GameDuration { get; private set; }
        [JsonInclude]
        public long GameEndTimestamp { get; private set; }
        [JsonInclude]
        public int GameId { get; private set; }
        [JsonInclude]
        public string GameMode { get; private set; }
        [JsonInclude]
        public string GameName { get; private set; }
        [JsonInclude]
        public long GameStartTimestamp { get; private set; }
        [JsonInclude]
        public string GameType { get; private set; }
        [JsonInclude]
        public string GameVersion { get; private set; }
        [JsonInclude]
        public int MapId { get; private set; }
        [JsonInclude]
        public List<ParticipantEntity> Participants { get; private set; }
        [JsonInclude]
        public string PlatformId { get; private set; }
        [JsonInclude]
        public QueueType QueueId { get; private set; }
        [JsonInclude]
        public List<TeamEntity> Teams { get; private set; }
        [JsonInclude]
        public string TournamentCode { get; private set; }
    }
}
