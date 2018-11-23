using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Canceled")]
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
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 8)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 9)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 10)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 11)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 12)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 13)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The television station broadcasting the game
        /// </summary>
        [Description("The television station broadcasting the game")]
        [DataMember(Name = "Channel", Order = 14)]
        public string Channel { get; set; }

        /// <summary>
        /// Total number of people who attended the game
        /// </summary>
        [Description("Total number of people who attended the game")]
        [DataMember(Name = "Attendance", Order = 15)]
        public int? Attendance { get; set; }

        /// <summary>
        /// Number of goals the away team scored in this game
        /// </summary>
        [Description("Number of goals the away team scored in this game")]
        [DataMember(Name = "AwayTeamScore", Order = 16)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Number of goals the home team scored in this game
        /// </summary>
        [Description("Number of goals the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 17)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Indicated the current period of the game. Possible values include: 1, 2, 3, OT, SO, Final, F/OT, F/SO, NULL
        /// </summary>
        [Description("Indicated the current period of the game. Possible values include: 1, 2, 3, OT, SO, Final, F/OT, F/SO, NULL")]
        [DataMember(Name = "Period", Order = 18)]
        public string Period { get; set; }

        /// <summary>
        /// Number of minutes that have passed in the current period. Please note this field name is misleading, and actually represents the game clock minutes, which are the number of minutes that have already passed in the period. Possible values: 0-20.
        /// </summary>
        [Description("Number of minutes that have passed in the current period. Please note this field name is misleading, and actually represents the game clock minutes, which are the number of minutes that have already passed in the period. Possible values: 0-20.")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 19)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds that have passed in the current period. Please note this field name is misleading, and actually represents the game clock seconds, which are the number of seconds that have already passed in the period. Possible values: 0-60.
        /// </summary>
        [Description("Number of seconds that have passed in the current period. Please note this field name is misleading, and actually represents the game clock seconds, which are the number of seconds that have already passed in the period. Possible values: 0-60.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 20)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team.
        /// </summary>
        [Description("Money line from the perspective of the away team.")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 21)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team.
        /// </summary>
        [Description("Money line from the perspective of the home team.")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 22)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 23)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 24)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 25)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 26)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 27)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the away team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the away team with the point spread")]
        [DataMember(Name = "PointSpreadAwayTeamMoneyLine", Order = 28)]
        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the home team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the home team with the point spread")]
        [DataMember(Name = "PointSpreadHomeTeamMoneyLine", Order = 29)]
        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.
        /// </summary>
        [Description("The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.")]
        [DataMember(Name = "LastPlay", Order = 30)]
        public string LastPlay { get; set; }

        /// <summary>
        /// The details of the periods (including overtime if applicable) for this game.
        /// </summary>
        [Description("The details of the periods (including overtime if applicable) for this game.")]
        [DataMember(Name = "Periods", Order = 20031)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 32)]
        public DateTime? GameEndDateTime { get; set; }

    }
}

