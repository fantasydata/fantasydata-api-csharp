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
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary")]
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
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
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
        /// The total number of people in attendance at the game
        /// </summary>
        [Description("The total number of people in attendance at the game")]
        [DataMember(Name = "Attendance", Order = 13)]
        public int? Attendance { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game
        /// </summary>
        [Description("Total number of points the away team scored in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 14)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game
        /// </summary>
        [Description("Total number of points the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 16)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The current quarter in the game. Possible values include: 1, 2, 3, 4, Half, OT, NULL
        /// </summary>
        [Description("The current quarter in the game. Possible values include: 1, 2, 3, 4, Half, OT, NULL")]
        [DataMember(Name = "Quarter", Order = 17)]
        public string Quarter { get; set; }

        /// <summary>
        /// The number of minutes remaining in the quarter
        /// </summary>
        [Description("The number of minutes remaining in the quarter")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 18)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// The number of seconds remaining in the quarter
        /// </summary>
        [Description("The number of seconds remaining in the quarter")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 19)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 20)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The sportsbook's total points scored over under for the game
        /// </summary>
        [Description("The sportsbook's total points scored over under for the game")]
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
        /// The money line payout odds when betting on the away team with the point spread.
        /// </summary>
        [Description("The money line payout odds when betting on the away team with the point spread.")]
        [DataMember(Name = "PointSpreadAwayTeamMoneyLine", Order = 27)]
        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the away team with the point spread.
        /// </summary>
        [Description("The money line payout odds when betting on the away team with the point spread.")]
        [DataMember(Name = "PointSpreadHomeTeamMoneyLine", Order = 28)]
        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.
        /// </summary>
        [Description("The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.")]
        [DataMember(Name = "LastPlay", Order = 29)]
        public string LastPlay { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 30)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The details of the quarters (including overtime periods) for this game.
        /// </summary>
        [Description("The details of the quarters (including overtime periods) for this game.")]
        [DataMember(Name = "Quarters", Order = 20031)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The date and time that the game ended (in US Eastern Time)
        /// </summary>
        [Description("The date and time that the game ended (in US Eastern Time)")]
        [DataMember(Name = "GameEndDateTime", Order = 32)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The rotation number of the home team for this game
        /// </summary>
        [Description("The rotation number of the home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 33)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// The rotation number of the away team for this game
        /// </summary>
        [Description("The rotation number of the away team for this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 34)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue")]
        [DataMember(Name = "NeutralVenue", Order = 35)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over on the total points line
        /// </summary>
        [Description("The sportsbook's payout for the over on the total points line")]
        [DataMember(Name = "OverPayout", Order = 36)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under on the total points line
        /// </summary>
        [Description("The sportsbook's payout for the under on the total points line")]
        [DataMember(Name = "UnderPayout", Order = 37)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// Unique ID of officiating Crew Chief
        /// </summary>
        [Description("Unique ID of officiating Crew Chief")]
        [DataMember(Name = "CrewChiefID", Order = 38)]
        public int? CrewChiefID { get; set; }

        /// <summary>
        /// Unique ID of officiating Umpire referee
        /// </summary>
        [Description("Unique ID of officiating Umpire referee")]
        [DataMember(Name = "UmpireID", Order = 39)]
        public int? UmpireID { get; set; }

        /// <summary>
        /// Unique ID of officiating referee
        /// </summary>
        [Description("Unique ID of officiating referee")]
        [DataMember(Name = "RefereeID", Order = 40)]
        public int? RefereeID { get; set; }

        /// <summary>
        /// Unique ID of officiating Alternate referee
        /// </summary>
        [Description("Unique ID of officiating Alternate referee")]
        [DataMember(Name = "AlternateID", Order = 41)]
        public int? AlternateID { get; set; }

        /// <summary>
        /// The date and time of the game in UTC
        /// </summary>
        [Description("The date and time of the game in UTC")]
        [DataMember(Name = "DateTimeUTC", Order = 42)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength
        /// </summary>
        [Description("Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength")]
        [DataMember(Name = "SeriesInfo", Order = 10043)]
        public Series SeriesInfo { get; set; }

        /// <summary>
        /// A flag to indicate this game is part of the inseason NBA tournament (can be considered a part of regular season still) - a null would also indicate false
        /// </summary>
        [Description("A flag to indicate this game is part of the inseason NBA tournament (can be considered a part of regular season still) - a null would also indicate false")]
        [DataMember(Name = "InseasonTournament", Order = 44)]
        public bool? InseasonTournament { get; set; }

    }
}

