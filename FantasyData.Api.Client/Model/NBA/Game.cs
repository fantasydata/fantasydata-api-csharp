using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        /// The NBA season of the game
        /// </summary>
        [Description("The NBA season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Playoffs).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Playoffs).")]
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
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 11)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The television station broadcasting the game
        /// </summary>
        [Description("The television station broadcasting the game")]
        [DataMember(Name = "Channel", Order = 12)]
        public string Channel { get; set; }

        /// <summary>
        /// Total number of people who attended the game
        /// </summary>
        [Description("Total number of people who attended the game")]
        [DataMember(Name = "Attendance", Order = 13)]
        public int? Attendance { get; set; }

        /// <summary>
        /// Number of points the away scored in this game
        /// </summary>
        [Description("Number of points the away scored in this game")]
        [DataMember(Name = "AwayTeamScore", Order = 14)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Number of points the home scored in this game
        /// </summary>
        [Description("Number of points the home scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 16)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The current quarter in the game. Possible values include: 1, 2, 3, 4, Half, OT, NULL
        /// </summary>
        [Description("The current quarter in the game. Possible values include: 1, 2, 3, 4, Half, OT, NULL")]
        [DataMember(Name = "Quarter", Order = 17)]
        public string Quarter { get; set; }

        /// <summary>
        /// Number of minutes remaining in the quarter
        /// </summary>
        [Description("Number of minutes remaining in the quarter")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 18)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds remaining in the quarter
        /// </summary>
        [Description("Number of seconds remaining in the quarter")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 19)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 20)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 21)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team
        /// </summary>
        [Description("Money line from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 22)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team
        /// </summary>
        [Description("Money line from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 23)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 24)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 25)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 26)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the away team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the away team with the point spread")]
        [DataMember(Name = "PointSpreadAwayTeamMoneyLine", Order = 27)]
        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the home team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the home team with the point spread")]
        [DataMember(Name = "PointSpreadHomeTeamMoneyLine", Order = 28)]
        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.
        /// </summary>
        [Description("The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.")]
        [DataMember(Name = "LastPlay", Order = 29)]
        public string LastPlay { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 30)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The details of the quarters (including overtime periods) for this game.
        /// </summary>
        [Description("The details of the quarters (including overtime periods) for this game.")]
        [DataMember(Name = "Quarters", Order = 20031)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 32)]
        public DateTime? GameEndDateTime { get; set; }

    }
}

