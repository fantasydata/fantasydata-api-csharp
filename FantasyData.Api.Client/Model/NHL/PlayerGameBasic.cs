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
        /// The timestamp of when the record was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 1)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Total games played by the player in the game. NOTE: this will be 1 or 0 for single game feeds
        /// </summary>
        [Description("Total games played by the player in the game. NOTE: this will be 1 or 0 for single game feeds")]
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
        /// Total goals scored by the player in the game
        /// </summary>
        [Description("Total goals scored by the player in the game")]
        [DataMember(Name = "Goals", Order = 5)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total assists by the player in the game
        /// </summary>
        [Description("Total assists by the player in the game")]
        [DataMember(Name = "Assists", Order = 6)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total shots on goal by the player in the game
        /// </summary>
        [Description("Total shots on goal by the player in the game")]
        [DataMember(Name = "ShotsOnGoal", Order = 7)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total power play goals by the player in the game
        /// </summary>
        [Description("Total power play goals by the player in the game")]
        [DataMember(Name = "PowerPlayGoals", Order = 8)]
        public decimal? PowerPlayGoals { get; set; }

        /// <summary>
        /// Total short handed goals by the player in the game
        /// </summary>
        [Description("Total short handed goals by the player in the game")]
        [DataMember(Name = "ShortHandedGoals", Order = 9)]
        public decimal? ShortHandedGoals { get; set; }

        /// <summary>
        /// Total number of empty net goals by the player in the game
        /// </summary>
        [Description("Total number of empty net goals by the player in the game")]
        [DataMember(Name = "EmptyNetGoals", Order = 10)]
        public decimal? EmptyNetGoals { get; set; }

        /// <summary>
        /// Total power play assists by the player in the game
        /// </summary>
        [Description("Total power play assists by the player in the game")]
        [DataMember(Name = "PowerPlayAssists", Order = 11)]
        public decimal? PowerPlayAssists { get; set; }

        /// <summary>
        /// Total short handed assists by the player in the game
        /// </summary>
        [Description("Total short handed assists by the player in the game")]
        [DataMember(Name = "ShortHandedAssists", Order = 12)]
        public decimal? ShortHandedAssists { get; set; }

        /// <summary>
        /// Total hat tricks by the player in the game
        /// </summary>
        [Description("Total hat tricks by the player in the game")]
        [DataMember(Name = "HatTricks", Order = 13)]
        public decimal? HatTricks { get; set; }

        /// <summary>
        /// Total shootout goals by the player in the game
        /// </summary>
        [Description("Total shootout goals by the player in the game")]
        [DataMember(Name = "ShootoutGoals", Order = 14)]
        public decimal? ShootoutGoals { get; set; }

        /// <summary>
        /// Total plus/minus by the player in the game
        /// </summary>
        [Description("Total plus/minus by the player in the game")]
        [DataMember(Name = "PlusMinus", Order = 15)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total penalty minutes by the player in the game
        /// </summary>
        [Description("Total penalty minutes by the player in the game")]
        [DataMember(Name = "PenaltyMinutes", Order = 16)]
        public decimal? PenaltyMinutes { get; set; }

        /// <summary>
        /// Total blocked shots by the player in the game
        /// </summary>
        [Description("Total blocked shots by the player in the game")]
        [DataMember(Name = "Blocks", Order = 17)]
        public decimal? Blocks { get; set; }

        /// <summary>
        /// Total hits by the player in the game
        /// </summary>
        [Description("Total hits by the player in the game")]
        [DataMember(Name = "Hits", Order = 18)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total takeaways by the player in the game
        /// </summary>
        [Description("Total takeaways by the player in the game")]
        [DataMember(Name = "Takeaways", Order = 19)]
        public decimal? Takeaways { get; set; }

        /// <summary>
        /// Total giveaways by the player in the game
        /// </summary>
        [Description("Total giveaways by the player in the game")]
        [DataMember(Name = "Giveaways", Order = 20)]
        public decimal? Giveaways { get; set; }

        /// <summary>
        /// Total faceoffs won by the player in the game
        /// </summary>
        [Description("Total faceoffs won by the player in the game")]
        [DataMember(Name = "FaceoffsWon", Order = 21)]
        public decimal? FaceoffsWon { get; set; }

        /// <summary>
        /// Total faceoffs lost by the player in the game
        /// </summary>
        [Description("Total faceoffs lost by the player in the game")]
        [DataMember(Name = "FaceoffsLost", Order = 22)]
        public decimal? FaceoffsLost { get; set; }

        /// <summary>
        /// Total shifts by the player in the game
        /// </summary>
        [Description("Total shifts by the player in the game")]
        [DataMember(Name = "Shifts", Order = 23)]
        public decimal? Shifts { get; set; }

        /// <summary>
        /// Total goaltending minutes played by the player in the game
        /// </summary>
        [Description("Total goaltending minutes played by the player in the game")]
        [DataMember(Name = "GoaltendingMinutes", Order = 24)]
        public int? GoaltendingMinutes { get; set; }

        /// <summary>
        /// Total goaltending seconds played by the player in the game
        /// </summary>
        [Description("Total goaltending seconds played by the player in the game")]
        [DataMember(Name = "GoaltendingSeconds", Order = 25)]
        public int? GoaltendingSeconds { get; set; }

        /// <summary>
        /// Total goaltending shots against the player in the game
        /// </summary>
        [Description("Total goaltending shots against the player in the game")]
        [DataMember(Name = "GoaltendingShotsAgainst", Order = 26)]
        public decimal? GoaltendingShotsAgainst { get; set; }

        /// <summary>
        /// Total goals allowed by the player in the game
        /// </summary>
        [Description("Total goals allowed by the player in the game")]
        [DataMember(Name = "GoaltendingGoalsAgainst", Order = 27)]
        public decimal? GoaltendingGoalsAgainst { get; set; }

        /// <summary>
        /// Total goaltending saves by the player in the game
        /// </summary>
        [Description("Total goaltending saves by the player in the game")]
        [DataMember(Name = "GoaltendingSaves", Order = 28)]
        public decimal? GoaltendingSaves { get; set; }

        /// <summary>
        /// Total goaltending wins by the player in the game
        /// </summary>
        [Description("Total goaltending wins by the player in the game")]
        [DataMember(Name = "GoaltendingWins", Order = 29)]
        public decimal? GoaltendingWins { get; set; }

        /// <summary>
        /// Total goaltending losses by the player in the game
        /// </summary>
        [Description("Total goaltending losses by the player in the game")]
        [DataMember(Name = "GoaltendingLosses", Order = 30)]
        public decimal? GoaltendingLosses { get; set; }

        /// <summary>
        /// Total goaltending shutouts by the player in the game
        /// </summary>
        [Description("Total goaltending shutouts by the player in the game")]
        [DataMember(Name = "GoaltendingShutouts", Order = 31)]
        public decimal? GoaltendingShutouts { get; set; }

        /// <summary>
        /// Indicates whether or not the player started the game Note: this will be one or zero for single game feedsIndicates whether or not the player started the game. Note: this will be one or zero for single game feeds
        /// </summary>
        [Description("Indicates whether or not the player started the game Note: this will be one or zero for single game feedsIndicates whether or not the player started the game. Note: this will be one or zero for single game feeds")]
        [DataMember(Name = "Started", Order = 32)]
        public int? Started { get; set; }

        /// <summary>
        /// Total bench pentalty minutes by the player in the game. NOTE: Bench penalties are assigned to teams. This will always be 0 for players
        /// </summary>
        [Description("Total bench pentalty minutes by the player in the game. NOTE: Bench penalties are assigned to teams. This will always be 0 for players")]
        [DataMember(Name = "BenchPenaltyMinutes", Order = 33)]
        public decimal? BenchPenaltyMinutes { get; set; }

        /// <summary>
        /// Total goaltending overtime losses by the player in the game
        /// </summary>
        [Description("Total goaltending overtime losses by the player in the game")]
        [DataMember(Name = "GoaltendingOvertimeLosses", Order = 34)]
        public decimal? GoaltendingOvertimeLosses { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 35)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 36)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates whether the team is home or away
        /// </summary>
        [Description("Indicates whether the team is home or away")]
        [DataMember(Name = "HomeOrAway", Order = 37)]
        public string HomeOrAway { get; set; }

        /// <summary>
        /// Whether the game is over (returns true/false)
        /// </summary>
        [Description("Whether the game is over (returns true/false)")]
        [DataMember(Name = "IsGameOver", Order = 38)]
        public bool IsGameOver { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 39)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues.")]
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
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 43)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)")]
        [DataMember(Name = "SeasonType", Order = 44)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 45)]
        public int? Season { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 46)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 47)]
        public string Team { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; RW; LW; D; or G
        /// </summary>
        [Description("The player's primary position. Possible values: C; RW; LW; D; or G")]
        [DataMember(Name = "Position", Order = 48)]
        public string Position { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 49)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// Total points for the player in the game. Note: Points are calcuated by adding up a player's goals and assists
        /// </summary>
        [Description("Total points for the player in the game. Note: Points are calcuated by adding up a player's goals and assists")]
        [DataMember(Name = "Points", Order = 50)]
        public decimal? Points { get; set; }

    }
}

