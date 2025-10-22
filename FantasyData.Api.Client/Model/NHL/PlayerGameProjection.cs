using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="PlayerGameProjection")]
    [Serializable]
    public partial class PlayerGameProjection
    {
        /// <summary>
        /// The unique ID of the stat
        /// </summary>
        [Description("The unique ID of the stat")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)")]
        [DataMember(Name = "SeasonType", Order = 4)]
        public int? SeasonType { get; set; }

        /// <summary>
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 7)]
        public string Team { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; RW; LW; D; or G
        /// </summary>
        [Description("The player's primary position. Possible values: C; RW; LW; D; or G")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The player's salary as calculated by SportsDataIO (formerly known as FantasyData). Based on the same salary cap as DraftKings contests ($50,000)
        /// </summary>
        [Description("The player's salary as calculated by SportsDataIO (formerly known as FantasyData). Based on the same salary cap as DraftKings contests ($50,000)")]
        [DataMember(Name = "FantasyDataSalary", Order = 9)]
        public int? FantasyDataSalary { get; set; }

        /// <summary>
        /// The player's salary for FanDuel daily fantasy contests
        /// </summary>
        [Description("The player's salary for FanDuel daily fantasy contests")]
        [DataMember(Name = "FanDuelSalary", Order = 10)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The player's salary for DraftKings daily fantasy contests
        /// </summary>
        [Description("The player's salary for DraftKings daily fantasy contests")]
        [DataMember(Name = "DraftKingsSalary", Order = 11)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The player's salary for Yahoo daily fantasy contests.
        /// </summary>
        [Description("The player's salary for Yahoo daily fantasy contests.")]
        [DataMember(Name = "YahooSalary", Order = 12)]
        public int? YahooSalary { get; set; }

        /// <summary>
        /// The player's current injury status; in the form of likelihood that player plays. Possible values: Probable; Questionable; Doubtful; Out
        /// </summary>
        [Description("The player's current injury status; in the form of likelihood that player plays. Possible values: Probable; Questionable; Doubtful; Out")]
        [DataMember(Name = "InjuryStatus", Order = 13)]
        public string InjuryStatus { get; set; }

        /// <summary>
        /// The body part that is injured for the player (Knee; Groin; Calf; Upper-body; etc.)
        /// </summary>
        [Description("The body part that is injured for the player (Knee; Groin; Calf; Upper-body; etc.)")]
        [DataMember(Name = "InjuryBodyPart", Order = 14)]
        public string InjuryBodyPart { get; set; }

        /// <summary>
        /// The day that the injury started or was first discovered
        /// </summary>
        [Description("The day that the injury started or was first discovered")]
        [DataMember(Name = "InjuryStartDate", Order = 15)]
        public DateTime? InjuryStartDate { get; set; }

        /// <summary>
        /// Brief description of the player's injury and expected availability
        /// </summary>
        [Description("Brief description of the player's injury and expected availability")]
        [DataMember(Name = "InjuryNotes", Order = 16)]
        public string InjuryNotes { get; set; }

        /// <summary>
        /// The player's eligible position in FanDuel's daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in FanDuel's daily fantasy sports platform")]
        [DataMember(Name = "FanDuelPosition", Order = 17)]
        public string FanDuelPosition { get; set; }

        /// <summary>
        /// The player's eligible position in DraftKings' daily fantasy sports platform
        /// </summary>
        [Description("The player's eligible position in DraftKings' daily fantasy sports platform")]
        [DataMember(Name = "DraftKingsPosition", Order = 18)]
        public string DraftKingsPosition { get; set; }

        /// <summary>
        /// The player's eligible position in Yahoo's daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Yahoo's daily fantasy sports platform.")]
        [DataMember(Name = "YahooPosition", Order = 19)]
        public string YahooPosition { get; set; }

        /// <summary>
        /// The ranking of the player's opponent with regards to fantasy points allowed
        /// </summary>
        [Description("The ranking of the player's opponent with regards to fantasy points allowed")]
        [DataMember(Name = "OpponentRank", Order = 20)]
        public int? OpponentRank { get; set; }

        /// <summary>
        /// The ranking of the player's opponent by position with regards to fantasy points allowed
        /// </summary>
        [Description("The ranking of the player's opponent by position with regards to fantasy points allowed")]
        [DataMember(Name = "OpponentPositionRank", Order = 21)]
        public int? OpponentPositionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 22)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's salary for FantasyDraft daily fantasy contests
        /// </summary>
        [Description("The player's salary for FantasyDraft daily fantasy contests")]
        [DataMember(Name = "FantasyDraftSalary", Order = 23)]
        public int? FantasyDraftSalary { get; set; }

        /// <summary>
        /// The player's eligible position in Fantasy Drafts daily fantasy sports platform.
        /// </summary>
        [Description("The player's eligible position in Fantasy Drafts daily fantasy sports platform.")]
        [DataMember(Name = "FantasyDraftPosition", Order = 24)]
        public string FantasyDraftPosition { get; set; }

        /// <summary>
        /// The number of minutes played at even strength by the player in the game
        /// </summary>
        [Description("The number of minutes played at even strength by the player in the game")]
        [DataMember(Name = "EvenStrengthMinutes", Order = 25)]
        public int? EvenStrengthMinutes { get; set; }

        /// <summary>
        /// The number of seconds played at even strength by the player in the game
        /// </summary>
        [Description("The number of seconds played at even strength by the player in the game")]
        [DataMember(Name = "EvenStrengthSeconds", Order = 26)]
        public int? EvenStrengthSeconds { get; set; }

        /// <summary>
        /// Total minutes played by the player on the power play in the game
        /// </summary>
        [Description("Total minutes played by the player on the power play in the game")]
        [DataMember(Name = "PowerPlayMinutes", Order = 27)]
        public int? PowerPlayMinutes { get; set; }

        /// <summary>
        /// The number of seconds (remainder after minutes) played on a Power Play
        /// </summary>
        [Description("The number of seconds (remainder after minutes) played on a Power Play")]
        [DataMember(Name = "PowerPlaySeconds", Order = 28)]
        public int? PowerPlaySeconds { get; set; }

        /// <summary>
        /// The number of minutes played short handed by the player in the game
        /// </summary>
        [Description("The number of minutes played short handed by the player in the game")]
        [DataMember(Name = "ShortHandedMinutes", Order = 29)]
        public int? ShortHandedMinutes { get; set; }

        /// <summary>
        /// The number of seconds (remainder after minutes) played short handed by the player in the game
        /// </summary>
        [Description("The number of seconds (remainder after minutes) played short handed by the player in the game")]
        [DataMember(Name = "ShortHandedSeconds", Order = 30)]
        public int? ShortHandedSeconds { get; set; }

        /// <summary>
        /// Total points for the player in the game. Note: points are calculated by adding up a player's goals and assists
        /// </summary>
        [Description("Total points for the player in the game. Note: points are calculated by adding up a player's goals and assists")]
        [DataMember(Name = "Points", Order = 31)]
        public decimal? Points { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 32)]
        public int? GameID { get; set; }

        /// <summary>
        /// The unique ID of the team's opponent
        /// </summary>
        [Description("The unique ID of the team's opponent")]
        [DataMember(Name = "OpponentID", Order = 33)]
        public int? OpponentID { get; set; }

        /// <summary>
        /// The name of the opponent 
        /// </summary>
        [Description("The name of the opponent ")]
        [DataMember(Name = "Opponent", Order = 34)]
        public string Opponent { get; set; }

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
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 41)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The number of games played.
        /// </summary>
        [Description("The number of games played.")]
        [DataMember(Name = "Games", Order = 42)]
        public int? Games { get; set; }

        /// <summary>
        /// Total fantasy points
        /// </summary>
        [Description("Total fantasy points")]
        [DataMember(Name = "FantasyPoints", Order = 43)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total FanDuel daily fantasy points scored
        /// </summary>
        [Description("Total FanDuel daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 44)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// Total DraftKings daily fantasy points scored
        /// </summary>
        [Description("Total DraftKings daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 45)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// Total Yahoo daily fantasy points scored
        /// </summary>
        [Description("Total Yahoo daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 46)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total number of minutes played
        /// </summary>
        [Description("Total number of minutes played")]
        [DataMember(Name = "Minutes", Order = 47)]
        public int? Minutes { get; set; }

        /// <summary>
        /// Total number of seconds played
        /// </summary>
        [Description("Total number of seconds played")]
        [DataMember(Name = "Seconds", Order = 48)]
        public int? Seconds { get; set; }

        /// <summary>
        /// Total number of goals scored
        /// </summary>
        [Description("Total number of goals scored")]
        [DataMember(Name = "Goals", Order = 49)]
        public decimal? Goals { get; set; }

        /// <summary>
        /// Total number of assists
        /// </summary>
        [Description("Total number of assists")]
        [DataMember(Name = "Assists", Order = 50)]
        public decimal? Assists { get; set; }

        /// <summary>
        /// Total number of shots on goal
        /// </summary>
        [Description("Total number of shots on goal")]
        [DataMember(Name = "ShotsOnGoal", Order = 51)]
        public decimal? ShotsOnGoal { get; set; }

        /// <summary>
        /// Total number of power play goals
        /// </summary>
        [Description("Total number of power play goals")]
        [DataMember(Name = "PowerPlayGoals", Order = 52)]
        public decimal? PowerPlayGoals { get; set; }

        /// <summary>
        /// Total number of short handed goals
        /// </summary>
        [Description("Total number of short handed goals")]
        [DataMember(Name = "ShortHandedGoals", Order = 53)]
        public decimal? ShortHandedGoals { get; set; }

        /// <summary>
        /// Total number of empty net goals
        /// </summary>
        [Description("Total number of empty net goals")]
        [DataMember(Name = "EmptyNetGoals", Order = 54)]
        public decimal? EmptyNetGoals { get; set; }

        /// <summary>
        /// Total number of power play assists
        /// </summary>
        [Description("Total number of power play assists")]
        [DataMember(Name = "PowerPlayAssists", Order = 55)]
        public decimal? PowerPlayAssists { get; set; }

        /// <summary>
        /// Total number of short handed assists
        /// </summary>
        [Description("Total number of short handed assists")]
        [DataMember(Name = "ShortHandedAssists", Order = 56)]
        public decimal? ShortHandedAssists { get; set; }

        /// <summary>
        /// Total number of hat tricks
        /// </summary>
        [Description("Total number of hat tricks")]
        [DataMember(Name = "HatTricks", Order = 57)]
        public decimal? HatTricks { get; set; }

        /// <summary>
        /// Total number of shootout goals
        /// </summary>
        [Description("Total number of shootout goals")]
        [DataMember(Name = "ShootoutGoals", Order = 58)]
        public decimal? ShootoutGoals { get; set; }

        /// <summary>
        /// Total plus minus
        /// </summary>
        [Description("Total plus minus")]
        [DataMember(Name = "PlusMinus", Order = 59)]
        public decimal? PlusMinus { get; set; }

        /// <summary>
        /// Total pentalty minutes
        /// </summary>
        [Description("Total pentalty minutes")]
        [DataMember(Name = "PenaltyMinutes", Order = 60)]
        public decimal? PenaltyMinutes { get; set; }

        /// <summary>
        /// Total blocked shots
        /// </summary>
        [Description("Total blocked shots")]
        [DataMember(Name = "Blocks", Order = 61)]
        public decimal? Blocks { get; set; }

        /// <summary>
        /// Total hits
        /// </summary>
        [Description("Total hits")]
        [DataMember(Name = "Hits", Order = 62)]
        public decimal? Hits { get; set; }

        /// <summary>
        /// Total takeaways
        /// </summary>
        [Description("Total takeaways")]
        [DataMember(Name = "Takeaways", Order = 63)]
        public decimal? Takeaways { get; set; }

        /// <summary>
        /// Total giveaways
        /// </summary>
        [Description("Total giveaways")]
        [DataMember(Name = "Giveaways", Order = 64)]
        public decimal? Giveaways { get; set; }

        /// <summary>
        /// Total faceoffs won
        /// </summary>
        [Description("Total faceoffs won")]
        [DataMember(Name = "FaceoffsWon", Order = 65)]
        public decimal? FaceoffsWon { get; set; }

        /// <summary>
        /// Total faceoffs lost
        /// </summary>
        [Description("Total faceoffs lost")]
        [DataMember(Name = "FaceoffsLost", Order = 66)]
        public decimal? FaceoffsLost { get; set; }

        /// <summary>
        /// Total shifts
        /// </summary>
        [Description("Total shifts")]
        [DataMember(Name = "Shifts", Order = 67)]
        public decimal? Shifts { get; set; }

        /// <summary>
        /// Total goaltending minutes
        /// </summary>
        [Description("Total goaltending minutes")]
        [DataMember(Name = "GoaltendingMinutes", Order = 68)]
        public int? GoaltendingMinutes { get; set; }

        /// <summary>
        /// Total goaltending seconds
        /// </summary>
        [Description("Total goaltending seconds")]
        [DataMember(Name = "GoaltendingSeconds", Order = 69)]
        public int? GoaltendingSeconds { get; set; }

        /// <summary>
        /// Total goaltending shots against
        /// </summary>
        [Description("Total goaltending shots against")]
        [DataMember(Name = "GoaltendingShotsAgainst", Order = 70)]
        public decimal? GoaltendingShotsAgainst { get; set; }

        /// <summary>
        /// Total goaltending goals against
        /// </summary>
        [Description("Total goaltending goals against")]
        [DataMember(Name = "GoaltendingGoalsAgainst", Order = 71)]
        public decimal? GoaltendingGoalsAgainst { get; set; }

        /// <summary>
        /// Total goaltending saves
        /// </summary>
        [Description("Total goaltending saves")]
        [DataMember(Name = "GoaltendingSaves", Order = 72)]
        public decimal? GoaltendingSaves { get; set; }

        /// <summary>
        /// Total goaltending wins
        /// </summary>
        [Description("Total goaltending wins")]
        [DataMember(Name = "GoaltendingWins", Order = 73)]
        public decimal? GoaltendingWins { get; set; }

        /// <summary>
        /// Total goaltendings losses
        /// </summary>
        [Description("Total goaltendings losses")]
        [DataMember(Name = "GoaltendingLosses", Order = 74)]
        public decimal? GoaltendingLosses { get; set; }

        /// <summary>
        /// Total goaltendings shutouts
        /// </summary>
        [Description("Total goaltendings shutouts")]
        [DataMember(Name = "GoaltendingShutouts", Order = 75)]
        public decimal? GoaltendingShutouts { get; set; }

        /// <summary>
        /// Total games started
        /// </summary>
        [Description("Total games started")]
        [DataMember(Name = "Started", Order = 76)]
        public int? Started { get; set; }

        /// <summary>
        /// Total bench pentalty minutes
        /// </summary>
        [Description("Total bench pentalty minutes")]
        [DataMember(Name = "BenchPenaltyMinutes", Order = 77)]
        public decimal? BenchPenaltyMinutes { get; set; }

        /// <summary>
        /// Total goaltending overtime losses
        /// </summary>
        [Description("Total goaltending overtime losses")]
        [DataMember(Name = "GoaltendingOvertimeLosses", Order = 78)]
        public decimal? GoaltendingOvertimeLosses { get; set; }

        /// <summary>
        /// Total FantasyDraft daily fantasy points scored
        /// </summary>
        [Description("Total FantasyDraft daily fantasy points scored")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 79)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

    }
}

