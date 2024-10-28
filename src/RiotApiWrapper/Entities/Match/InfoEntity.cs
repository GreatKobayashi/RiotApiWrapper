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
        /// UnixMillSecond
        /// </summary>
        public int GameDuration { get; private set; }

        /// <summary>
        /// UnixMillSecond
        /// </summary>
        public long GameEndTimestamp { get; private set; }

        public int GameId { get; private set; }
        public string GameMode { get; private set; }
        public string GameName { get; private set; }

        /// <summary>
        /// UnixMillSecond
        /// </summary>
        public long GameStartTimestamp { get; private set; }

        public string GameType { get; private set; }
        public string GameVersion { get; private set; }
        public int MapId { get; private set; }
        public List<Participant2Entity> Participants { get; private set; }
        public string PlatformId { get; private set; }
        public int QueueId { get; private set; }
        public List<Team2Entity> Teams { get; private set; }
        public string TournamentCode { get; private set; }
    }
}
