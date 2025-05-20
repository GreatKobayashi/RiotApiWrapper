using RiotApiWrapper.Entities.Match.Info.Participant;

namespace RiotApiWrapper.Entities.Match.Info
{
    public class ParticipantEntity
    {
        public ParticipantEntity(
            int allInPings,
            int assistMePings,
            int assists,
            int baronKills,
            int basicPings,
            int bountyLevel,
            Dictionary<string, object> challenges,
            int champExperience,
            int champLevel,
            int championId,
            string championName,
            int championTransform,
            int commandPings,
            int consumablesPurchased,
            int damageDealtToBuildings,
            int damageDealtToObjectives,
            int damageDealtToTurrets,
            int damageSelfMitigated,
            int dangerPings,
            int deaths,
            int detectorWardsPlaced,
            int doubleKills,
            bool eligibleForProgression,
            int enemyMissingPings,
            int enemyVisionPings,
            bool firstBloodAssist,
            bool firstBloodKill,
            bool firstTowerAssist,
            bool firstTowerKill,
            bool gameEndedInEarlySurrender,
            bool gameEndedInSurrender,
            int getBackPings,
            int goldEarned,
            int goldSpent,
            int holdPings,
            string individualPosition,
            int inhibitorKills,
            int inhibitorTakedowns,
            int inhibitorsLost,
            int item0,
            int item1,
            int item2,
            int item3,
            int item4,
            int item5,
            int item6,
            int itemsPurchased,
            int killingSprees,
            int kills,
            int largestCriticalStrike,
            int largestKillingSpree,
            int largestMultiKill,
            int longestTimeSpentLiving,
            int magicDamageDealt,
            int magicDamageDealtToChampions,
            int magicDamageTaken,
            int needVisionPings,
            int neutralMinionsKilled,
            int nexusKills,
            int nexusLost,
            int nexusTakedowns,
            int objectivesStolen,
            int objectivesStolenAssists,
            int onMyWayPings,
            int participantId,
            int pentaKills,
            PerksEntity perks,
            int physicalDamageDealt,
            int physicalDamageDealtToChampions,
            int physicalDamageTaken,
            int placement,
            int playerAugment1,
            int playerAugment2,
            int playerAugment3,
            int playerAugment4,
            int playerSubteamId,
            int profileIcon,
            int pushPings,
            string puuid,
            int quadraKills,
            string riotIdGameName,
            string riotIdTagline,
            int sightWardsBoughtInGame,
            int spell1Casts,
            int spell2Casts,
            int spell3Casts,
            int spell4Casts,
            int subteamPlacement,
            int summoner1Casts,
            int summoner1Id,
            int summoner2Casts,
            int summoner2Id,
            string summonerId,
            int summonerLevel,
            string? summonerName,
            bool teamEarlySurrendered,
            int teamId,
            string teamPosition,
            int timeCCingOthers,
            int timePlayed,
            int totalAllyJungleMinionsKilled,
            int totalDamageDealt,
            int totalDamageDealtToChampions,
            int totalDamageShieldedOnTeammates,
            int totalDamageTaken,
            int totalEnemyJungleMinionsKilled,
            int totalHeal,
            int totalHealsOnTeammates,
            int totalMinionsKilled,
            int totalTimeCCDealt,
            int totalTimeSpentDead,
            int totalUnitsHealed,
            int tripleKills,
            int trueDamageDealt,
            int trueDamageDealtToChampions,
            int trueDamageTaken,
            int turretKills,
            int turretTakedowns,
            int turretsLost,
            int visionClearedPings,
            int visionScore,
            int visionWardsBoughtInGame,
            int wardsKilled,
            int wardsPlaced,
            bool win)
        {
            AllInPings = allInPings;
            AssistMePings = assistMePings;
            Assists = assists;
            BaronKills = baronKills;
            BasicPings = basicPings;
            BountyLevel = bountyLevel;
            Challenges = challenges;
            ChampExperience = champExperience;
            ChampLevel = champLevel;
            ChampionId = championId;
            ChampionName = championName;
            ChampionTransform = championTransform;
            CommandPings = commandPings;
            ConsumablesPurchased = consumablesPurchased;
            DamageDealtToBuildings = damageDealtToBuildings;
            DamageDealtToObjectives = damageDealtToObjectives;
            DamageDealtToTurrets = damageDealtToTurrets;
            DamageSelfMitigated = damageSelfMitigated;
            DangerPings = dangerPings;
            Deaths = deaths;
            DetectorWardsPlaced = detectorWardsPlaced;
            DoubleKills = doubleKills;
            EligibleForProgression = eligibleForProgression;
            EnemyMissingPings = enemyMissingPings;
            EnemyVisionPings = enemyVisionPings;
            FirstBloodAssist = firstBloodAssist;
            FirstBloodKill = firstBloodKill;
            FirstTowerAssist = firstTowerAssist;
            FirstTowerKill = firstTowerKill;
            GameEndedInEarlySurrender = gameEndedInEarlySurrender;
            GameEndedInSurrender = gameEndedInSurrender;
            GetBackPings = getBackPings;
            GoldEarned = goldEarned;
            GoldSpent = goldSpent;
            HoldPings = holdPings;
            IndividualPosition = individualPosition;
            InhibitorKills = inhibitorKills;
            InhibitorTakedowns = inhibitorTakedowns;
            InhibitorsLost = inhibitorsLost;
            Item0 = item0;
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
            ItemsPurchased = itemsPurchased;
            KillingSprees = killingSprees;
            Kills = kills;
            LargestCriticalStrike = largestCriticalStrike;
            LargestKillingSpree = largestKillingSpree;
            LargestMultiKill = largestMultiKill;
            LongestTimeSpentLiving = longestTimeSpentLiving;
            MagicDamageDealt = magicDamageDealt;
            MagicDamageDealtToChampions = magicDamageDealtToChampions;
            MagicDamageTaken = magicDamageTaken;
            NeedVisionPings = needVisionPings;
            NeutralMinionsKilled = neutralMinionsKilled;
            NexusKills = nexusKills;
            NexusLost = nexusLost;
            NexusTakedowns = nexusTakedowns;
            ObjectivesStolen = objectivesStolen;
            ObjectivesStolenAssists = objectivesStolenAssists;
            OnMyWayPings = onMyWayPings;
            ParticipantId = participantId;
            PentaKills = pentaKills;
            Perks = perks;
            PhysicalDamageDealt = physicalDamageDealt;
            PhysicalDamageDealtToChampions = physicalDamageDealtToChampions;
            PhysicalDamageTaken = physicalDamageTaken;
            Placement = placement;
            PlayerAugment1 = playerAugment1;
            PlayerAugment2 = playerAugment2;
            PlayerAugment3 = playerAugment3;
            PlayerAugment4 = playerAugment4;
            PlayerSubteamId = playerSubteamId;
            ProfileIcon = profileIcon;
            PushPings = pushPings;
            Puuid = puuid;
            QuadraKills = quadraKills;
            RiotIdGameName = riotIdGameName;
            RiotIdTagline = riotIdTagline;
            SightWardsBoughtInGame = sightWardsBoughtInGame;
            Spell1Casts = spell1Casts;
            Spell2Casts = spell2Casts;
            Spell3Casts = spell3Casts;
            Spell4Casts = spell4Casts;
            SubteamPlacement = subteamPlacement;
            Summoner1Casts = summoner1Casts;
            Summoner1Id = summoner1Id;
            Summoner2Casts = summoner2Casts;
            Summoner2Id = summoner2Id;
            SummonerId = summonerId;
            SummonerLevel = summonerLevel;
            SummonerName = summonerName;
            TeamEarlySurrendered = teamEarlySurrendered;
            TeamId = teamId;
            TeamPosition = teamPosition;
            TimeCCingOthers = timeCCingOthers;
            TimePlayed = timePlayed;
            TotalAllyJungleMinionsKilled = totalAllyJungleMinionsKilled;
            TotalDamageDealt = totalDamageDealt;
            TotalDamageDealtToChampions = totalDamageDealtToChampions;
            TotalDamageShieldedOnTeammates = totalDamageShieldedOnTeammates;
            TotalDamageTaken = totalDamageTaken;
            TotalEnemyJungleMinionsKilled = totalEnemyJungleMinionsKilled;
            TotalHeal = totalHeal;
            TotalHealsOnTeammates = totalHealsOnTeammates;
            TotalMinionsKilled = totalMinionsKilled;
            TotalTimeCCDealt = totalTimeCCDealt;
            TotalTimeSpentDead = totalTimeSpentDead;
            TotalUnitsHealed = totalUnitsHealed;
            TripleKills = tripleKills;
            TrueDamageDealt = trueDamageDealt;
            TrueDamageDealtToChampions = trueDamageDealtToChampions;
            TrueDamageTaken = trueDamageTaken;
            TurretKills = turretKills;
            TurretTakedowns = turretTakedowns;
            TurretsLost = turretsLost;
            VisionClearedPings = visionClearedPings;
            VisionScore = visionScore;
            VisionWardsBoughtInGame = visionWardsBoughtInGame;
            WardsKilled = wardsKilled;
            WardsPlaced = wardsPlaced;
            Win = win;
        }

        public int AllInPings { get; private set; }
        public int AssistMePings { get; private set; }
        public int Assists { get; private set; }
        public int BaronKills { get; private set; }
        /// <summary>
        /// Blue Pings
        /// </summary>
        public int BasicPings { get; private set; }
        /// <summary>
        /// Max Bounty Level
        /// </summary>
        public int BountyLevel { get; private set; }
        public Dictionary<string, object> Challenges { get; private set; }
        public int ChampExperience { get; private set; }
        public int ChampLevel { get; private set; }
        public int ChampionId { get; private set; }
        public string ChampionName { get; private set; }
        /// <summary>
        /// Only For Kayn's Transform
        /// </summary>
        public int ChampionTransform { get; private set; }
        public int CommandPings { get; private set; }
        public int ConsumablesPurchased { get; private set; }
        public int DamageDealtToBuildings { get; private set; }
        public int DamageDealtToObjectives { get; private set; }
        public int DamageDealtToTurrets { get; private set; }
        public int DamageSelfMitigated { get; private set; }
        public int DangerPings { get; private set; }
        public int Deaths { get; private set; }
        /// <summary>
        /// Controle Ward
        /// </summary>
        public int DetectorWardsPlaced { get; private set; }
        public int DoubleKills { get; private set; }
        public bool EligibleForProgression { get; private set; }
        public int EnemyMissingPings { get; private set; }
        public int EnemyVisionPings { get; private set; }
        public bool FirstBloodAssist { get; private set; }
        public bool FirstBloodKill { get; private set; }
        public bool FirstTowerAssist { get; private set; }
        public bool FirstTowerKill { get; private set; }
        /// <summary>
        /// Remake or Surrender pre minute 15 due to AFK
        /// </summary>
        public bool GameEndedInEarlySurrender { get; private set; }
        public bool GameEndedInSurrender { get; private set; }
        public int GetBackPings { get; private set; }
        public int GoldEarned { get; private set; }
        public int GoldSpent { get; private set; }
        public int HoldPings { get; private set; }
        /// <summary>
        /// Both individualPosition and teamPosition are computed by the game server and are different versions of the most likely position played by a player. 
        /// The individualPosition is the best guess for which position the player actually played in isolation of anything else. 
        /// The teamPosition is the best guess for which position the player actually played if we add the constraint That each team must have one top player, one jungle, one middle, etc.
        /// Generally the recommendation is to use the teamPosition field over the individualPosition field.
        /// </summary>
        public string IndividualPosition { get; private set; }
        public int InhibitorKills { get; private set; }
        public int InhibitorTakedowns { get; private set; }
        public int InhibitorsLost { get; private set; }
        public int Item0 { get; private set; }
        public int Item1 { get; private set; }
        public int Item2 { get; private set; }
        public int Item3 { get; private set; }
        public int Item4 { get; private set; }
        public int Item5 { get; private set; }
        public int Item6 { get; private set; }
        public int ItemsPurchased { get; private set; }
        public int KillingSprees { get; private set; }
        public int Kills { get; private set; }
        public int LargestCriticalStrike { get; private set; }
        public int LargestKillingSpree { get; private set; }
        public int LargestMultiKill { get; private set; }
        public int LongestTimeSpentLiving { get; private set; }
        public int MagicDamageDealt { get; private set; }
        public int MagicDamageDealtToChampions { get; private set; }
        public int MagicDamageTaken { get; private set; }
        public int NeedVisionPings { get; private set; }
        public int NeutralMinionsKilled { get; private set; }
        public int NexusKills { get; private set; }
        public int NexusLost { get; private set; }
        public int NexusTakedowns { get; private set; }
        public int ObjectivesStolen { get; private set; }
        public int ObjectivesStolenAssists { get; private set; }
        public int OnMyWayPings { get; private set; }
        public int ParticipantId { get; private set; }
        public int PentaKills { get; private set; }
        public PerksEntity Perks { get; private set; }
        public int PhysicalDamageDealt { get; private set; }
        public int PhysicalDamageDealtToChampions { get; private set; }
        public int PhysicalDamageTaken { get; private set; }
        public int Placement { get; private set; }

        /// <summary>
        /// For Arena mode
        /// </summary>
        public int PlayerAugment1 { get; private set; }
        /// <summary>
        /// For Arena mode
        /// </summary>
        public int PlayerAugment2 { get; private set; }
        /// <summary>
        /// For Arena mode
        /// </summary>
        public int PlayerAugment3 { get; private set; }
        /// <summary>
        /// For Arena mode
        /// </summary>
        public int PlayerAugment4 { get; private set; }
        /// <summary>
        /// For Arena mode
        /// </summary>
        public int PlayerSubteamId { get; private set; }

        public int ProfileIcon { get; private set; }
        public int PushPings { get; private set; }
        public string Puuid { get; private set; }
        public int QuadraKills { get; private set; }
        public string RiotIdGameName { get; private set; }
        public string RiotIdTagline { get; private set; }
        public int SightWardsBoughtInGame { get; private set; }
        public int Spell1Casts { get; private set; }
        public int Spell2Casts { get; private set; }
        public int Spell3Casts { get; private set; }
        public int Spell4Casts { get; private set; }

        /// <summary>
        /// For Arena mode
        /// </summary>
        public int SubteamPlacement { get; private set; }

        public int Summoner1Casts { get; private set; }
        public int Summoner1Id { get; private set; }
        public int Summoner2Casts { get; private set; }
        public int Summoner2Id { get; private set; }
        public string SummonerId { get; private set; }
        public int SummonerLevel { get; private set; }
        /// <summary>
        /// Old matches include.
        /// </summary>
        public string? SummonerName { get; private set; }
        /// <summary>
        /// Remake or Surrender pre minute 15 due to AFK
        /// </summary>
        public bool TeamEarlySurrendered { get; private set; }
        /// <summary>
        /// 100 = Blue, 200 = Red
        /// </summary>
        public int TeamId { get; private set; }
        /// <summary>
        /// Both individualPosition and teamPosition are computed by the game server and are different versions of the most likely position played by a player. 
        /// The individualPosition is the best guess for which position the player actually played in isolation of anything else. 
        /// The teamPosition is the best guess for which position the player actually played if we add the constraint that each team must have one top player, one jungle, one middle, etc.
        /// Generally the recommendation is to use the teamPosition field over the individualPosition field.
        /// </summary>
        public string TeamPosition { get; private set; }
        /// <summary>
        /// CC score that should account for cc mitigation
        /// </summary>
        public int TimeCCingOthers { get; private set; }
        /// <summary>
        /// If not AFK, equals game time
        /// </summary>
        public int TimePlayed { get; private set; }
        public int TotalAllyJungleMinionsKilled { get; private set; }
        public int TotalDamageDealt { get; private set; }
        public int TotalDamageDealtToChampions { get; private set; }
        public int TotalDamageShieldedOnTeammates { get; private set; }
        public int TotalDamageTaken { get; private set; }
        public int TotalEnemyJungleMinionsKilled { get; private set; }
        public int TotalHeal { get; private set; }
        public int TotalHealsOnTeammates { get; private set; }
        public int TotalMinionsKilled { get; private set; }
        /// <summary>
        ///  Pre-mitigated duration of CC
        /// </summary>
        public int TotalTimeCCDealt { get; private set; }
        public int TotalTimeSpentDead { get; private set; }
        public int TotalUnitsHealed { get; private set; }
        public int TripleKills { get; private set; }
        public int TrueDamageDealt { get; private set; }
        public int TrueDamageDealtToChampions { get; private set; }
        public int TrueDamageTaken { get; private set; }
        public int TurretKills { get; private set; }
        public int TurretTakedowns { get; private set; }
        public int TurretsLost { get; private set; }
        public int VisionClearedPings { get; private set; }
        public int VisionScore { get; private set; }
        /// <summary>
        /// Controle Ward
        /// </summary>
        public int VisionWardsBoughtInGame { get; private set; }
        public int WardsKilled { get; private set; }
        public int WardsPlaced { get; private set; }
        public bool Win { get; private set; }
    }
}
