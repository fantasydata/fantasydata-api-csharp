using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="PlayerGameBasic")]
    [Serializable]
    public partial class PlayerGameBasic
    {
        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played by the player in the game. Note: this will be one or zero for single game feeds
        /// </summary>
        [Description("The number of games played by the player in the game. Note: this will be one or zero for single game feeds")]
        [DataMember(Name = "Games", Order = 2)]
        public int? Games { get; set; }

        /// <summary>
        /// Total minutes played by the player in the game
        /// </summary>
        [Description("Total minutes played by the player in the game")]
        [DataMember(Name = "Minutes", Order = 3)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total seconds played by the player in the game
        /// </summary>
        [Description("Total seconds played by the player in the game")]
        [DataMember(Name = "Seconds", Order = 4)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total field goals made by the player in the game
        /// </summary>
        [Description("Total field goals made by the player in the game")]
        [DataMember(Name = "FieldGoalsMade", Order = 5)]
        public decimal? FieldGoalsMade { get; set; }

        /// <summary>
        /// Total field goals attempted by the player in the game
        /// </summary>
        [Description("Total field goals attempted by the player in the game")]
        [DataMember(Name = "FieldGoalsAttempted", Order = 6)]
        public decimal? FieldGoalsAttempted { get; set; }

        /// <summary>
        /// Total field goal percentage (FG%) by the player in the game
        /// </summary>
        [Description("Total field goal percentage (FG%) by the player in the game")]
        [DataMember(Name = "FieldGoalsPercentage", Order = 7)]
        public decimal? FieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total effective field goals percentage (eFG%) by the player in the game
        /// </summary>
        [Description("Total effective field goals percentage (eFG%) by the player in the game")]
        [DataMember(Name = "EffectiveFieldGoalsPercentage", Order = 8)]
        public decimal? EffectiveFieldGoalsPercentage { get; set; }

        /// <summary>
        /// Total two pointers made by the player in the game
        /// </summary>
        [Description("Total two pointers made by the player in the game")]
        [DataMember(Name = "TwoPointersMade", Order = 9)]
        public decimal? TwoPointersMade { get; set; }

        /// <summary>
        /// Total two pointers attempted by the player in the game
        /// </summary>
        [Description("Total two pointers attempted by the player in the game")]
        [DataMember(Name = "TwoPointersAttempted", Order = 10)]
        public decimal? TwoPointersAttempted { get; set; }

        /// <summary>
        /// Total two point percentage by the player in the game
        /// </summary>
        [Description("Total two point percentage by the player in the game")]
        [DataMember(Name = "TwoPointersPercentage", Order = 11)]
        public decimal? TwoPointersPercentage { get; set; }

        /// <summary>
        /// Total three pointers made by the player in the game
        /// </summary>
        [Description("Total three pointers made by the player in the game")]
        [DataMember(Name = "ThreePointersMade", Order = 12)]
        public decimal? ThreePointersMade { get; set; }

        /// <summary>
        /// Total three pointers attempted by the player in the game
        /// </summary>
        [Description("Total three pointers attempted by the player in the game")]
        [DataMember(Name = "ThreePointersAttempted", Order = 13)]
        public decimal? ThreePointersAttempted { get; set; }

        /// <summary>
        /// Total three point percentage (3P%) by the player in the game
        /// </summary>
        [Description("Total three point percentage (3P%) by the player in the game")]
        [DataMember(Name = "ThreePointersPercentage", Order = 14)]
        public decimal? ThreePointersPercentage { get; set; }

        /// <summary>
        /// Total free throws made by the player in the game
        /// </summary>
        [Description("Total free throws made by the player in the game")]
        [DataMember(Name = "FreeThrowsMade", Order = 15)]
        public decimal? FreeThrowsMade { get; set; }

        /// <summary>
        /// Total free throws attempted by the player in the game
        /// </summary>
        [Description("Total free throws attempted by the player in the game")]
        [DataMember(Name = "FreeThrowsAttempted", Order = 16)]
        public decimal? FreeThrowsAttempted { get; set; }

        /// <summary>
        /// Total free throw percentage by the player in the game
        /// </summary>
        [Description("Total free throw percentage by the player in the game")]
        [DataMember(Name = "FreeThrowsPercentage", Order = 17)]
        public decimal? FreeThrowsPercentage { get; set; }

        /// <summary>
        /// Total offensive rebounds by the player in the game
        /// </summary>
        [Description("Total offensive rebounds by the player in the game")]
        [DataMember(Name = "OffensiveRebounds", Order = 18)]
        public decimal? OffensiveRebounds { get; set; }

        /// <summary>
        /// Total defensive rebounds by the player in the game
        /// </summary>
        [Description("Total defensive rebounds by the player in the game")]
        [DataMember(Name = "DefensiveRebounds", Order = 19)]
        public decimal? DefensiveRebounds { get; set; }

        /// <summary>
        /// Total rebounds by the player in the game (offensive and defensive rebounds)
        /// </summary>
        [Description("Total rebounds by the player in the game (offensive and defensive rebounds)")]
        [DataMember(Name = "Rebounds", Order = 20)]
        public decimal? Rebounds { get; set; }

        /// <summary>
        /// Total offensive rebound percentage (ORB%) by the player in the game
        /// </summary>
        [Description("Total offensive rebound percentage (ORB%) by the player in the game")]
        [DataMember(Name = "OffensiveReboundsPercentage", Order = 21)]
        public decimal? OffensiveReboundsPercentage { get; set; }

        /// <summary>
        /// Total defensive rebound percentage (DRB%) by the player in the game
        /// </summary>
        [Description("Total defensive rebound percentage (DRB%) by the player in the game")]
        [DataMember(Name = "DefensiveReboundsPercentage", Order = 22)]
        public decimal? DefensiveReboundsPercentage { get; set; }

        /// <summary>
        /// Total rebound percentage (TRB%) by the player in the game
        /// </summary>
        [Description("Total rebound percentage (TRB%) by the player in the game")]
        [DataMember(Name = "TotalReboundsPercentage", Order = 23)]
        public decimal? TotalReboundsPercentage { get; set; }

        /// <summary>
        /// Total assists by the player in the game
        /// </summary>
        [Description("Total assists by the player in the game")]
        [DataMember(Name = "Assists", Order = 24)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total steals by the player in the game
        /// </summary>
        [Description("Total steals by the player in the game")]
        [DataMember(Name = "Steals", Order = 25)]
        public decimal? Steals { get; set; }

        /// <summary>
        /// Total blocked shots by the player in the game
        /// </summary>
        [Description("Total blocked shots by the player in the game")]
        [DataMember(Name = "BlockedShots", Order = 26)]
        public decimal? BlockedShots { get; set; }

        /// <summary>
        /// Total turnovers by the player in the game
        /// </summary>
        [Description("Total turnovers by the player in the game")]
        [DataMember(Name = "Turnovers", Order = 27)]
        public decimal? Turnovers { get; set; }

        /// <summary>
        /// Total personal fouls by the player in the game
        /// </summary>
        [Description("Total personal fouls by the player in the game")]
        [DataMember(Name = "PersonalFouls", Order = 28)]
        public decimal? PersonalFouls { get; set; }

        /// <summary>
        /// Total points scored by the player in the game
        /// </summary>
        [Description("Total points scored by the player in the game")]
        [DataMember(Name = "Points", Order = 29)]
        public decimal? Points { get; set; }

        /// <summary>
        /// Total true shooting attempts (TSA) by the player in the game
        /// </summary>
        [Description("Total true shooting attempts (TSA) by the player in the game")]
        [DataMember(Name = "TrueShootingAttempts", Order = 30)]
        public decimal? TrueShootingAttempts { get; set; }

        /// <summary>
        /// Total true shooting percentage (TS%) by the player in the game
        /// </summary>
        [Description("Total true shooting percentage (TS%) by the player in the game")]
        [DataMember(Name = "TrueShootingPercentage", Order = 31)]
        public decimal? TrueShootingPercentage { get; set; }

        /// <summary>
        /// The player's linear weight efficiency rating (PER) in the game
        /// </summary>
        [Description("The player's linear weight efficiency rating (PER) in the game")]
        [DataMember(Name = "PlayerEfficiencyRating", Order = 32)]
        public decimal? PlayerEfficiencyRating { get; set; }

        /// <summary>
        /// Total assist percentage (AST%) by the player in the game
        /// </summary>
        [Description("Total assist percentage (AST%) by the player in the game")]
        [DataMember(Name = "AssistsPercentage", Order = 33)]
        public decimal? AssistsPercentage { get; set; }

        /// <summary>
        /// Total steal percentage (STL%) by the player in the game
        /// </summary>
        [Description("Total steal percentage (STL%) by the player in the game")]
        [DataMember(Name = "StealsPercentage", Order = 34)]
        public decimal? StealsPercentage { get; set; }

        /// <summary>
        /// Total block percentage (BLK%) by the player in the game
        /// </summary>
        [Description("Total block percentage (BLK%) by the player in the game")]
        [DataMember(Name = "BlocksPercentage", Order = 35)]
        public decimal? BlocksPercentage { get; set; }

        /// <summary>
        /// Total turnover percentage (TOV%) by the player in the game
        /// </summary>
        [Description("Total turnover percentage (TOV%) by the player in the game")]
        [DataMember(Name = "TurnOversPercentage", Order = 36)]
        public decimal? TurnOversPercentage { get; set; }

        /// <summary>
        /// Total usage rate percentage by the player in the game
        /// </summary>
        [Description("Total usage rate percentage by the player in the game")]
        [DataMember(Name = "UsageRatePercentage", Order = 37)]
        public decimal? UsageRatePercentage { get; set; }

        /// <summary>
        /// Total plus minus by the player in the game
        /// </summary>
        [Description("Total plus minus by the player in the game")]
        [DataMember(Name = "PlusMinus", Order = 38)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total double-doubles by the player in the game. Note: player can record maximum of 1 double double in a single game
        /// </summary>
        [Description("Total double-doubles by the player in the game. Note: player can record maximum of 1 double double in a single game")]
        [DataMember(Name = "DoubleDoubles", Order = 39)]
        public decimal? DoubleDoubles { get; set; }

        /// <summary>
        /// Total triple-doubles by the player in the game. Note: player can record maximum of 1 double double in a single game
        /// </summary>
        [Description("Total triple-doubles by the player in the game. Note: player can record maximum of 1 double double in a single game")]
        [DataMember(Name = "TripleDoubles", Order = 40)]
        public decimal? TripleDoubles { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the stats for this player have been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the stats for this player have been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 41)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Indicates whether starting lineup is confirmed. Note: This field will be NULL when not referencing players
        /// </summary>
        [Description("Indicates whether starting lineup is confirmed. Note: This field will be NULL when not referencing players")]
        [DataMember(Name = "LineupConfirmed", Order = 42)]
        public bool? LineupConfirmed { get; set; }

        /// <summary>
        /// Indicates whether player is starting, active, or inactive
        /// </summary>
        [Description("Indicates whether player is starting, active, or inactive")]
        [DataMember(Name = "LineupStatus", Order = 43)]
        public string LineupStatus { get; set; }

        /// <summary>
        /// The unique ID of the game associated with this PlayerGame record
        /// </summary>
        [Description("The unique ID of the game associated with this PlayerGame record")]
        [DataMember(Name = "GameID", Order = 44)]
        public int? GameID { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentID", Order = 45)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// Abbreviation [Key] of the opponent team (e.g. LAL; PHI; BOS; CHI; etc.)
        /// </summary>
        [Description("Abbreviation [Key] of the opponent team (e.g. LAL; PHI; BOS; CHI; etc.)")]
        [DataMember(Name = "Opponent", Order = 46)]
        public string Opponent { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 47)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 48)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 49)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over
        /// </summary>
        [Description("Whether the game is over")]
        [DataMember(Name = "IsGameOver", Order = 50)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 51)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 52)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 53)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 54)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 55)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 56)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NBA season of the game
        /// </summary>
        [Description("The NBA season of the game")]
        [DataMember(Name = "Season", Order = 57)]
        public int? Season { get; set; }

        /// <summary>
        /// The name of the player
        /// </summary>
        [Description("The name of the player")]
        [DataMember(Name = "Name", Order = 58)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the player's team
        /// </summary>
        [Description("The abbreviation [Key] of the player's team")]
        [DataMember(Name = "Team", Order = 59)]
        public string Team { get; set; }

        /// <summary>
        /// The player's position associated with the given game or season. Possible values: C, F, FC, G, GF, PF, PG, SF, SG
        /// </summary>
        [Description("The player's position associated with the given game or season. Possible values: C, F, FC, G, GF, PF, PG, SF, SG")]
        [DataMember(Name = "Position", Order = 60)]
        public string Position { get; set; }

        /// <summary>
        /// Indicates whether or not the player started the game. Note: this will be one or zero for single game feeds
        /// </summary>
        [Description("Indicates whether or not the player started the game. Note: this will be one or zero for single game feeds")]
        [DataMember(Name = "Started", Order = 61)]
        public int? Started { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 62)]
        public int? GlobalTeamID { get; set; }

    }
}

