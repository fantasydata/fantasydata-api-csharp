using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Score")]
    [Serializable]
    public partial class Score
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to.  The GameID is composed of Season, SeasonType, Week and HomeTeam.")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season, 2=Preseason, 3=Postseason).
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season, 2=Preseason, 3=Postseason).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 17, preseason: 0 to 4, postseason: 1 to 4)")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// The date/time of the game
        /// </summary>
        [Description("The date/time of the game")]
        [DataMember(Name = "Date", Order = 5)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 6)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 7)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The final score of the Away Team
        /// </summary>
        [Description("The final score of the Away Team")]
        [DataMember(Name = "AwayScore", Order = 8)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The final score of the Home Team
        /// </summary>
        [Description("The final score of the Home Team")]
        [DataMember(Name = "HomeScore", Order = 9)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// The television station broadcasting the game
        /// </summary>
        [Description("The television station broadcasting the game")]
        [DataMember(Name = "Channel", Order = 10)]
        public string Channel { get; set; }

        /// <summary>
        /// The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker Point Spread at game start from the perspective of the HomeTeam (negative numbers indicate the HomeTeam is favored, positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 11)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The oddsmaker Over/Under at game start
        /// </summary>
        [Description("The oddsmaker Over/Under at game start")]
        [DataMember(Name = "OverUnder", Order = 12)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)
        /// </summary>
        [Description("The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)")]
        [DataMember(Name = "Quarter", Order = 13)]
        public string Quarter { get; set; }

        /// <summary>
        /// The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)")]
        [DataMember(Name = "TimeRemaining", Order = 14)]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// The team that currently has possession of the ball (PHI, NE, NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The team that currently has possession of the ball (PHI, NE, NULL if game is not in progress or at halftime)")]
        [DataMember(Name = "Possession", Order = 15)]
        public string Possession { get; set; }

        /// <summary>
        /// The current down in the game (1, 2, 3, 4 or NULL)
        /// </summary>
        [Description("The current down in the game (1, 2, 3, 4 or NULL)")]
        [DataMember(Name = "Down", Order = 16)]
        public int? Down { get; set; }

        /// <summary>
        /// The yards to go for a first down (this can be any positive number or "Goal")
        /// </summary>
        [Description("The yards to go for a first down (this can be any positive number or \"Goal\")")]
        [DataMember(Name = "Distance", Order = 17)]
        public string Distance { get; set; }

        /// <summary>
        /// The yard line that the ball is currently located, as of the most recently completed play
        /// </summary>
        [Description("The yard line that the ball is currently located, as of the most recently completed play")]
        [DataMember(Name = "YardLine", Order = 18)]
        public int? YardLine { get; set; }

        /// <summary>
        /// The team's territory that the ball is currently located ("SF", "BAL" or NULL)
        /// </summary>
        [Description("The team's territory that the ball is currently located (\"SF\", \"BAL\" or NULL)")]
        [DataMember(Name = "YardLineTerritory", Order = 19)]
        public string YardLineTerritory { get; set; }

        /// <summary>
        /// The team that currently has the ball in the opponent's red zone ("SF", "BAL" or NULL)
        /// </summary>
        [Description("The team that currently has the ball in the opponent's red zone (\"SF\", \"BAL\" or NULL)")]
        [DataMember(Name = "RedZone", Order = 20)]
        public string RedZone { get; set; }

        /// <summary>
        /// Points scored during Quarter 1
        /// </summary>
        [Description("Points scored during Quarter 1")]
        [DataMember(Name = "AwayScoreQuarter1", Order = 21)]
        public int? AwayScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2
        /// </summary>
        [Description("Points scored during Quarter 2")]
        [DataMember(Name = "AwayScoreQuarter2", Order = 22)]
        public int? AwayScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3
        /// </summary>
        [Description("Points scored during Quarter 3")]
        [DataMember(Name = "AwayScoreQuarter3", Order = 23)]
        public int? AwayScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4
        /// </summary>
        [Description("Points scored during Quarter 4")]
        [DataMember(Name = "AwayScoreQuarter4", Order = 24)]
        public int? AwayScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime
        /// </summary>
        [Description("Points scored during Overtime")]
        [DataMember(Name = "AwayScoreOvertime", Order = 25)]
        public int? AwayScoreOvertime { get; set; }

        /// <summary>
        /// Points scored during Quarter 1
        /// </summary>
        [Description("Points scored during Quarter 1")]
        [DataMember(Name = "HomeScoreQuarter1", Order = 26)]
        public int? HomeScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2
        /// </summary>
        [Description("Points scored during Quarter 2")]
        [DataMember(Name = "HomeScoreQuarter2", Order = 27)]
        public int? HomeScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3
        /// </summary>
        [Description("Points scored during Quarter 3")]
        [DataMember(Name = "HomeScoreQuarter3", Order = 28)]
        public int? HomeScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4
        /// </summary>
        [Description("Points scored during Quarter 4")]
        [DataMember(Name = "HomeScoreQuarter4", Order = 29)]
        public int? HomeScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime
        /// </summary>
        [Description("Points scored during Overtime")]
        [DataMember(Name = "HomeScoreOvertime", Order = 30)]
        public int? HomeScoreOvertime { get; set; }

        /// <summary>
        /// Whether the game has started (true/false)
        /// </summary>
        [Description("Whether the game has started (true/false)")]
        [DataMember(Name = "HasStarted", Order = 31)]
        public bool HasStarted { get; set; }

        /// <summary>
        /// Whether the game is currently in progress (true/false)
        /// </summary>
        [Description("Whether the game is currently in progress (true/false)")]
        [DataMember(Name = "IsInProgress", Order = 32)]
        public bool IsInProgress { get; set; }

        /// <summary>
        /// Whether the game is over (true/false)
        /// </summary>
        [Description("Whether the game is over (true/false)")]
        [DataMember(Name = "IsOver", Order = 33)]
        public bool IsOver { get; set; }

        /// <summary>
        /// Whether the 1st quarter has started
        /// </summary>
        [Description("Whether the 1st quarter has started")]
        [DataMember(Name = "Has1stQuarterStarted", Order = 34)]
        public bool Has1stQuarterStarted { get; set; }

        /// <summary>
        /// Whether the 2nd quarter has started
        /// </summary>
        [Description("Whether the 2nd quarter has started")]
        [DataMember(Name = "Has2ndQuarterStarted", Order = 35)]
        public bool Has2ndQuarterStarted { get; set; }

        /// <summary>
        /// Whether the 3rd quarter has started
        /// </summary>
        [Description("Whether the 3rd quarter has started")]
        [DataMember(Name = "Has3rdQuarterStarted", Order = 36)]
        public bool Has3rdQuarterStarted { get; set; }

        /// <summary>
        /// Whether the 4th quarter has started
        /// </summary>
        [Description("Whether the 4th quarter has started")]
        [DataMember(Name = "Has4thQuarterStarted", Order = 37)]
        public bool Has4thQuarterStarted { get; set; }

        /// <summary>
        /// Whether this game went into overtime
        /// </summary>
        [Description("Whether this game went into overtime")]
        [DataMember(Name = "IsOvertime", Order = 38)]
        public bool IsOvertime { get; set; }

        /// <summary>
        /// Description of the down and distance for display purposes
        /// </summary>
        [Description("Description of the down and distance for display purposes")]
        [DataMember(Name = "DownAndDistance", Order = 39)]
        public string DownAndDistance { get; set; }

        /// <summary>
        /// Description of the current quarter for display purposes
        /// </summary>
        [Description("Description of the current quarter for display purposes")]
        [DataMember(Name = "QuarterDescription", Order = 40)]
        public string QuarterDescription { get; set; }

        /// <summary>
        /// The unique ID of the team's current home stadium
        /// </summary>
        [Description("The unique ID of the team's current home stadium")]
        [DataMember(Name = "StadiumID", Order = 41)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The date and time that this game was last updated (US Eastern Time)
        /// </summary>
        [Description("The date and time that this game was last updated (US Eastern Time)")]
        [DataMember(Name = "LastUpdated", Order = 42)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The geographic latitude coordinate of this venue.
        /// </summary>
        [Description("The geographic latitude coordinate of this venue.")]
        [DataMember(Name = "GeoLat", Order = 43)]
        public decimal? GeoLat { get; set; }

        /// <summary>
        /// The geographic longitude coordinate of this venue.
        /// </summary>
        [Description("The geographic longitude coordinate of this venue.")]
        [DataMember(Name = "GeoLong", Order = 44)]
        public decimal? GeoLong { get; set; }

        /// <summary>
        /// The forecasted low temperature on game day at this venue (Fahrenheit).
        /// </summary>
        [Description("The forecasted low temperature on game day at this venue (Fahrenheit).")]
        [DataMember(Name = "ForecastTempLow", Order = 45)]
        public int? ForecastTempLow { get; set; }

        /// <summary>
        /// The forecasted high temperature on game day at this venue (Fahrenheit).
        /// </summary>
        [Description("The forecasted high temperature on game day at this venue (Fahrenheit).")]
        [DataMember(Name = "ForecastTempHigh", Order = 46)]
        public int? ForecastTempHigh { get; set; }

        /// <summary>
        /// The forecast description on game day at this venue.
        /// </summary>
        [Description("The forecast description on game day at this venue.")]
        [DataMember(Name = "ForecastDescription", Order = 47)]
        public string ForecastDescription { get; set; }

        /// <summary>
        /// The forecasted wind chill on game day at this venue.
        /// </summary>
        [Description("The forecasted wind chill on game day at this venue.")]
        [DataMember(Name = "ForecastWindChill", Order = 48)]
        public int? ForecastWindChill { get; set; }

        /// <summary>
        /// The forecasted wind speed on game day at this venue.
        /// </summary>
        [Description("The forecasted wind speed on game day at this venue.")]
        [DataMember(Name = "ForecastWindSpeed", Order = 49)]
        public int? ForecastWindSpeed { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team.
        /// </summary>
        [Description("Money line from the perspective of the away team.")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 50)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team.
        /// </summary>
        [Description("Money line from the perspective of the home team.")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 51)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// Indicates whether the game was canceled.
        /// </summary>
        [Description("Indicates whether the game was canceled.")]
        [DataMember(Name = "Canceled", Order = 52)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "Closed", Order = 53)]
        public bool? Closed { get; set; }

        /// <summary>
        /// The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.
        /// </summary>
        [Description("The description of the most recent play/event of the game. This is for display purposes and does not include corresponding data points.")]
        [DataMember(Name = "LastPlay", Order = 54)]
        public string LastPlay { get; set; }

        /// <summary>
        /// The date of the game in US Eastern Time
        /// </summary>
        [Description("The date of the game in US Eastern Time")]
        [DataMember(Name = "Day", Order = 55)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 56)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 57)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team 
        /// </summary>
        [Description("The unique ID of the home team ")]
        [DataMember(Name = "HomeTeamID", Order = 58)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 59)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 60)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 61)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the away team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the away team with the point spread")]
        [DataMember(Name = "PointSpreadAwayTeamMoneyLine", Order = 62)]
        public int? PointSpreadAwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The money line payout odds when betting on the home team with the point spread
        /// </summary>
        [Description("The money line payout odds when betting on the home team with the point spread")]
        [DataMember(Name = "PointSpreadHomeTeamMoneyLine", Order = 63)]
        public int? PointSpreadHomeTeamMoneyLine { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game
        /// </summary>
        [Description("Unique ID of the Score/Game")]
        [DataMember(Name = "ScoreID", Order = 64)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The details of the stadium where this game is played
        /// </summary>
        [Description("The details of the stadium where this game is played")]
        [DataMember(Name = "StadiumDetails", Order = 10065)]
        public Stadium StadiumDetails { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 66)]
        public string Status { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 67)]
        public DateTime? GameEndDateTime { get; set; }

    }
}

