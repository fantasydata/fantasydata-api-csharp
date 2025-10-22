using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="Game")]
    [Serializable]
    public partial class Game
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
        /// Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit; NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit; NotNecessary")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played (US Eastern Time)
        /// </summary>
        [Description("The day that the game is scheduled to be played (US Eastern Time)")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 11)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game
        /// </summary>
        [Description("Total number of points the away team scored in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 12)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in the game
        /// </summary>
        [Description("Total number of points the home team scored in the game")]
        [DataMember(Name = "HomeTeamScore", Order = 13)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this record was last updated (in US Eastern time)
        /// </summary>
        [Description("The timestamp of when this record was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The current quarter in the game. Possible values include: 1, 2, 3, 4, Half, OT, NULL
        /// </summary>
        [Description("The current quarter in the game. Possible values include: 1, 2, 3, 4, Half, OT, NULL")]
        [DataMember(Name = "Quarter", Order = 15)]
        public string Quarter { get; set; }

        /// <summary>
        /// Number of minutes remaining in the quarter
        /// </summary>
        [Description("Number of minutes remaining in the quarter")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 16)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds remaining in the quarter
        /// </summary>
        [Description("Number of seconds remaining in the quarter")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 17)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// A globally unique ID for the game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 18)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 19)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 20)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The details of the quarters (including overtime periods) for this game.
        /// </summary>
        [Description("The details of the quarters (including overtime periods) for this game.")]
        [DataMember(Name = "Quarters", Order = 20021)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// Money line from the perspective of the home team
        /// </summary>
        [Description("Money line from the perspective of the home team")]
        [DataMember(Name = "HomeTeamMoneyLine", Order = 22)]
        public int? HomeTeamMoneyLine { get; set; }

        /// <summary>
        /// Money line from the perspective of the away team
        /// </summary>
        [Description("Money line from the perspective of the away team")]
        [DataMember(Name = "AwayTeamMoneyLine", Order = 23)]
        public int? AwayTeamMoneyLine { get; set; }

        /// <summary>
        /// The point spread (as listed for the home team)
        /// </summary>
        [Description("The point spread (as listed for the home team)")]
        [DataMember(Name = "PointSpread", Order = 24)]
        public decimal? PointSpread { get; set; }

        /// <summary>
        /// The payout for the home team beating the spread
        /// </summary>
        [Description("The payout for the home team beating the spread")]
        [DataMember(Name = "PointSpreadHomeTeamPayout", Order = 25)]
        public int? PointSpreadHomeTeamPayout { get; set; }

        /// <summary>
        /// The payout for the away team beating the spread
        /// </summary>
        [Description("The payout for the away team beating the spread")]
        [DataMember(Name = "PointSpreadAwayTeamPayout", Order = 26)]
        public int? PointSpreadAwayTeamPayout { get; set; }

        /// <summary>
        /// The sportsbook's total points scored over or under for the game. Note: this is also known as the Total for the game.
        /// </summary>
        [Description("The sportsbook's total points scored over or under for the game. Note: this is also known as the Total for the game.")]
        [DataMember(Name = "OverUnder", Order = 27)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over
        /// </summary>
        [Description("The sportsbook's payout for the over")]
        [DataMember(Name = "OverPayout", Order = 28)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 29)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 30)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The date and time that the game ended (US Eastern Time)
        /// </summary>
        [Description("The date and time that the game ended (US Eastern Time)")]
        [DataMember(Name = "GameEndDateTime", Order = 31)]
        public DateTime? GameEndDateTime { get; set; }

    }
}

