using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="ScheduleBasic")]
    [Serializable]
    public partial class ScheduleBasic
    {
        /// <summary>
        /// The GameID of this MLB game
        /// </summary>
        [Description("The GameID of this MLB game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int? GameID { get; set; }

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
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, Suspended, Delayed, Postponed, Canceled, Forfeit, NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, Suspended, Delayed, Postponed, Canceled, Forfeit, NotNecessary")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game
        /// </summary>
        [Description("The date and time of the game")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation of the Away Team
        /// </summary>
        [Description("The abbreviation of the Away Team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation of the Home Team
        /// </summary>
        [Description("The abbreviation of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The GameID of the game that was rescheduled from this game. This only pertains to postponed games that require rescheduling.
        /// </summary>
        [Description("The GameID of the game that was rescheduled from this game. This only pertains to postponed games that require rescheduling.")]
        [DataMember(Name = "RescheduledGameID", Order = 11)]
        public int? RescheduledGameID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 12)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out.
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out.")]
        [DataMember(Name = "IsClosed", Order = 13)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 15)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The date and time of the game in UTC.
        /// </summary>
        [Description("The date and time of the game in UTC.")]
        [DataMember(Name = "DateTimeUTC", Order = 16)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength
        /// </summary>
        [Description("Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength")]
        [DataMember(Name = "SeriesInfo", Order = 10017)]
        public Series SeriesInfo { get; set; }

        /// <summary>
        /// The GameID of the originally scheduled, postponed game, that this game was rescheduled from. This only pertains to games that are scheduled as "make up" games.
        /// </summary>
        [Description("The GameID of the originally scheduled, postponed game, that this game was rescheduled from. This only pertains to games that are scheduled as \"make up\" games.")]
        [DataMember(Name = "RescheduledFromGameID", Order = 18)]
        public int? RescheduledFromGameID { get; set; }

    }
}

