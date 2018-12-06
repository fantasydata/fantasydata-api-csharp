using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="Game")]
    [Serializable]
    public partial class Game
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The College Basketball season of the game
        /// </summary>
        [Description("The College Basketball season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in this game
        /// </summary>
        [Description("Total number of points the away team scored in this game")]
        [DataMember(Name = "AwayTeamScore", Order = 11)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game
        /// </summary>
        [Description("Total number of points the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 12)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The current half of the game (Possible Values: 1, 2, Half, OT, F, F/OT, NULL)
        /// </summary>
        [Description("The current half of the game (Possible Values: 1, 2, Half, OT, F, F/OT, NULL)")]
        [DataMember(Name = "Period", Order = 14)]
        public string Period { get; set; }

        /// <summary>
        /// Number of minutes remaining in the half
        /// </summary>
        [Description("Number of minutes remaining in the half")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 15)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds remaining in the half
        /// </summary>
        [Description("Number of seconds remaining in the half")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 16)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 17)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 18)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team
        /// </summary>
        [Description("Money line from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 19)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team
        /// </summary>
        [Description("Money line from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 20)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 21)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 22)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 23)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the tournament
        /// </summary>
        [Description("The unique ID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 24)]
        public int? TournamentID { get; set; }

        /// <summary>
        /// The bracket of the tournament
        /// </summary>
        [Description("The bracket of the tournament")]
        [DataMember(Name = "Bracket", Order = 25)]
        public string Bracket { get; set; }

        /// <summary>
        /// The current round of the tournament
        /// </summary>
        [Description("The current round of the tournament")]
        [DataMember(Name = "Round", Order = 26)]
        public int? Round { get; set; }

        /// <summary>
        /// The seed of the away team
        /// </summary>
        [Description("The seed of the away team")]
        [DataMember(Name = "AwayTeamSeed", Order = 27)]
        public int? AwayTeamSeed { get; set; }

        /// <summary>
        /// The seed of the home team
        /// </summary>
        [Description("The seed of the home team")]
        [DataMember(Name = "HomeTeamSeed", Order = 28)]
        public int? HomeTeamSeed { get; set; }

        /// <summary>
        /// The unique ID of the away team's previous game
        /// </summary>
        [Description("The unique ID of the away team's previous game")]
        [DataMember(Name = "AwayTeamPreviousGameID", Order = 29)]
        public int? AwayTeamPreviousGameID { get; set; }

        /// <summary>
        /// The unique ID of the home team's previous game
        /// </summary>
        [Description("The unique ID of the home team's previous game")]
        [DataMember(Name = "HomeTeamPreviousGameID", Order = 30)]
        public int? HomeTeamPreviousGameID { get; set; }

        /// <summary>
        /// The unique global ID of the away team's previous game
        /// </summary>
        [Description("The unique global ID of the away team's previous game")]
        [DataMember(Name = "AwayTeamPreviousGlobalGameID", Order = 31)]
        public int? AwayTeamPreviousGlobalGameID { get; set; }

        /// <summary>
        /// The unique global ID of the away team's previous game
        /// </summary>
        [Description("The unique global ID of the away team's previous game")]
        [DataMember(Name = "HomeTeamPreviousGlobalGameID", Order = 32)]
        public int? HomeTeamPreviousGlobalGameID { get; set; }

        /// <summary>
        /// The display order of this game. This is used for rendering NCAA Tournament bracket.
        /// </summary>
        [Description("The display order of this game. This is used for rendering NCAA Tournament bracket.")]
        [DataMember(Name = "TournamentDisplayOrder", Order = 33)]
        public int? TournamentDisplayOrder { get; set; }

        /// <summary>
        /// The display order of the home team for this game. This is used for rendering the NCAA Tournament bracket, and it indicates whether the home team should be displayed at the top or bottom of the game card. Possible values: Top, Bottom
        /// </summary>
        [Description("The display order of the home team for this game. This is used for rendering the NCAA Tournament bracket, and it indicates whether the home team should be displayed at the top or bottom of the game card. Possible values: Top, Bottom")]
        [DataMember(Name = "TournamentDisplayOrderForHomeTeam", Order = 34)]
        public string TournamentDisplayOrderForHomeTeam { get; set; }

        /// <summary>
        /// The details of the periods (halves & overtime) for this game.
        /// </summary>
        [Description("The details of the periods (halves & overtime) for this game.")]
        [DataMember(Name = "Periods", Order = 20035)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 36)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 37)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The stadium details of where this game was played
        /// </summary>
        [Description("The stadium details of where this game was played")]
        [DataMember(Name = "Stadium", Order = 10038)]
        public Stadium Stadium { get; set; }

    }
}

