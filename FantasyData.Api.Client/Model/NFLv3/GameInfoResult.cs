using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="GameInfoResult")]
    [Serializable]
    public partial class GameInfoResult
    {
        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreID", Order = 1)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The calendar year of the season during which this game occurs.
        /// </summary>
        [Description("The calendar year of the season during which this game occurs.")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The week during the season/round in which this game occurs.
        /// </summary>
        [Description("The week during the season/round in which this game occurs.")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played.
        /// </summary>
        [Description("The day that the game is scheduled to be played.")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time that the game is scheduled to be played.
        /// </summary>
        [Description("The date/time that the game is scheduled to be played.")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit")]
        [DataMember(Name = "Status", Order = 7)]
        public string Status { get; set; }

        /// <summary>
        /// The TeamId of the away team.
        /// </summary>
        [Description("The TeamId of the away team.")]
        [DataMember(Name = "AwayTeamID", Order = 8)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The TeamId of the home team.
        /// </summary>
        [Description("The TeamId of the home team.")]
        [DataMember(Name = "HomeTeamID", Order = 9)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The name of the away team.
        /// </summary>
        [Description("The name of the away team.")]
        [DataMember(Name = "AwayTeamName", Order = 10)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The name of the home team.
        /// </summary>
        [Description("The name of the home team.")]
        [DataMember(Name = "HomeTeamName", Order = 11)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 12)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 13)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 14)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// List of Pregame Odds from different sportsbooks with results
        /// </summary>
        [Description("List of Pregame Odds from different sportsbooks with results")]
        [DataMember(Name = "PregameOdds", Order = 20015)]
        public GameOddResult[] PregameOdds { get; set; }

        /// <summary>
        /// Score of the home team (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the home team (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 16)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Score of the away team (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the away team (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 17)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total scored points in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total scored points in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "TotalScore", Order = 18)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation Number of home team in this game
        /// </summary>
        [Description("Rotation Number of home team in this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 19)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// Rotation Number of away team in this game
        /// </summary>
        [Description("Rotation Number of away team in this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 20)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// List of Alternate Market Pregame odds from different sportsbooks (such as 1st-half, 1st-qtr, etc)
        /// </summary>
        [Description("List of Alternate Market Pregame odds from different sportsbooks (such as 1st-half, 1st-qtr, etc)")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20021)]
        public GameOddResult[] AlternateMarketPregameOdds { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game (identical to ScoreID but using the updated naming)
        /// </summary>
        [Description("Unique ID of the Score/Game (identical to ScoreID but using the updated naming)")]
        [DataMember(Name = "GameID", Order = 22)]
        public int GameID { get; set; }

        /// <summary>
        /// The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)
        /// </summary>
        [Description("The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)")]
        [DataMember(Name = "Quarter", Order = 23)]
        public string Quarter { get; set; }

        /// <summary>
        /// The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The amount of time remaining in the current quarter (11:23, 5:34, NULL if game is not in progress or at halftime)")]
        [DataMember(Name = "TimeRemaining", Order = 24)]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// Points scored during Quarter 1
        /// </summary>
        [Description("Points scored during Quarter 1")]
        [DataMember(Name = "AwayScoreQuarter1", Order = 25)]
        public int? AwayScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2
        /// </summary>
        [Description("Points scored during Quarter 2")]
        [DataMember(Name = "AwayScoreQuarter2", Order = 26)]
        public int? AwayScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3
        /// </summary>
        [Description("Points scored during Quarter 3")]
        [DataMember(Name = "AwayScoreQuarter3", Order = 27)]
        public int? AwayScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4
        /// </summary>
        [Description("Points scored during Quarter 4")]
        [DataMember(Name = "AwayScoreQuarter4", Order = 28)]
        public int? AwayScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime
        /// </summary>
        [Description("Points scored during Overtime")]
        [DataMember(Name = "AwayScoreOvertime", Order = 29)]
        public int? AwayScoreOvertime { get; set; }

        /// <summary>
        /// Points scored during Quarter 1
        /// </summary>
        [Description("Points scored during Quarter 1")]
        [DataMember(Name = "HomeScoreQuarter1", Order = 30)]
        public int? HomeScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored during Quarter 2
        /// </summary>
        [Description("Points scored during Quarter 2")]
        [DataMember(Name = "HomeScoreQuarter2", Order = 31)]
        public int? HomeScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored during Quarter 3
        /// </summary>
        [Description("Points scored during Quarter 3")]
        [DataMember(Name = "HomeScoreQuarter3", Order = 32)]
        public int? HomeScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored during Quarter 4
        /// </summary>
        [Description("Points scored during Quarter 4")]
        [DataMember(Name = "HomeScoreQuarter4", Order = 33)]
        public int? HomeScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored during Overtime
        /// </summary>
        [Description("Points scored during Overtime")]
        [DataMember(Name = "HomeScoreOvertime", Order = 34)]
        public int? HomeScoreOvertime { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 35)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// List of Live Odds from different sportsbooks with results
        /// </summary>
        [Description("List of Live Odds from different sportsbooks with results")]
        [DataMember(Name = "LiveOdds", Order = 20036)]
        public GameOddResult[] LiveOdds { get; set; }

    }
}

