using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="GameInfo")]
    [Serializable]
    public partial class GameInfo
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The WNBA season of the game
        /// </summary>
        [Description("The WNBA season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played (US Eastern Time)
        /// </summary>
        [Description("The day that the game is scheduled to be played (US Eastern Time)")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit; NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit; NotNecessary")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 7)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 8)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The full name of the away team (Ex. Indiana Fever, Phoenix Mercruy, New York Liberty)
        /// </summary>
        [Description("The full name of the away team (Ex. Indiana Fever, Phoenix Mercruy, New York Liberty)")]
        [DataMember(Name = "AwayTeamName", Order = 9)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The full name of the home team (Ex. Indiana Fever, Phoenix Mercruy, New York Liberty)
        /// </summary>
        [Description("The full name of the home team (Ex. Indiana Fever, Phoenix Mercruy, New York Liberty)")]
        [DataMember(Name = "HomeTeamName", Order = 10)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for the game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 11)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 12)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 13)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// List of most recent Pregame odds from different sportsbooks
        /// </summary>
        [Description("List of most recent Pregame odds from different sportsbooks")]
        [DataMember(Name = "PregameOdds", Order = 20014)]
        public GameOdd[] PregameOdds { get; set; }

        /// <summary>
        /// Total number of points the home team scored in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total number of points the home team scored in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total number of points the away team scored in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "AwayTeamScore", Order = 16)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total scored points in the game (updated after game ends to allow for resolving bets)
        /// </summary>
        [Description("Total scored points in the game (updated after game ends to allow for resolving bets)")]
        [DataMember(Name = "TotalScore", Order = 17)]
        public int? TotalScore { get; set; }

    }
}

