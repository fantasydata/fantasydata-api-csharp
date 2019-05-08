using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="PlayerSeasonProjection")]
    [Serializable]
    public partial class PlayerSeasonProjection
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NHL regular season for which these totals apply
        /// </summary>
        [Description("The NHL regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// Player's position in the starting lineup (if started), otherwise the position he substituted for
        /// </summary>
        [Description("Player's position in the starting lineup (if started), otherwise the position he substituted for")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 9)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 11)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 12)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total FanDuel daily fantasy points scored
        /// </summary>
        [Description("Total FanDuel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 13)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings daily fantasy points scored
        /// </summary>
        [Description("Total DraftKings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 14)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 15)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 16)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 17)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of goals scored
        /// </summary>
        [Description("Total number of goals scored")]
        [DataMember(Name = "Goals", Order = 18)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total number of assists
        /// </summary>
        [Description("Total number of assists")]
        [DataMember(Name = "Assists", Order = 19)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total number of shots on goal
        /// </summary>
        [Description("Total number of shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 20)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total number of power play goals
        /// </summary>
        [Description("Total number of power play goals")]
        [DataMember(Name = "PowerPlayGoals", Order = 21)]
        public decimal? PowerPlayGoals { get; set; }

        /// <summary>
        /// Total number of short handed goals
        /// </summary>
        [Description("Total number of short handed goals")]
        [DataMember(Name = "ShortHandedGoals", Order = 22)]
        public decimal? ShortHandedGoals { get; set; }

        /// <summary>
        /// Total number of empty net goals
        /// </summary>
        [Description("Total number of empty net goals")]
        [DataMember(Name = "EmptyNetGoals", Order = 23)]
        public decimal? EmptyNetGoals { get; set; }

        /// <summary>
        /// Total number of power play assists
        /// </summary>
        [Description("Total number of power play assists")]
        [DataMember(Name = "PowerPlayAssists", Order = 24)]
        public decimal? PowerPlayAssists { get; set; }

        /// <summary>
        /// Total number of short handed assists
        /// </summary>
        [Description("Total number of short handed assists")]
        [DataMember(Name = "ShortHandedAssists", Order = 25)]
        public decimal? ShortHandedAssists { get; set; }

        /// <summary>
        /// Total number of hat tricks
        /// </summary>
        [Description("Total number of hat tricks")]
        [DataMember(Name = "HatTricks", Order = 26)]
        public decimal? HatTricks { get; set; }

        /// <summary>
        /// Total number of shootout goals
        /// </summary>
        [Description("Total number of shootout goals")]
        [DataMember(Name = "ShootoutGoals", Order = 27)]
        public decimal? ShootoutGoals { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 28)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total pentalty minutes
        /// </summary>
        [Description("Total pentalty minutes")]
        [DataMember(Name = "PenaltyMinutes", Order = 29)]
        public decimal? PenaltyMinutes { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "Blocks", Order = 30)]
        public decimal? Blocks { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 31)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total takeaways
        /// </summary>
        [Description("Total takeaways")]
        [DataMember(Name = "Takeaways", Order = 32)]
        public decimal? Takeaways { get; set; }

        /// <summary>
        /// Total giveaways
        /// </summary>
        [Description("Total giveaways")]
        [DataMember(Name = "Giveaways", Order = 33)]
        public decimal? Giveaways { get; set; }

        /// <summary>
        /// Total faceoffs won
        /// </summary>
        [Description("Total faceoffs won")]
        [DataMember(Name = "FaceoffsWon", Order = 34)]
        public decimal? FaceoffsWon { get; set; }

        /// <summary>
        /// Total faceoffs lost
        /// </summary>
        [Description("Total faceoffs lost")]
        [DataMember(Name = "FaceoffsLost", Order = 35)]
        public decimal? FaceoffsLost { get; set; }

        /// <summary>
        /// Total shifts
        /// </summary>
        [Description("Total shifts")]
        [DataMember(Name = "Shifts", Order = 36)]
        public decimal? Shifts { get; set; }

        /// <summary>
        /// Total goaltending minutes
        /// </summary>
        [Description("Total goaltending minutes")]
        [DataMember(Name = "GoaltendingMinutes", Order = 37)]
        public int? GoaltendingMinutes { get; set; }

        /// <summary>
        /// Total goaltending seconds
        /// </summary>
        [Description("Total goaltending seconds")]
        [DataMember(Name = "GoaltendingSeconds", Order = 38)]
        public int? GoaltendingSeconds { get; set; }

        /// <summary>
        /// Total goaltending shots against
        /// </summary>
        [Description("Total goaltending shots against")]
        [DataMember(Name = "GoaltendingShotsAgainst", Order = 39)]
        public decimal? GoaltendingShotsAgainst { get; set; }

        /// <summary>
        /// Total goaltending goals against
        /// </summary>
        [Description("Total goaltending goals against")]
        [DataMember(Name = "GoaltendingGoalsAgainst", Order = 40)]
        public decimal? GoaltendingGoalsAgainst { get; set; }

        /// <summary>
        /// Total goaltending saves
        /// </summary>
        [Description("Total goaltending saves")]
        [DataMember(Name = "GoaltendingSaves", Order = 41)]
        public decimal? GoaltendingSaves { get; set; }

        /// <summary>
        /// Total goaltending wins
        /// </summary>
        [Description("Total goaltending wins")]
        [DataMember(Name = "GoaltendingWins", Order = 42)]
        public decimal? GoaltendingWins { get; set; }

        /// <summary>
        /// Total goaltendings losses
        /// </summary>
        [Description("Total goaltendings losses")]
        [DataMember(Name = "GoaltendingLosses", Order = 43)]
        public decimal? GoaltendingLosses { get; set; }

        /// <summary>
        /// Total goaltendings shutouts
        /// </summary>
        [Description("Total goaltendings shutouts")]
        [DataMember(Name = "GoaltendingShutouts", Order = 44)]
        public decimal? GoaltendingShutouts { get; set; }

        /// <summary>
        /// Total games started
        /// </summary>
        [Description("Total games started")]
        [DataMember(Name = "Started", Order = 45)]
        public int? Started { get; set; }

        /// <summary>
        /// Total bench pentalty minutes
        /// </summary>
        [Description("Total bench pentalty minutes")]
        [DataMember(Name = "BenchPenaltyMinutes", Order = 46)]
        public decimal? BenchPenaltyMinutes { get; set; }

        /// <summary>
        /// Total goaltending overtime losses
        /// </summary>
        [Description("Total goaltending overtime losses")]
        [DataMember(Name = "GoaltendingOvertimeLosses", Order = 47)]
        public decimal? GoaltendingOvertimeLosses { get; set; }

        /// <summary>
        /// Total FantasyDraft daily fantasy points scored
        /// </summary>
        [Description("Total FantasyDraft daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 48)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

    }
}

