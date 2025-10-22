using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
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
        /// The season that the game occurs in. Note: season is a single year that the majority of the season occurs in.
        /// </summary>
        [Description("The season that the game occurs in. Note: season is a single year that the majority of the season occurs in.")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in
        /// </summary>
        [Description("The day that the game is scheduled to be played in")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamId", Order = 7)]
        public int? AwayTeamId { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamId", Order = 8)]
        public int? HomeTeamId { get; set; }

        /// <summary>
        /// The full name of the away team (school & mascot) (E.g. Tulane Green Wave, Memphis Tigers, Arizona State Sun Devils)
        /// </summary>
        [Description("The full name of the away team (school & mascot) (E.g. Tulane Green Wave, Memphis Tigers, Arizona State Sun Devils)")]
        [DataMember(Name = "AwayTeamName", Order = 9)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The full name of the home team (school & mascot) (E.g. Tulane Green Wave, Memphis Tigers, Arizona State Sun Devils)
        /// </summary>
        [Description("The full name of the home team (school & mascot) (E.g. Tulane Green Wave, Memphis Tigers, Arizona State Sun Devils)")]
        [DataMember(Name = "HomeTeamName", Order = 10)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameId", Order = 11)]
        public int GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
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
        /// Total number of points the home team scored in this game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total number of points the home team scored in this game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 16)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total number of points the away team scored in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 17)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The total amount of points scored in the game by both teams. Updated after the game ends to allow for resulting bets.
        /// </summary>
        [Description("The total amount of points scored in the game by both teams. Updated after the game ends to allow for resulting bets.")]
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
        /// A list of Alternate Market Pregame GameOdds from different sportsbooks
        /// </summary>
        [Description("A list of Alternate Market Pregame GameOdds from different sportsbooks")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20021)]
        public GameOdd[] AlternateMarketPregameOdds { get; set; }

    }
}

