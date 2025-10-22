using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="GameInfo")]
    [Serializable]
    public partial class GameInfo
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 1)]
        public int GameId { get; set; }

        /// <summary>
        /// The college football season of the game
        /// </summary>
        [Description("The college football season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The week of the game
        /// </summary>
        [Description("The week of the game")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The status of the game. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit
        /// </summary>
        [Description("The status of the game. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit")]
        [DataMember(Name = "Status", Order = 7)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamId", Order = 8)]
        public int? AwayTeamId { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamId", Order = 9)]
        public int? HomeTeamId { get; set; }

        /// <summary>
        /// The name of the away team
        /// </summary>
        [Description("The name of the away team")]
        [DataMember(Name = "AwayTeamName", Order = 10)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The name of the home team
        /// </summary>
        [Description("The name of the home team")]
        [DataMember(Name = "HomeTeamName", Order = 11)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game.  Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game.  Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameId", Order = 12)]
        public int GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamId", Order = 13)]
        public int? GlobalAwayTeamId { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalHomeTeamId", Order = 14)]
        public int? GlobalHomeTeamId { get; set; }

        /// <summary>
        /// List of Pregame Odds from different sportsbooks
        /// </summary>
        [Description("List of Pregame Odds from different sportsbooks")]
        [DataMember(Name = "PregameOdds", Order = 20015)]
        public GameOdd[] PregameOdds { get; set; }

        /// <summary>
        /// List of Live Odds from different sportsbooks
        /// </summary>
        [Description("List of Live Odds from different sportsbooks")]
        [DataMember(Name = "LiveOdds", Order = 20016)]
        public GameOdd[] LiveOdds { get; set; }

        /// <summary>
        /// Score of the home team (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the home team (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 17)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Score of the away team (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Score of the away team (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 18)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The total points scored by both teams in the game tied to this event (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("The total points scored by both teams in the game tied to this event (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "TotalScore", Order = 19)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation number of home team for this game
        /// </summary>
        [Description("Rotation number of home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 20)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// Rotation number of away team for this game
        /// </summary>
        [Description("Rotation number of away team for this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 21)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// List of Alternate Market Pregame Odds from different sportsbooks
        /// </summary>
        [Description("List of Alternate Market Pregame Odds from different sportsbooks")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20022)]
        public GameOdd[] AlternateMarketPregameOdds { get; set; }

    }
}

