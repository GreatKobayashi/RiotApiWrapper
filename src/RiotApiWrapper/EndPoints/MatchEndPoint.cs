using RiotApiWrapper.Entities;
using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;
using System.Text.Json;

namespace RiotApiWrapper.EndPoints
{
    public class MatchEndPoint
    {
        private readonly ApiClient _apiClient;

        public MatchEndPoint(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<List<string>> GetListAsync(
            Region region,
            string puuId,
            DateTimeOffset? startTime = null,
            DateTimeOffset? endTime = null,
            QueueType? queue = null,
            int start = 0,
            int count = 20)
        {
            long? startTimeLong = null;
            long? endTimeLong = null;
            if (startTime != null)
            {
                startTimeLong = ((DateTimeOffset)startTime).ToUnixTimeSeconds();
            }
            if (endTime != null)
            {
                endTimeLong = ((DateTimeOffset)endTime).ToUnixTimeSeconds();
            }

            return await GetListAsync(
                region, puuId, startTimeLong, endTimeLong, queue, start, count);
        }

        private async Task<List<string>> GetListAsync(
            Region region,
            string puuId,
            long? startTime,
            long? endTime,
            QueueType? queue,
            int start = 0,
            int count = 20)
        {
            var queries = new Dictionary<string, string>();
            if (startTime != null)
            {
                queries.Add("startTime", startTime.ToString()!);
            }
            if (endTime != null)
            {
                queries.Add("endTime", endTime.ToString()!);
            }
            if (queue != null)
            {
                queries.Add("queue", ((int)queue).ToString());
            }
            queries.Add("start", start.ToString());
            queries.Add("count", count.ToString());
            return await _apiClient.GetAsync<List<string>>(
                $"https://{region}.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuId}/ids", queries);
        }

        public async Task<MatchEntity> GetInfoAsync(Region region, string matchId)
        {
            var response = await _apiClient.GetAsync<Dictionary<string, JsonElement>>($"https://{region}.api.riotgames.com/lol/match/v5/matches/{matchId}");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var originalMetadata = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["metadata"].ToString()!, options);
            var originalInfo = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["info"].ToString()!, options);

            if (originalMetadata == null || originalInfo == null)
            {
                throw new InternalException("Unexpected response.");
            }

            var metaData = new MetaEntity(
                originalMetadata["dataVersion"].GetString()!,
                originalInfo["gameVersion"].GetString()!,
                originalInfo["gameName"].GetString()!,
                originalInfo["endOfGameResult"].GetString()!,
                originalInfo["tournamentCode"].GetString()!,
                originalInfo["gameId"].GetInt32(),
                DateTimeOffset.FromUnixTimeMilliseconds(originalInfo["gameCreation"].GetInt64()).DateTime,
                DateTimeOffset.FromUnixTimeMilliseconds(originalInfo["gameStartTimestamp"].GetInt64()).DateTime,
                DateTimeOffset.FromUnixTimeMilliseconds(originalInfo["gameEndTimestamp"].GetInt64()).DateTime,
                new TimeSpan(0, 0, originalInfo["gameDuration"].GetInt32()),
                Enum.Parse<GameMode>(originalInfo["gameMode"].GetString()!, true),
                Enum.Parse<GameType>(originalInfo["gameType"].GetString()!.Replace("_", ""), true),
                (Map)originalInfo["mapId"].GetInt32(),
                Enum.Parse<Platform>(originalInfo["platformId"].GetString()!, true),
                (QueueType)originalInfo["queueId"].GetInt32());

            var participants = new List<ParticipantEntity>();
            var originalParticipants = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalInfo["participants"].ToString()!, options);

            if (originalParticipants == null)
            {
                throw new InternalException("Unexpected response.");
            }

            foreach (var originalParticipant in originalParticipants)
            {
                var originalChalenges = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalParticipant["challenges"].ToString()!, options);

                if (originalChalenges == null)
                {
                    throw new InternalException("Unexpected response.");
                }

                var positionStr = originalParticipant["teamPosition"].GetString()!;
                Position position;
                if (positionStr == "UTILITY")
                {
                    position = Position.Support;
                }
                else
                {
                    position = Enum.Parse<Position>(positionStr, true);
                }
                participants.Add(new(
                    originalParticipant["participantId"].GetInt32(),
                    originalParticipant["placement"].GetInt32(),
                    originalParticipant["champExperience"].GetInt32(),
                    originalParticipant["champLevel"].GetInt32(),
                    originalParticipant["goldEarned"].GetInt32(),
                    originalParticipant["goldSpent"].GetInt32(),
                    (Team)originalParticipant["teamId"].GetInt32(),
                    position,
                    (SummonerSpel)originalParticipant["summoner1Id"].GetInt32(),
                    (SummonerSpel)originalParticipant["summoner2Id"].GetInt32(),
                    originalParticipant["win"].GetBoolean(),
                    !originalParticipant["eligibleForProgression"].GetBoolean(),
                    new(
                        originalParticipant["summonerId"].GetString()!,
                        null,
                        originalParticipant["puuid"].GetString()!,
                        originalParticipant["profileIcon"].GetInt32(),
                        originalParticipant["summonerLevel"].GetInt32(),
                        originalParticipant["riotIdGameName"].GetString()!,
                        originalParticipant["riotIdTagline"].GetString()!),
                    new(
                        originalParticipant["allInPings"].GetInt32(),
                        originalParticipant["assistMePings"].GetInt32(),
                        originalParticipant["basicPings"].GetInt32(),
                        originalParticipant["commandPings"].GetInt32(),
                        originalParticipant["dangerPings"].GetInt32(),
                        originalParticipant["enemyMissingPings"].GetInt32(),
                        originalParticipant["enemyVisionPings"].GetInt32(),
                        originalParticipant["getBackPings"].GetInt32(),
                        originalParticipant["holdPings"].GetInt32(),
                        originalParticipant["needVisionPings"].GetInt32(),
                        originalParticipant["onMyWayPings"].GetInt32(),
                        originalParticipant["pushPings"].GetInt32(),
                        originalParticipant["visionClearedPings"].GetInt32()),
                    new(
                        originalParticipant["championId"].GetInt32(),
                        originalParticipant["championName"].GetString()!,
                        originalParticipant["championTransform"].GetInt32()),
                    new(
                        new(
                            originalParticipant["kills"].GetInt32(),
                            originalParticipant["doubleKills"].GetInt32(),
                            originalParticipant["tripleKills"].GetInt32(),
                            originalParticipant["quadraKills"].GetInt32(),
                            originalParticipant["pentaKills"].GetInt32(),
                            originalParticipant["killingSprees"].GetInt32(),
                            originalParticipant["largestKillingSpree"].GetInt32(),
                            originalParticipant["largestMultiKill"].GetInt32(),
                            originalChalenges["soloKills"].GetInt32(),
                            originalParticipant["firstBloodKill"].GetBoolean(),
                            originalParticipant["firstBloodAssist"].GetBoolean()),
                        new(
                            originalChalenges["riftHeraldTakedowns"].GetInt32(),
                            originalParticipant["baronKills"].GetInt32(),
                            originalChalenges["baronTakedowns"].GetInt32(),
                            originalParticipant["dragonKills"].GetInt32(),
                            originalChalenges["dragonTakedowns"].GetInt32(),
                            originalParticipant["inhibitorKills"].GetInt32(),
                            originalParticipant["inhibitorTakedowns"].GetInt32(),
                            originalParticipant["turretKills"].GetInt32(),
                            originalParticipant["turretTakedowns"].GetInt32(),
                            originalParticipant["nexusKills"].GetInt32(),
                            originalParticipant["nexusTakedowns"].GetInt32(),
                            originalParticipant["objectivesStolen"].GetInt32(),
                            originalParticipant["objectivesStolenAssists"].GetInt32(),
                            originalParticipant["firstTowerKill"].GetBoolean(),
                            originalParticipant["firstTowerAssist"].GetBoolean()),
                        new(
                            originalParticipant["totalDamageDealt"].GetInt32(),
                            originalParticipant["damageDealtToBuildings"].GetInt32(),
                            originalParticipant["damageDealtToObjectives"].GetInt32(),
                            originalParticipant["damageDealtToTurrets"].GetInt32(),
                            originalParticipant["totalDamageDealtToChampions"].GetInt32(),
                            originalParticipant["damageSelfMitigated"].GetInt32(),
                            originalParticipant["magicDamageDealt"].GetInt32(),
                            originalParticipant["magicDamageDealtToChampions"].GetInt32(),
                            originalParticipant["magicDamageTaken"].GetInt32(),
                            originalParticipant["physicalDamageDealt"].GetInt32(),
                            originalParticipant["physicalDamageDealtToChampions"].GetInt32(),
                            originalParticipant["physicalDamageTaken"].GetInt32(),
                            originalParticipant["totalDamageShieldedOnTeammates"].GetInt32(),
                            originalParticipant["totalDamageTaken"].GetInt32(),
                            originalParticipant["totalHeal"].GetInt32(),
                            originalParticipant["totalUnitsHealed"].GetInt32(),
                            originalParticipant["totalHealsOnTeammates"].GetInt32(),
                            originalParticipant["totalTimeCCDealt"].GetInt32(),
                            originalParticipant["timeCCingOthers"].GetInt32(),
                            originalParticipant["trueDamageDealt"].GetInt32(),
                            originalParticipant["trueDamageDealtToChampions"].GetInt32(),
                            originalParticipant["trueDamageTaken"].GetInt32(),
                            originalParticipant["largestCriticalStrike"].GetInt32()),
                        originalParticipant["deaths"].GetInt32(),
                        originalParticipant["assists"].GetInt32(),
                        originalParticipant["bountyLevel"].GetInt32(),
                        originalParticipant["itemsPurchased"].GetInt32(),
                        originalParticipant["longestTimeSpentLiving"].GetInt32(),
                        originalParticipant["totalTimeSpentDead"].GetInt32()
                    ),
                    new()
                    {
                        originalParticipant["item0"].GetInt32(),
                        originalParticipant["item1"].GetInt32(),
                        originalParticipant["item2"].GetInt32(),
                        originalParticipant["item3"].GetInt32(),
                        originalParticipant["item4"].GetInt32(),
                        originalParticipant["item5"].GetInt32(),
                        originalParticipant["item6"].GetInt32(),
                    }
                ));
            }

            var teams = new List<TeamEntity>();
            var originalTeams = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalInfo["teams"].ToString()!, options);

            if (originalTeams == null)
            {
                throw new InternalException("Unexpected response.");
            }

            foreach (var originalTeam in originalTeams)
            {
                var test = originalTeam["bans"].ToString();
                var originalBans = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalTeam["bans"].ToString()!, options);
                if (originalBans == null)
                {
                    throw new InternalException("Unexpected response.");
                }

                var bans = new List<BanEntity>();
                foreach (var originalBan in originalBans)
                {
                    bans.Add(new(
                        originalBan["championId"].GetInt32(),
                        originalBan["pickTurn"].GetInt32()));
                }

                var participantInTeam = originalParticipants.First(x => x["teamId"].GetInt32() == originalTeam["teamId"].GetInt32());
                var win = originalTeam["win"].GetBoolean();

                var originalObjectives = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalTeam["objectives"].ToString()!, options)!;
                var baron = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["baron"].ToString()!, options)!;
                var champion = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["champion"].ToString()!, options)!;
                var dragon = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["dragon"].ToString()!, options)!;
                var voidGrub = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["horde"].ToString()!, options)!;
                var inhibitor = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["inhibitor"].ToString()!, options)!;
                var riftHerald = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["riftHerald"].ToString()!, options)!;
                var tower = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["tower"].ToString()!, options)!;
                teams.Add(new(
                    (Team)originalTeam["teamId"].GetInt32(),
                    win,
                    participantInTeam["gameEndedInSurrender"].GetBoolean() && !win,
                    participantInTeam["gameEndedInEarlySurrender"].GetBoolean() && !win,
                    bans,
                    new(
                        new(
                            baron["first"].GetBoolean(),
                            baron["kills"].GetInt32()),
                        new(
                            champion["first"].GetBoolean(),
                            champion["kills"].GetInt32()),
                        new(
                            dragon["first"].GetBoolean(),
                            dragon["kills"].GetInt32()),
                        new(
                            voidGrub["first"].GetBoolean(),
                            voidGrub["kills"].GetInt32()),
                        new(
                            inhibitor["first"].GetBoolean(),
                            inhibitor["kills"].GetInt32()),
                        new(
                            riftHerald["first"].GetBoolean(),
                            riftHerald["kills"].GetInt32()),
                        new(
                            tower["first"].GetBoolean(),
                            tower["kills"].GetInt32()))
                    )
                );
            }

            return new MatchEntity(metaData, participants, teams);
        }
    }
}
