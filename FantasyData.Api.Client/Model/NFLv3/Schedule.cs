using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Schedule")]
    [Serializable]
    public partial class Schedule
    {
        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 1)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 5)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 6)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 7)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The television station broadcasting the game
        /// </summary>
        [Description("The television station broadcasting the game")]
        [DataMember(Name = "Channel", Order = 8)]
        public string Channel { get; set; }

        /// <summary>
        /// The oddsmaker point spread at game start from the perspective of the team (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)
        /// </summary>
        [Description("The oddsmaker point spread at game start from the perspective of the team (negative numbers indicate the HomeTeam is favored; positive numbers indicate the AwayTeam is favored)")]
        [DataMember(Name = "PointSpread", Order = 9)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The total points line (over/under) at game start
        /// </summary>
        [Description("The total points line (over/under) at game start")]
        [DataMember(Name = "OverUnder", Order = 10)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The unique ID of the team's current home stadium
        /// </summary>
        [Description("The unique ID of the team's current home stadium")]
        [DataMember(Name = "StadiumID", Order = 11)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Indicates whether the game was canceled
        /// </summary>
        [Description("Indicates whether the game was canceled")]
        [DataMember(Name = "Canceled", Order = 12)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// The geographic latitude coordinate of the venue where the game is taking place
        /// </summary>
        [Description("The geographic latitude coordinate of the venue where the game is taking place")]
        [DataMember(Name = "GeoLat", Order = 13)]
        public decimal? GeoLat { get; set; }

        /// <summary>
        /// The geographic longitude coordinate of the venue where the game is taking place
        /// </summary>
        [Description("The geographic longitude coordinate of the venue where the game is taking place")]
        [DataMember(Name = "GeoLong", Order = 14)]
        public decimal? GeoLong { get; set; }

        /// <summary>
        /// The forecasted low temperature on game day at this venue (Fahrenheit).
        /// </summary>
        [Description("The forecasted low temperature on game day at this venue (Fahrenheit).")]
        [DataMember(Name = "ForecastTempLow", Order = 15)]
        public int? ForecastTempLow { get; set; }

        /// <summary>
        /// The forecasted high temperature on game day at this venue (Fahrenheit).
        /// </summary>
        [Description("The forecasted high temperature on game day at this venue (Fahrenheit).")]
        [DataMember(Name = "ForecastTempHigh", Order = 16)]
        public int? ForecastTempHigh { get; set; }

        /// <summary>
        /// The forecast description on game day at this venue.
        /// </summary>
        [Description("The forecast description on game day at this venue.")]
        [DataMember(Name = "ForecastDescription", Order = 17)]
        public string ForecastDescription { get; set; }

        /// <summary>
        /// The forecasted wind chill on game day at this venue.
        /// </summary>
        [Description("The forecasted wind chill on game day at this venue.")]
        [DataMember(Name = "ForecastWindChill", Order = 18)]
        public int? ForecastWindChill { get; set; }

        /// <summary>
        /// The forecasted wind speed on game day at this venue.
        /// </summary>
        [Description("The forecasted wind speed on game day at this venue.")]
        [DataMember(Name = "ForecastWindSpeed", Order = 19)]
        public int? ForecastWindSpeed { get; set; }

        /// <summary>
        /// The sportsbook's moneyline for the away team
        /// </summary>
        [Description("The sportsbook's moneyline for the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 20)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's moneyline for the home team
        /// </summary>
        [Description("The sportsbook's moneyline for the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 21)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 22)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 23)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 24)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 25)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 26)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 27)]
        public int ScoreID { get; set; }

        /// <summary>
        /// The details of the stadium where this game is played
        /// </summary>
        [Description("The details of the stadium where this game is played")]
        [DataMember(Name = "StadiumDetails", Order = 10028)]
        public Stadium StadiumDetails { get; set; }

        /// <summary>
        /// The status of the game. For a description of possible values, see <a href="https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status" target="_blank">here.</a> For how suspended and postponed games are handled specifically, see <a href="https://support.sportsdata.io/hc/en-us/articles/4404845580567-Postponed-and-Rescheduled-Games" target="_blank">here</a>.
        /// </summary>
        [Description("The status of the game. For a description of possible values, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status\" target=\"_blank\">here.</a> For how suspended and postponed games are handled specifically, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/4404845580567-Postponed-and-Rescheduled-Games\" target=\"_blank\">here</a>.")]
        [DataMember(Name = "Status", Order = 29)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 30)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// The date and time of the game (in UTC)
        /// </summary>
        [Description("The date and time of the game (in UTC)")]
        [DataMember(Name = "DateTimeUTC", Order = 31)]
        public DateTime? DateTimeUTC { get; set; }

    }
}

