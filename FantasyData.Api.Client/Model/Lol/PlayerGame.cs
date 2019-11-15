using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="PlayerGame")]
    [Serializable]
    public partial class PlayerGame
    {
        /// <summary>
        /// The Unique ID of the Game
        /// </summary>
        [Description("The Unique ID of the Game")]
        [DataMember(Name = "GameId", Order = 1)]
        public int GameId { get; set; }

        /// <summary>
        /// The Unique ID of the opposing team
        /// </summary>
        [Description("The Unique ID of the opposing team")]
        [DataMember(Name = "OpponentId", Order = 2)]
        public int OpponentId { get; set; }

        /// <summary>
        /// The team key of the opposing team
        /// </summary>
        [Description("The team key of the opposing team")]
        [DataMember(Name = "Opponent", Order = 3)]
        public string Opponent { get; set; }

        /// <summary>
        /// The date of the event
        /// </summary>
        [Description("The date of the event")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the event
        /// </summary>
        [Description("The date and time of the event")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The Unique Id of the player
        /// </summary>
        [Description("The Unique Id of the player")]
        [DataMember(Name = "PlayerId", Order = 6)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The unique Id of the team the player played for this match
        /// </summary>
        [Description("The unique Id of the team the player played for this match")]
        [DataMember(Name = "TeamId", Order = 7)]
        public int? TeamId { get; set; }

        /// <summary>
        /// The team key of the team the player played for this match
        /// </summary>
        [Description("The team key of the team the player played for this match")]
        [DataMember(Name = "Team", Order = 8)]
        public string Team { get; set; }

        /// <summary>
        /// The player's name
        /// </summary>
        [Description("The player's name")]
        [DataMember(Name = "Name", Order = 9)]
        public string Name { get; set; }

        /// <summary>
        /// The player's match name.
        /// </summary>
        [Description("The player's match name.")]
        [DataMember(Name = "MatchName", Order = 10)]
        public string MatchName { get; set; }

        /// <summary>
        /// The total number of Kills by the player
        /// </summary>
        [Description("The total number of Kills by the player")]
        [DataMember(Name = "Kills", Order = 11)]
        public decimal? Kills { get; set; }

        /// <summary>
        /// The total number of Assists by the player
        /// </summary>
        [Description("The total number of Assists by the player")]
        [DataMember(Name = "Assists", Order = 12)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// The total number of Deaths by the player
        /// </summary>
        [Description("The total number of Deaths by the player")]
        [DataMember(Name = "Deaths", Order = 13)]
        public decimal? Deaths { get; set; }

        /// <summary>
        /// The longest killing spree achieved by the player
        /// </summary>
        [Description("The longest killing spree achieved by the player")]
        [DataMember(Name = "LargestKillingSpree", Order = 14)]
        public decimal? LargestKillingSpree { get; set; }

        /// <summary>
        /// The largest multikill achieved by the player
        /// </summary>
        [Description("The largest multikill achieved by the player")]
        [DataMember(Name = "LargestMultiKill", Order = 15)]
        public decimal? LargestMultiKill { get; set; }

        /// <summary>
        /// The current killing spree the player is on by the player
        /// </summary>
        [Description("The current killing spree the player is on by the player")]
        [DataMember(Name = "KillingSpree", Order = 16)]
        public decimal? KillingSpree { get; set; }

        /// <summary>
        /// The longest time spent alive by the player
        /// </summary>
        [Description("The longest time spent alive by the player")]
        [DataMember(Name = "LongestTimeSpentLiving", Order = 17)]
        public decimal? LongestTimeSpentLiving { get; set; }

        /// <summary>
        /// The total number of Double Kills by the player
        /// </summary>
        [Description("The total number of Double Kills by the player")]
        [DataMember(Name = "DoubleKills", Order = 18)]
        public decimal? DoubleKills { get; set; }

        /// <summary>
        /// The total number of Triple Kills by the player
        /// </summary>
        [Description("The total number of Triple Kills by the player")]
        [DataMember(Name = "TripleKills", Order = 19)]
        public decimal? TripleKills { get; set; }

        /// <summary>
        /// The total number of Quadra Kills by the player
        /// </summary>
        [Description("The total number of Quadra Kills by the player")]
        [DataMember(Name = "QuadraKills", Order = 20)]
        public decimal? QuadraKills { get; set; }

        /// <summary>
        /// The total number of Penta Kills by the player
        /// </summary>
        [Description("The total number of Penta Kills by the player")]
        [DataMember(Name = "PentaKills", Order = 21)]
        public decimal? PentaKills { get; set; }

        /// <summary>
        /// The total number of Unreal Kills by the player
        /// </summary>
        [Description("The total number of Unreal Kills by the player")]
        [DataMember(Name = "UnrealKills", Order = 22)]
        public decimal? UnrealKills { get; set; }

        /// <summary>
        /// The total damage dealt  by the player
        /// </summary>
        [Description("The total damage dealt  by the player")]
        [DataMember(Name = "TotalDamageDealt", Order = 23)]
        public decimal? TotalDamageDealt { get; set; }

        /// <summary>
        /// The total magical damage dealt  by the player
        /// </summary>
        [Description("The total magical damage dealt  by the player")]
        [DataMember(Name = "MagicDamageDealt", Order = 24)]
        public decimal? MagicDamageDealt { get; set; }

        /// <summary>
        /// The total physical damage dealt  by the player
        /// </summary>
        [Description("The total physical damage dealt  by the player")]
        [DataMember(Name = "PhysicalDamageDealt", Order = 25)]
        public decimal? PhysicalDamageDealt { get; set; }

        /// <summary>
        /// The total true damage dealt  by the player
        /// </summary>
        [Description("The total true damage dealt  by the player")]
        [DataMember(Name = "TrueDamageDealt", Order = 26)]
        public decimal? TrueDamageDealt { get; set; }

        /// <summary>
        /// The largest single critical strike damage by the player
        /// </summary>
        [Description("The largest single critical strike damage by the player")]
        [DataMember(Name = "LargestCriticalStrike", Order = 27)]
        public decimal? LargestCriticalStrike { get; set; }

        /// <summary>
        /// The total damage dealt to opposing champions by the player
        /// </summary>
        [Description("The total damage dealt to opposing champions by the player")]
        [DataMember(Name = "TotalDamageDealtToChampions", Order = 28)]
        public decimal? TotalDamageDealtToChampions { get; set; }

        /// <summary>
        /// The total magical damage dealt to opposing champions by the player
        /// </summary>
        [Description("The total magical damage dealt to opposing champions by the player")]
        [DataMember(Name = "MagicDamageDealtToChampions", Order = 29)]
        public decimal? MagicDamageDealtToChampions { get; set; }

        /// <summary>
        /// The total physical damage dealt to opposing champions by the player
        /// </summary>
        [Description("The total physical damage dealt to opposing champions by the player")]
        [DataMember(Name = "PhysicalDamageDealtToChampions", Order = 30)]
        public decimal? PhysicalDamageDealtToChampions { get; set; }

        /// <summary>
        /// The total true damage dealt to opposing champions by the player
        /// </summary>
        [Description("The total true damage dealt to opposing champions by the player")]
        [DataMember(Name = "TrueDamageDealtToChampions", Order = 31)]
        public decimal? TrueDamageDealtToChampions { get; set; }

        /// <summary>
        /// The total amount of heal by the player
        /// </summary>
        [Description("The total amount of heal by the player")]
        [DataMember(Name = "TotalHeal", Order = 32)]
        public decimal? TotalHeal { get; set; }

        /// <summary>
        /// The total number of units healed by the player
        /// </summary>
        [Description("The total number of units healed by the player")]
        [DataMember(Name = "TotalUnitsHealed", Order = 33)]
        public decimal? TotalUnitsHealed { get; set; }

        /// <summary>
        /// The total amount of damage taken by the player
        /// </summary>
        [Description("The total amount of damage taken by the player")]
        [DataMember(Name = "TotalDamageTaken", Order = 34)]
        public decimal? TotalDamageTaken { get; set; }

        /// <summary>
        /// The total amount of magical damage taken by the player
        /// </summary>
        [Description("The total amount of magical damage taken by the player")]
        [DataMember(Name = "MagicDamageTaken", Order = 35)]
        public decimal? MagicDamageTaken { get; set; }

        /// <summary>
        /// The total amount of physical damage taken by the player
        /// </summary>
        [Description("The total amount of physical damage taken by the player")]
        [DataMember(Name = "PhysicalDamageTaken", Order = 36)]
        public decimal? PhysicalDamageTaken { get; set; }

        /// <summary>
        /// The total amount of true damage taken by the player
        /// </summary>
        [Description("The total amount of true damage taken by the player")]
        [DataMember(Name = "TrueDamageTaken", Order = 37)]
        public decimal? TrueDamageTaken { get; set; }

        /// <summary>
        /// The total gold earned by the player
        /// </summary>
        [Description("The total gold earned by the player")]
        [DataMember(Name = "GoldEarned", Order = 38)]
        public decimal? GoldEarned { get; set; }

        /// <summary>
        /// The total gold spent by the player
        /// </summary>
        [Description("The total gold spent by the player")]
        [DataMember(Name = "GoldSpent", Order = 39)]
        public decimal? GoldSpent { get; set; }

        /// <summary>
        /// The total number of turrets killed by the player
        /// </summary>
        [Description("The total number of turrets killed by the player")]
        [DataMember(Name = "TurretKills", Order = 40)]
        public decimal? TurretKills { get; set; }

        /// <summary>
        /// The total number of inhibitors killed by the player
        /// </summary>
        [Description("The total number of inhibitors killed by the player")]
        [DataMember(Name = "InhibitorKills", Order = 41)]
        public decimal? InhibitorKills { get; set; }

        /// <summary>
        /// The total number of minions killed by the player
        /// </summary>
        [Description("The total number of minions killed by the player")]
        [DataMember(Name = "TotalMinionsKilled", Order = 42)]
        public decimal? TotalMinionsKilled { get; set; }

        /// <summary>
        /// The total number of neutral minions killed by the player
        /// </summary>
        [Description("The total number of neutral minions killed by the player")]
        [DataMember(Name = "NeutralMinionsKIlled", Order = 43)]
        public decimal? NeutralMinionsKIlled { get; set; }

        /// <summary>
        /// The total number of neutral minions killed by the player in their own jungle
        /// </summary>
        [Description("The total number of neutral minions killed by the player in their own jungle")]
        [DataMember(Name = "NeutralMinionsKIlledTeamJungle", Order = 44)]
        public decimal? NeutralMinionsKIlledTeamJungle { get; set; }

        /// <summary>
        /// The total number of neutral minions killed by the player in the enemy jungle
        /// </summary>
        [Description("The total number of neutral minions killed by the player in the enemy jungle")]
        [DataMember(Name = "NeutralMinionsKilledEnemyJungle", Order = 45)]
        public decimal? NeutralMinionsKilledEnemyJungle { get; set; }

        /// <summary>
        /// The total time enemies were crowd controlled by the player
        /// </summary>
        [Description("The total time enemies were crowd controlled by the player")]
        [DataMember(Name = "TotalTimeCrowdControlDealt", Order = 46)]
        public decimal? TotalTimeCrowdControlDealt { get; set; }

        /// <summary>
        /// The total number of vision wards bought by the player
        /// </summary>
        [Description("The total number of vision wards bought by the player")]
        [DataMember(Name = "VisionWardsBoughtInGame", Order = 47)]
        public decimal? VisionWardsBoughtInGame { get; set; }

        /// <summary>
        /// The total number of sight wards bought by the player
        /// </summary>
        [Description("The total number of sight wards bought by the player")]
        [DataMember(Name = "SightWardsBoughtInGame", Order = 48)]
        public decimal? SightWardsBoughtInGame { get; set; }

        /// <summary>
        /// The total number of wards placed by the player
        /// </summary>
        [Description("The total number of wards placed by the player")]
        [DataMember(Name = "WardsPlaced", Order = 49)]
        public decimal? WardsPlaced { get; set; }

        /// <summary>
        /// The total number of wards killed by the player
        /// </summary>
        [Description("The total number of wards killed by the player")]
        [DataMember(Name = "WardsKilled", Order = 50)]
        public decimal? WardsKilled { get; set; }

        /// <summary>
        /// The player's combat player score
        /// </summary>
        [Description("The player's combat player score")]
        [DataMember(Name = "CombatPlayerScore", Order = 51)]
        public decimal? CombatPlayerScore { get; set; }

        /// <summary>
        /// The player's objective player score
        /// </summary>
        [Description("The player's objective player score")]
        [DataMember(Name = "ObjectivePlayerScore", Order = 52)]
        public decimal? ObjectivePlayerScore { get; set; }

        /// <summary>
        /// The player's total player score
        /// </summary>
        [Description("The player's total player score")]
        [DataMember(Name = "TotalPlayerScore", Order = 53)]
        public decimal? TotalPlayerScore { get; set; }

        /// <summary>
        /// Did player reach either 10 kills or 10 assists in a single match
        /// </summary>
        [Description("Did player reach either 10 kills or 10 assists in a single match")]
        [DataMember(Name = "TenKillsOrAssists", Order = 54)]
        public decimal? TenKillsOrAssists { get; set; }

        /// <summary>
        /// The last update time of the record
        /// </summary>
        [Description("The last update time of the record")]
        [DataMember(Name = "Updated", Order = 55)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 56)]
        public int Games { get; set; }

        /// <summary>
        /// The number of matches played
        /// </summary>
        [Description("The number of matches played")]
        [DataMember(Name = "Matches", Order = 57)]
        public int Matches { get; set; }

    }
}

