using RiotApiWrapper.Entities;
using RiotApiWrapper.Entities.Match;
using RiotApiWrapper.Entities.Match.MatchTimeLine;
using RiotApiWrapper.Entities.Match.MatchTimeLine.Events;
using RiotApiWrapper.Exceptions;
using RiotApiWrapper.Misc;
using System.Text.Json;

namespace RiotApiWrapper.EndPoints
{
    public class MatchEndPoint : EndPoint
    {
        public MatchEndPoint(ApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<List<string>> GetIdListAsync(
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

            return await GetIdListAsync(
                region, puuId, startTimeLong, endTimeLong, queue, start, count);
        }

        private async Task<List<string>> GetIdListAsync(
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
            return await ApiClient.GetAsync<List<string>>(
                $"https://{region}.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuId}/ids", queries);
        }

        public async Task<MatchEntity> GetInfoAsync(Region region, string matchId)
        {
            var response = await ApiClient.GetAsync<Dictionary<string, JsonElement>>($"https://{region}.api.riotgames.com/lol/match/v5/matches/{matchId}");

            var originalMetadata = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["metadata"].ToString()!, Options);
            var originalInfo = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["info"].ToString()!, Options);

            if (originalMetadata == null || originalInfo == null)
            {
                throw new RiotApiException("Unexpected response.");
            }

            var metaData = new MetaEntity(
                originalMetadata["dataVersion"].GetString()!,
                originalInfo["gameVersion"].GetString()!,
                originalInfo["gameName"].GetString()!,
                originalInfo["endOfGameResult"].GetString()!,
                originalInfo["tournamentCode"].GetString()!,
                originalMetadata["matchId"].GetString()!,
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
            var originalParticipants = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalInfo["participants"].ToString()!, Options);

            if (originalParticipants == null)
            {
                throw new RiotApiException("Unexpected response.");
            }

            foreach (var originalParticipant in originalParticipants)
            {
                Dictionary<string, JsonElement>? originalChalenges;
                // AI don't have challenges column.
                if (originalParticipant.ContainsKey("challenges"))
                {
                    originalChalenges = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalParticipant["challenges"].ToString()!, Options);
                }
                else
                {
                    originalChalenges = null;
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

                var itemIds = new List<int>()
                {
                    originalParticipant["item0"].GetInt32(),
                    originalParticipant["item1"].GetInt32(),
                    originalParticipant["item2"].GetInt32(),
                    originalParticipant["item3"].GetInt32(),
                    originalParticipant["item4"].GetInt32(),
                    originalParticipant["item5"].GetInt32(),
                };
                itemIds.RemoveAll(x => x == 0);

                participants.Add(new(
                    originalParticipant["participantId"].GetInt32(),
                    originalParticipant["placement"].GetInt32(),
                    originalParticipant["champExperience"].GetInt32(),
                    originalParticipant["champLevel"].GetInt32(),
                    originalParticipant["goldEarned"].GetInt32(),
                    originalParticipant["goldSpent"].GetInt32(),
                    (Team)originalParticipant["teamId"].GetInt32(),
                    position,
                    (SummonerSpell)originalParticipant["summoner1Id"].GetInt32(),
                    (SummonerSpell)originalParticipant["summoner2Id"].GetInt32(),
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
                            originalChalenges != null ? originalChalenges["soloKills"].GetInt32() : 0,
                            originalParticipant["firstBloodKill"].GetBoolean(),
                            originalParticipant["firstBloodAssist"].GetBoolean()),
                        new(
                            originalChalenges != null ? originalChalenges["riftHeraldTakedowns"].GetInt32() : 0,
                            originalParticipant["baronKills"].GetInt32(),
                            originalChalenges != null ? originalChalenges["baronTakedowns"].GetInt32() : 0,
                            originalParticipant["dragonKills"].GetInt32(),
                            originalChalenges != null ? originalChalenges["dragonTakedowns"].GetInt32() : 0,
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
                    new(
                        originalParticipant["spell1Casts"].GetInt32(),
                        originalParticipant["spell2Casts"].GetInt32(),
                        originalParticipant["spell3Casts"].GetInt32(),
                        originalParticipant["spell4Casts"].GetInt32(),
                        originalParticipant["summoner1Casts"].GetInt32(),
                        originalParticipant["summoner2Casts"].GetInt32()),
                    new(
                        originalParticipant["playerAugment1"].GetInt32(),
                        originalParticipant["playerAugment1"].GetInt32(),
                        originalParticipant["playerAugment1"].GetInt32(),
                        originalParticipant["playerAugment1"].GetInt32(),
                        originalParticipant["playerSubteamId"].GetInt32(),
                        originalParticipant["subteamPlacement"].GetInt32()),
                    itemIds,
                    originalParticipant["item6"].GetInt32()
                ));
            }

            var teams = new List<TeamEntity>();
            var originalTeams = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalInfo["teams"].ToString()!, Options);

            if (originalTeams == null)
            {
                throw new RiotApiException("Unexpected response.");
            }

            foreach (var originalTeam in originalTeams)
            {
                var test = originalTeam["bans"].ToString();
                var originalBans = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalTeam["bans"].ToString()!, Options);
                if (originalBans == null)
                {
                    throw new RiotApiException("Unexpected response.");
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

                var originalObjectives = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalTeam["objectives"].ToString()!, Options)!;
                var baron = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["baron"].ToString()!, Options)!;
                var champion = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["champion"].ToString()!, Options)!;
                var dragon = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["dragon"].ToString()!, Options)!;
                var voidGrub = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["horde"].ToString()!, Options)!;
                var inhibitor = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["inhibitor"].ToString()!, Options)!;
                var riftHerald = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["riftHerald"].ToString()!, Options)!;
                var tower = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalObjectives["tower"].ToString()!, Options)!;
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

        public async Task<MatchTimeLineEntity> GetTimeLineAsync(Region region, string matchId)
        {
            try
            {
                var response = await ApiClient.GetAsync<Dictionary<string, JsonElement>>($"https://{region}.api.riotgames.com/lol/match/v5/matches/{matchId}/timeline");

                var originalInfo = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(response["info"].ToString()!, Options);
                if (originalInfo == null)
                {
                    throw new RiotApiException("Unexpected response.");
                }

                var frameIntervalMilliseconds = originalInfo["frameInterval"].GetInt32();
                var originalFrames = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalInfo["frames"].ToString()!, Options);
                if (originalFrames == null)
                {
                    throw new RiotApiException("Unexpected response.");
                }

                var frameStartTimeMilliseconds = 0;
                var allEvents = new List<EventFrameEntity>();
                var itemEvents = new List<ItemEventEntity>();
                var levelUpEvents = new List<LevelUpEventEntity>();
                var wardEvents = new List<WardEventEntity>();
                var championKillEvents = new List<ChampionKillEventEntity>();
                var buildingKillEvents = new List<BuildingKillEventEntity>();
                var epicMonsterKillEvents = new List<EpicMonsterKillEventEntity>();
                for (var i = 1; i <= 10; i++)
                {
                    var levelUpEvent = new LevelUpEventEntity(i, new TimeSpan(), 1);
                    levelUpEvents.Add(levelUpEvent);
                    allEvents.Add(levelUpEvent);
                }
                var participantsFrames = new List<StatPerMinuteEntity>();
                foreach (var originalFrame in originalFrames)
                {
                    var originalEvents = JsonSerializer.Deserialize<List<Dictionary<string, JsonElement>>>(originalFrame["events"].ToString()!, Options);
                    if (originalEvents == null)
                    {
                        throw new RiotApiException("Unexpected response.");
                    }

                    foreach (var originalEvent in originalEvents)
                    {
                        var participantId = originalEvent
                            .TryGetValue("participantId", out var participantIdJson) ? participantIdJson.GetInt32() : 0;
                        var timestamp = new TimeSpan(0, 0, 0, 0, originalEvent["timestamp"].GetInt32());
                        var assistIds = originalEvent
                            .TryGetValue("assistingParticipantIds", out var ids) ? ids.EnumerateArray().ToList().ConvertAll(x => x.GetInt32()) : new();
                        switch (originalEvent["type"].GetString())
                        {
                            case "ITEM_PURCHASED":
                            case "ITEM_SOLD":
                                var itemEventPurchase = new ItemEventEntity(
                                    participantId,
                                    timestamp,
                                    Enum.Parse<PurchaseEventType>(originalEvent["type"].GetString()!.Substring(5), true),
                                    originalEvent["itemId"].GetInt32());
                                itemEvents.Add(itemEventPurchase);
                                allEvents.Add(itemEventPurchase);
                                break;
                            case "ITEM_UNDO":
                                var itemEventUndo = new ItemEventEntity(
                                    participantId,
                                    timestamp,
                                    PurchaseEventType.Undo,
                                    originalEvent["beforeId"].GetInt32() is int id && id > 0 ? id : originalEvent["afterId"].GetInt32());
                                itemEvents.Add(itemEventUndo);
                                allEvents.Add(itemEventUndo);
                                break;
                            case "LEVEL_UP":
                                var levelUpEvent = new LevelUpEventEntity(
                                    participantId,
                                    timestamp,
                                    originalEvent["level"].GetInt32());
                                levelUpEvents.Add(levelUpEvent);
                                break;
                            case "SKILL_LEVEL_UP":
                                if (originalEvent["levelUpType"].GetString() == "EVOLVE")
                                {
                                    levelUpEvents.Add(new SkillEvolveEventEntity(participantId, timestamp, originalEvent["skillSlot"].GetInt32()));
                                }
                                else
                                {
                                    var lastLevelUpEvent = levelUpEvents.Where(x => x.ParticipantId == participantId).Last();
                                    lastLevelUpEvent.UseSkillPoint(originalEvent["skillSlot"].GetInt32());
                                    allEvents.Add(lastLevelUpEvent);
                                }
                                break;
                            case "WARD_PLACED":
                            case "WARD_KILL":
                                if (Enum.TryParse<WardType>(originalEvent["wardType"].GetString()!.Replace("_", ""), true, out var wardTypePlaced))
                                {
                                    var wardEvent = new WardEventEntity(
                                        participantId,
                                        timestamp,
                                        wardTypePlaced,
                                        Enum.Parse<WardEventType>(originalEvent["type"].GetString()!.Substring(5), true));
                                    wardEvents.Add(wardEvent);
                                    allEvents.Add(wardEvent);
                                }
                                break;
                            case "CHAMPION_KILL":
                                var championKillEvent = new ChampionKillEventEntity(
                                    originalEvent["killerId"].GetInt32(),
                                    timestamp,
                                    originalEvent["victimId"].GetInt32(),
                                    originalEvent["bounty"].GetInt32(),
                                    originalEvent["killStreakLength"].GetInt32(),
                                    assistIds);
                                championKillEvents.Add(championKillEvent);
                                allEvents.Add(championKillEvent);
                                break;
                            case "CHAMPION_SPECIAL_KILL":
                                switch (originalEvent["killType"].GetString())
                                {
                                    case "KILL_FIRST_BLOOD":
                                        championKillEvents.First(x => x.ParticipantId == originalEvent["killerId"].GetInt32()).IsFirstBlood = true;
                                        break;
                                    case "KILL_MULTI":
                                        var multiKillLength = originalEvent["multiKillLength"].GetInt32();
                                        Enumerable.Reverse(championKillEvents)
                                            .Where(x => x.ParticipantId == originalEvent["killerId"].GetInt32())
                                            .Take(multiKillLength).ToList()
                                            .ForEach(x => x.MultiKillLength = multiKillLength);
                                        break;
                                }
                                break;
                            case "TURRET_PLATE_DESTROYED":
                            case "BUILDING_KILL":
                                var buildingKillEvent = new BuildingKillEventEntity(
                                    originalEvent["killerId"].GetInt32(),
                                    timestamp,
                                    originalEvent.TryGetValue("towerType", out var towerType) ?
                                        Enum.Parse<BuildingType>(towerType.GetString()!.Replace("_", ""), true) :
                                        originalEvent.TryGetValue("buildingType", out var building) ?
                                            building.GetString() switch
                                            {
                                                "INHIBITOR_BUILDING" => BuildingType.Inhibitor,
                                                _ => throw new RiotApiException("Unexpected BuildingType.")
                                            } :
                                            BuildingType.OuterTurretPlate,
                                    assistIds,
                                    originalEvent.TryGetValue("bounty", out var bounty) ? bounty.GetInt32() : 0,
                                    originalEvent["laneType"].GetString() switch
                                    {
                                        "TOP_LANE" => Lane.Top,
                                        "MID_LANE" => Lane.Middle,
                                        "BOT_LANE" => Lane.Bottom,
                                        _ => throw new RiotApiException("Unexpected LaneType.")
                                    },
                                    (Team)originalEvent["teamId"].GetInt32() == Team.Red ? Team.Blue : Team.Red);
                                buildingKillEvents.Add(buildingKillEvent);
                                allEvents.Add(buildingKillEvent);
                                break;
                            case "ELITE_MONSTER_KILL":
                                var epicMonsterKillEvent = new EpicMonsterKillEventEntity(
                                    originalEvent["killerId"].GetInt32(),
                                    timestamp,
                                    (Team)originalEvent["killerTeamId"].GetInt32(),
                                    originalEvent["monsterType"].GetString() switch
                                    {
                                        "DRAGON" => originalEvent["monsterSubType"].GetString() switch
                                        {
                                            "FIRE_DRAGON" => EpicMonster.InfernalDrake,
                                            "CHEMTECH_DRAGON" => EpicMonster.ChemtechDrake,
                                            "EARTH_DRAGON" => EpicMonster.MountainDrake,
                                            "WATER_DRAGON" => EpicMonster.OceanDrake,
                                            "AIR_DRAGON" => EpicMonster.CloudDrake,
                                            "HEXTECH_DRAGON" => EpicMonster.HextechDrake,
                                            "ELDER_DRAGON" => EpicMonster.ElderDragon,
                                            _ => throw new RiotApiException("Unexpected MonsterSubType.")
                                        },
                                        "HORDE" => EpicMonster.VoidGrub,
                                        "RIFTHERALD" => EpicMonster.RiftHerald,
                                        "BARON_NASHOR" => EpicMonster.BaronNashor,
                                        _ => throw new RiotApiException("Unexpected MonsterType.")
                                    },
                                    originalEvent["bounty"].GetInt32(),
                                    assistIds);
                                epicMonsterKillEvents.Add(epicMonsterKillEvent);
                                allEvents.Add(epicMonsterKillEvent);
                                break;
                            case "DRAGON_SOUL_GIVEN":
                                epicMonsterKillEvents.Last(x => x.Monster.ToString().Contains("Dra")).GivenDragonSoul = true;
                                break;
                        }
                    }

                    var originalParticipantsFrames = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalFrame["participantFrames"].ToString()!, Options);
                    if (originalParticipantsFrames == null)
                    {
                        throw new RiotApiException("Unexpected response.");
                    }

                    var currentChampionStats = new List<CurrentChampionStatEntity>();
                    foreach (var originalParticipantsFrame in originalParticipantsFrames)
                    {
                        var originalParticipantFrame = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(originalParticipantsFrame.Value.ToString()!, Options)!;
                        var currentStatus = JsonSerializer.Deserialize<CurrentStatusEntity>(originalParticipantFrame["championStats"], Options)!;
                        currentStatus.Level = originalParticipantFrame["level"].GetInt32();
                        currentStatus.Exp = originalParticipantFrame["xp"].GetInt32();

                        var currentDamage = JsonSerializer.Deserialize<CurrentDamageEntity>(originalParticipantFrame["damageStats"], Options)!;
                        currentDamage.TimeCCDone = new(0, 0, 0, 0, originalParticipantFrame["timeEnemySpentControlled"].GetInt32());

                        var currentGold = new CurrentGoldEntity(
                            originalParticipantFrame["currentGold"].GetInt32(),
                            originalParticipantFrame["totalGold"].GetInt32(),
                            originalParticipantFrame["goldPerSecond"].GetInt32(),
                            originalParticipantFrame["jungleMinionsKilled"].GetInt32(),
                            originalParticipantFrame["minionsKilled"].GetInt32());

                        currentChampionStats.Add(new(Convert.ToInt32(originalParticipantsFrame.Key), currentStatus, currentDamage, currentGold));
                    }
                    participantsFrames.Add(new StatPerMinuteEntity(new(0, 0, 0, 0, frameStartTimeMilliseconds), currentChampionStats));

                    frameStartTimeMilliseconds += frameIntervalMilliseconds;
                }

                return new MatchTimeLineEntity(
                    allEvents,
                    itemEvents,
                    levelUpEvents,
                    wardEvents,
                    championKillEvents,
                    buildingKillEvents,
                    epicMonsterKillEvents,
                    participantsFrames);
            }
            catch (RiotApiException ex)
            {
                throw new RiotApiException("Invalid matchId.", ex);
            }
        }
    }
}
