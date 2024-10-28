using RiotApiWrapper.Entities.Match.Participant;

namespace RiotApiWrapper.Entities.Match
{
    public class Participant2Entity
    {
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

        public List<ChallengeEntity> Challenges { get; private set; }
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
        public bool GameEndedInEarlySurrender { get; private set; }
        public bool GameEndedInSurrender { get; private set; }



    }
}
