using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="GameInfo")]
    [Serializable]
    public partial class GameInfo
    {
        /// <summary>
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreId", Order = 1)]
        public int ScoreId { get; set; }

        /// <summary>
        /// The year of the season during which this game occurs.
        /// </summary>
        [Description("The year of the season during which this game occurs.")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The status of the game. For a description of possible values, see <a href="https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status" target="_blank">here.</a> For how suspended and postponed games are handled specifically, see <a href="https://support.sportsdata.io/hc/en-us/articles/4404845580567-Postponed-and-Rescheduled-Games" target="_blank">here</a>.
        /// </summary>
        [Description("The status of the game. For a description of possible values, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status\" target=\"_blank\">here.</a> For how suspended and postponed games are handled specifically, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/4404845580567-Postponed-and-Rescheduled-Games\" target=\"_blank\">here</a>.")]
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
        /// The name of the home team.
        /// </summary>
        [Description("The name of the home team.")]
        [DataMember(Name = "HomeTeamName", Order = 11)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameId", Order = 12)]
        public int GlobalGameId { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamId", Order = 13)]
        public int? GlobalAwayTeamId { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues")]
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
        /// The total points scored by both teams in the game tied to this event (updated after game ends to allow for resulting bets)
        /// </summary>
        [Description("The total points scored by both teams in the game tied to this event (updated after game ends to allow for resulting bets)")]
        [DataMember(Name = "TotalScore", Order = 19)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Rotation Number of home team in this game
        /// </summary>
        [Description("Rotation Number of home team in this game")]
        [DataMember(Name = "HomeRotationNumber", Order = 20)]
        public int? HomeRotationNumber { get; set; }

        /// <summary>
        /// Rotation Number of away team in this game
        /// </summary>
        [Description("Rotation Number of away team in this game")]
        [DataMember(Name = "AwayRotationNumber", Order = 21)]
        public int? AwayRotationNumber { get; set; }

        /// <summary>
        /// List of Alternate Market Pregame Odds from different sportsbooks
        /// </summary>
        [Description("List of Alternate Market Pregame Odds from different sportsbooks")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20022)]
        public GameOdd[] AlternateMarketPregameOdds { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 23)]
        public int GameId { get; set; }

    }
}

