using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="ScoreBasic")]
    [Serializable]
    public partial class ScoreBasic
    {
        /// <summary>
        /// Number of runs the away team scored in this game
        /// </summary>
        [Description("Number of runs the away team scored in this game")]
        [DataMember(Name = "AwayTeamRuns", Order = 1)]
        public int? AwayTeamRuns { get; set; }

        /// <summary>
        /// Number of runs the home team scored in this game
        /// </summary>
        [Description("Number of runs the home team scored in this game")]
        [DataMember(Name = "HomeTeamRuns", Order = 2)]
        public int? HomeTeamRuns { get; set; }

        /// <summary>
        /// Total away team hits in this game
        /// </summary>
        [Description("Total away team hits in this game")]
        [DataMember(Name = "AwayTeamHits", Order = 3)]
        public int? AwayTeamHits { get; set; }

        /// <summary>
        /// Total home team hits in this game
        /// </summary>
        [Description("Total home team hits in this game")]
        [DataMember(Name = "HomeTeamHits", Order = 4)]
        public int? HomeTeamHits { get; set; }

        /// <summary>
        /// Total away team errors committed in this game
        /// </summary>
        [Description("Total away team errors committed in this game")]
        [DataMember(Name = "AwayTeamErrors", Order = 5)]
        public int? AwayTeamErrors { get; set; }

        /// <summary>
        /// Total home team errors committed in this game
        /// </summary>
        [Description("Total home team errors committed in this game")]
        [DataMember(Name = "HomeTeamErrors", Order = 6)]
        public int? HomeTeamErrors { get; set; }

        /// <summary>
        /// Total number of people who attended the game
        /// </summary>
        [Description("Total number of people who attended the game")]
        [DataMember(Name = "Attendance", Order = 7)]
        public int? Attendance { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 8)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 9)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 10)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue")]
        [DataMember(Name = "NeutralVenue", Order = 11)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The inning that the game is currently in, or the inning in which the game ended. Possible values include: NULL, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, etc)
        /// </summary>
        [Description("The inning that the game is currently in, or the inning in which the game ended. Possible values include: NULL, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, etc)")]
        [DataMember(Name = "Inning", Order = 12)]
        public int? Inning { get; set; }

        /// <summary>
        /// The inning half that the game is currently in, or the inning half in which the game ended (possible values: T, B, NULL)
        /// </summary>
        [Description("The inning half that the game is currently in, or the inning half in which the game ended (possible values: T, B, NULL)")]
        [DataMember(Name = "InningHalf", Order = 13)]
        public string InningHalf { get; set; }

        /// <summary>
        /// The GameID of this MLB game
        /// </summary>
        [Description("The GameID of this MLB game")]
        [DataMember(Name = "GameID", Order = 14)]
        public int? GameID { get; set; }

        /// <summary>
        /// The MLB season of the game
        /// </summary>
        [Description("The MLB season of the game")]
        [DataMember(Name = "Season", Order = 15)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 16)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, Suspended, Delayed, Postponed, Canceled, Forfeit, NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, Suspended, Delayed, Postponed, Canceled, Forfeit, NotNecessary")]
        [DataMember(Name = "Status", Order = 17)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 18)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 19)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 20)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 21)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 22)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 23)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The GameID of the game that was rescheduled from this game. This only pertains to postponed games that require rescheduling.
        /// </summary>
        [Description("The GameID of the game that was rescheduled from this game. This only pertains to postponed games that require rescheduling.")]
        [DataMember(Name = "RescheduledGameID", Order = 24)]
        public int? RescheduledGameID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 25)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 26)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 27)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 28)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The date and time of the game in UTC.
        /// </summary>
        [Description("The date and time of the game in UTC.")]
        [DataMember(Name = "DateTimeUTC", Order = 29)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength
        /// </summary>
        [Description("Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength")]
        [DataMember(Name = "SeriesInfo", Order = 10030)]
        public Series SeriesInfo { get; set; }

        /// <summary>
        /// The GameID of the originally scheduled, postponed game, that this game was rescheduled from. This only pertains to games that are scheduled as "make up" games.
        /// </summary>
        [Description("The GameID of the originally scheduled, postponed game, that this game was rescheduled from. This only pertains to games that are scheduled as \"make up\" games.")]
        [DataMember(Name = "RescheduledFromGameID", Order = 31)]
        public int? RescheduledFromGameID { get; set; }

    }
}

