using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="PlayerGameBasic")]
    [Serializable]
    public partial class PlayerGameBasic
    {
        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 2)]
        public int? Games { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 3)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 4)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of goals scored
        /// </summary>
        [Description("Total number of goals scored")]
        [DataMember(Name = "Goals", Order = 5)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total number of assists
        /// </summary>
        [Description("Total number of assists")]
        [DataMember(Name = "Assists", Order = 6)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total number of shots on goal
        /// </summary>
        [Description("Total number of shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 7)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total number of power play goals
        /// </summary>
        [Description("Total number of power play goals")]
        [DataMember(Name = "PowerPlayGoals", Order = 8)]
        public decimal? PowerPlayGoals { get; set; }

        /// <summary>
        /// Total number of short handed goals
        /// </summary>
        [Description("Total number of short handed goals")]
        [DataMember(Name = "ShortHandedGoals", Order = 9)]
        public decimal? ShortHandedGoals { get; set; }

        /// <summary>
        /// Total number of empty net goals
        /// </summary>
        [Description("Total number of empty net goals")]
        [DataMember(Name = "EmptyNetGoals", Order = 10)]
        public decimal? EmptyNetGoals { get; set; }

        /// <summary>
        /// Total number of power play assists
        /// </summary>
        [Description("Total number of power play assists")]
        [DataMember(Name = "PowerPlayAssists", Order = 11)]
        public decimal? PowerPlayAssists { get; set; }

        /// <summary>
        /// Total number of short handed assists
        /// </summary>
        [Description("Total number of short handed assists")]
        [DataMember(Name = "ShortHandedAssists", Order = 12)]
        public decimal? ShortHandedAssists { get; set; }

        /// <summary>
        /// Total number of hat tricks
        /// </summary>
        [Description("Total number of hat tricks")]
        [DataMember(Name = "HatTricks", Order = 13)]
        public decimal? HatTricks { get; set; }

        /// <summary>
        /// Total number of shootout goals
        /// </summary>
        [Description("Total number of shootout goals")]
        [DataMember(Name = "ShootoutGoals", Order = 14)]
        public decimal? ShootoutGoals { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 15)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total pentalty minutes
        /// </summary>
        [Description("Total pentalty minutes")]
        [DataMember(Name = "PenaltyMinutes", Order = 16)]
        public decimal? PenaltyMinutes { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "Blocks", Order = 17)]
        public decimal? Blocks { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 18)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total takeaways
        /// </summary>
        [Description("Total takeaways")]
        [DataMember(Name = "Takeaways", Order = 19)]
        public decimal? Takeaways { get; set; }

        /// <summary>
        /// Total giveaways
        /// </summary>
        [Description("Total giveaways")]
        [DataMember(Name = "Giveaways", Order = 20)]
        public decimal? Giveaways { get; set; }

        /// <summary>
        /// Total faceoffs won
        /// </summary>
        [Description("Total faceoffs won")]
        [DataMember(Name = "FaceoffsWon", Order = 21)]
        public decimal? FaceoffsWon { get; set; }

        /// <summary>
        /// Total faceoffs lost
        /// </summary>
        [Description("Total faceoffs lost")]
        [DataMember(Name = "FaceoffsLost", Order = 22)]
        public decimal? FaceoffsLost { get; set; }

        /// <summary>
        /// Total shifts
        /// </summary>
        [Description("Total shifts")]
        [DataMember(Name = "Shifts", Order = 23)]
        public decimal? Shifts { get; set; }

        /// <summary>
        /// Total goaltending minutes
        /// </summary>
        [Description("Total goaltending minutes")]
        [DataMember(Name = "GoaltendingMinutes", Order = 24)]
        public int? GoaltendingMinutes { get; set; }

        /// <summary>
        /// Total goaltending seconds
        /// </summary>
        [Description("Total goaltending seconds")]
        [DataMember(Name = "GoaltendingSeconds", Order = 25)]
        public int? GoaltendingSeconds { get; set; }

        /// <summary>
        /// Total goaltending shots against
        /// </summary>
        [Description("Total goaltending shots against")]
        [DataMember(Name = "GoaltendingShotsAgainst", Order = 26)]
        public decimal? GoaltendingShotsAgainst { get; set; }

        /// <summary>
        /// Total goaltending goals against
        /// </summary>
        [Description("Total goaltending goals against")]
        [DataMember(Name = "GoaltendingGoalsAgainst", Order = 27)]
        public decimal? GoaltendingGoalsAgainst { get; set; }

        /// <summary>
        /// Total goaltending saves
        /// </summary>
        [Description("Total goaltending saves")]
        [DataMember(Name = "GoaltendingSaves", Order = 28)]
        public decimal? GoaltendingSaves { get; set; }

        /// <summary>
        /// Total goaltending wins
        /// </summary>
        [Description("Total goaltending wins")]
        [DataMember(Name = "GoaltendingWins", Order = 29)]
        public decimal? GoaltendingWins { get; set; }

        /// <summary>
        /// Total goaltendings losses
        /// </summary>
        [Description("Total goaltendings losses")]
        [DataMember(Name = "GoaltendingLosses", Order = 30)]
        public decimal? GoaltendingLosses { get; set; }

        /// <summary>
        /// Total goaltendings shutouts
        /// </summary>
        [Description("Total goaltendings shutouts")]
        [DataMember(Name = "GoaltendingShutouts", Order = 31)]
        public decimal? GoaltendingShutouts { get; set; }

        /// <summary>
        /// Total games started
        /// </summary>
        [Description("Total games started")]
        [DataMember(Name = "Started", Order = 32)]
        public int? Started { get; set; }

        /// <summary>
        /// Total bench pentalty minutes
        /// </summary>
        [Description("Total bench pentalty minutes")]
        [DataMember(Name = "BenchPenaltyMinutes", Order = 33)]
        public decimal? BenchPenaltyMinutes { get; set; }

        /// <summary>
        /// Total goaltending overtime losses
        /// </summary>
        [Description("Total goaltending overtime losses")]
        [DataMember(Name = "GoaltendingOvertimeLosses", Order = 34)]
        public decimal? GoaltendingOvertimeLosses { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 35)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 36)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Whether the team is home or away
        /// </summary>
        [Description("Whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 37)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsGameOver", Order = 38)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 39)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this opponent. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalOpponentID", Order = 40)]
        public int? GlobalOpponentID { get; set; }

        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 41)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 42)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 43)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)
        /// </summary>
        [Description("The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 44)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 45)]
        public int? Season { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 46)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the Team
        /// </summary>
        [Description("The abbreviation of the Team")]
        [DataMember(Name = "Team", Order = 47)]
        public string Team { get; set; }

        /// <summary>
        /// The player's position associated with the given game or season. Possible values: C, RW, LW, D, G
        /// </summary>
        [Description("The player's position associated with the given game or season. Possible values: C, RW, LW, D, G")]
        [DataMember(Name = "Position", Order = 48)]
        public string Position { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 49)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The sum of Goals and Assists
        /// </summary>
        [Description("The sum of Goals and Assists")]
        [DataMember(Name = "Points", Order = 50)]
        public decimal? Points { get; set; }

    }
}

