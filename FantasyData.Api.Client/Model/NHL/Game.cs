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
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 5=AllStar, 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 5=AllStar, 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (in US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (in US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. NOTE: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. NOTE: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 8)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 9)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
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
        /// The total number of people who attended the game
        /// </summary>
        [Description("The total number of people who attended the game")]
        [DataMember(Name = "Attendance", Order = 15)]
        public int? Attendance { get; set; }

        /// <summary>
        /// Total number of goals scored by the away team in the game
        /// </summary>
        [Description("Total number of goals scored by the away team in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 16)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of goals scored by the home team in the game
        /// </summary>
        [Description("Total number of goals scored by the home team in the game")]
        [DataMember(Name = "HomeTeamScore", Order = 17)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Indicates the current period of the game. Possible values include: 1; 2; 3; OT; SO; NULL
        /// </summary>
        [Description("Indicates the current period of the game. Possible values include: 1; 2; 3; OT; SO; NULL")]
        [DataMember(Name = "Period", Order = 18)]
        public string Period { get; set; }

        /// <summary>
        /// Number of minutes remaining in the current period
        /// </summary>
        [Description("Number of minutes remaining in the current period")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 19)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds that have passed in the current period.  NOTE: this field name might be misleading as it actually represents the game clock sconds which are the number of minutes that have already passed in the period.
        /// </summary>
        [Description("Number of seconds that have passed in the current period.  NOTE: this field name might be misleading as it actually represents the game clock sconds which are the number of minutes that have already passed in the period.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 20)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// Moneyline from the perspective of the away team
        /// </summary>
        [Description("Moneyline from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 21)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Moneyline from the perspective of the home team
        /// </summary>
        [Description("Moneyline from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 22)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The oddsmaker puck line at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored).
        /// </summary>
        [Description("The oddsmaker puck line at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored).")]
        [DataMember(Name = "PointSpread", Order = 23)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The sportsbook's total goals scored line (Over/Under) for the game
        /// </summary>
        [Description("The sportsbook's total goals scored line (Over/Under) for the game")]
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
        /// The payout odds when betting on the away team with the puck line
        /// </summary>
        [Description("The payout odds when betting on the away team with the puck line")]
        [DataMember(Name = "PointSpreadAwayTeamMoneyLine", Order = 28)]
        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The payout odds when betting on the home team with the puck line
        /// </summary>
        [Description("The payout odds when betting on the home team with the puck line")]
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

        /// <summary>
        /// The rotation number of the home team for this game
        /// </summary>
        [Description("The rotation number of the home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 33)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The rotation number of the away team for a game
        /// </summary>
        [Description("The rotation number of the away team for a game")]
        [DataMember(Name = "AwayRotationNumber", Order = 34)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue")]
        [DataMember(Name = "NeutralVenue", Order = 35)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over
        /// </summary>
        [Description("The sportsbook's payout for the over")]
        [DataMember(Name = "OverPayout", Order = 36)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 37)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// The date and time of the game in UTC
        /// </summary>
        [Description("The date and time of the game in UTC")]
        [DataMember(Name = "DateTimeUTC", Order = 38)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength
        /// </summary>
        [Description("Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength")]
        [DataMember(Name = "SeriesInfo", Order = 10039)]
        public Series SeriesInfo { get; set; }

    }
}

