using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
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
        /// The MLB season of the game
        /// </summary>
        [Description("The MLB season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled; InProgress; Final; Suspended; Delayed; Postponed; Canceled; Forfeit; NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled; InProgress; Final; Suspended; Delayed; Postponed; Canceled; Forfeit; NotNecessary")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique TeamID of the away team
        /// </summary>
        [Description("The unique TeamID of the away team")]
        [DataMember(Name = "AwayTeamId", Order = 7)]
        public int? AwayTeamId { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamId", Order = 8)]
        public int? HomeTeamId { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeamName", Order = 9)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeamName", Order = 10)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 11)]
        public int GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamId", Order = 12)]
        public int? GlobalAwayTeamId { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamId", Order = 13)]
        public int? GlobalHomeTeamId { get; set; }

        /// <summary>
        /// List of Pregame GameOdds from different sportsbooks
        /// </summary>
        [Description("List of Pregame GameOdds from different sportsbooks")]
        [DataMember(Name = "PregameOdds", Order = 20014)]
        public GameOdd[] PregameOdds { get; set; }

        /// <summary>
        /// Shows a list of live odds from different sportsbooks
        /// </summary>
        [Description("Shows a list of live odds from different sportsbooks")]
        [DataMember(Name = "LiveOdds", Order = 20015)]
        public GameOdd[] LiveOdds { get; set; }

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
        /// The combined scores of the home and away team of the game tied to this event (post-game)
        /// </summary>
        [Description("The combined scores of the home and away team of the game tied to this event (post-game)")]
        [DataMember(Name = "TotalScore", Order = 18)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation number of home team for this game
        /// </summary>
        [Description("Rotation number of home team for this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 19)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// Rotation number of away team for this game
        /// </summary>
        [Description("Rotation number of away team for this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 20)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// List of Alternate Market Game Odds from different sportsbooks.
        /// </summary>
        [Description("List of Alternate Market Game Odds from different sportsbooks.")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20021)]
        public GameOdd[] AlternateMarketPregameOdds { get; set; }

    }
}

