using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="ScheduleBasic")]
    [Serializable]
    public partial class ScheduleBasic
    {
        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int? GameID { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 2)]
        public int? GlobalGameID { get; set; }

        /// <summary>
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreID", Order = 3)]
        public int? ScoreID { get; set; }

        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameKey is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameKey is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 4)]
        public string GameKey { get; set; }

        /// <summary>
        /// The NFL season of the game
        /// </summary>
        [Description("The NFL season of the game")]
        [DataMember(Name = "Season", Order = 5)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 6)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The status of the game. For a description of possible values, see <a href="https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status" target="_blank">here.</a> For how suspended and postponed games are handled specifically, see <a href="https://support.sportsdata.io/hc/en-us/articles/4404845580567-Postponed-and-Rescheduled-Games" target="_blank">here</a>.
        /// </summary>
        [Description("The status of the game. For a description of possible values, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status\" target=\"_blank\">here.</a> For how suspended and postponed games are handled specifically, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/4404845580567-Postponed-and-Rescheduled-Games\" target=\"_blank\">here</a>.")]
        [DataMember(Name = "Status", Order = 7)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the game was canceled.
        /// </summary>
        [Description("Indicates whether the game was canceled.")]
        [DataMember(Name = "Canceled", Order = 8)]
        public bool? Canceled { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 9)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The date of the game (in US Eastern Time)
        /// </summary>
        [Description("The date of the game (in US Eastern Time)")]
        [DataMember(Name = "Day", Order = 10)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 11)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The date and time of the game (in UTC)
        /// </summary>
        [Description("The date and time of the game (in UTC)")]
        [DataMember(Name = "DateTimeUTC", Order = 12)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 13)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 14)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 15)]
        public int? GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 16)]
        public int? GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 17)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 18)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the team's current home stadium
        /// </summary>
        [Description("The unique ID of the team's current home stadium")]
        [DataMember(Name = "StadiumID", Order = 19)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "Closed", Order = 20)]
        public bool? Closed { get; set; }

        /// <summary>
        /// The date and time that this game was last updated (in US Eastern Time)
        /// </summary>
        [Description("The date and time that this game was last updated (in US Eastern Time)")]
        [DataMember(Name = "LastUpdated", Order = 21)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 22)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks
        /// </summary>
        [Description("The NFL week of the game (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have only 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 23)]
        public int Week { get; set; }

    }
}

