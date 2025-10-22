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
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 1)]
        public int ScoreID { get; set; }

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
        [DataMember(Name = "AwayTeamID", Order = 8)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 9)]
        public int? HomeTeamID { get; set; }

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
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 12)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 13)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues")]
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
        /// The total points scored by both teams in the game tied to this event (updated after game ends to allow for resulting bets)
        /// </summary>
        [Description("The total points scored by both teams in the game tied to this event (updated after game ends to allow for resulting bets)")]
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
        /// List of Alternate Market Pregame Odds from different sportsbooks with results
        /// </summary>
        [Description("List of Alternate Market Pregame Odds from different sportsbooks with results")]
        [DataMember(Name = "AlternateMarketPregameOdds", Order = 20021)]
        public GameOddResult[] AlternateMarketPregameOdds { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 22)]
        public int GameID { get; set; }

        /// <summary>
        /// The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)
        /// </summary>
        [Description("The current quarter of the game (1, 2, 3, 4, Half, OT, F, F/OT or NULL if game has not yet started)")]
        [DataMember(Name = "Quarter", Order = 23)]
        public string Quarter { get; set; }

        /// <summary>
        /// The amount of time remaining in the current quarter (e.g. 11:23; 5:34; NULL if game is not in progress or at halftime)
        /// </summary>
        [Description("The amount of time remaining in the current quarter (e.g. 11:23; 5:34; NULL if game is not in progress or at halftime)")]
        [DataMember(Name = "TimeRemaining", Order = 24)]
        public string TimeRemaining { get; set; }

        /// <summary>
        /// Points scored by the away team in Quarter 1
        /// </summary>
        [Description("Points scored by the away team in Quarter 1")]
        [DataMember(Name = "AwayScoreQuarter1", Order = 25)]
        public int? AwayScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored by the away team in Quarter 2
        /// </summary>
        [Description("Points scored by the away team in Quarter 2")]
        [DataMember(Name = "AwayScoreQuarter2", Order = 26)]
        public int? AwayScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored by the away team in Quarter 3
        /// </summary>
        [Description("Points scored by the away team in Quarter 3")]
        [DataMember(Name = "AwayScoreQuarter3", Order = 27)]
        public int? AwayScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored by the away team in Quarter 4
        /// </summary>
        [Description("Points scored by the away team in Quarter 4")]
        [DataMember(Name = "AwayScoreQuarter4", Order = 28)]
        public int? AwayScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored by the away team in overtime
        /// </summary>
        [Description("Points scored by the away team in overtime")]
        [DataMember(Name = "AwayScoreOvertime", Order = 29)]
        public int? AwayScoreOvertime { get; set; }

        /// <summary>
        /// Points scored by the home team in Quarter 1
        /// </summary>
        [Description("Points scored by the home team in Quarter 1")]
        [DataMember(Name = "HomeScoreQuarter1", Order = 30)]
        public int? HomeScoreQuarter1 { get; set; }

        /// <summary>
        /// Points scored by the home team in Quarter 2
        /// </summary>
        [Description("Points scored by the home team in Quarter 2")]
        [DataMember(Name = "HomeScoreQuarter2", Order = 31)]
        public int? HomeScoreQuarter2 { get; set; }

        /// <summary>
        /// Points scored by the home team in Quarter 3
        /// </summary>
        [Description("Points scored by the home team in Quarter 3")]
        [DataMember(Name = "HomeScoreQuarter3", Order = 32)]
        public int? HomeScoreQuarter3 { get; set; }

        /// <summary>
        /// Points scored by the home team in Quarter 4
        /// </summary>
        [Description("Points scored by the home team in Quarter 4")]
        [DataMember(Name = "HomeScoreQuarter4", Order = 33)]
        public int? HomeScoreQuarter4 { get; set; }

        /// <summary>
        /// Points scored by the home team in overtime
        /// </summary>
        [Description("Points scored by the home team in overtime")]
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

