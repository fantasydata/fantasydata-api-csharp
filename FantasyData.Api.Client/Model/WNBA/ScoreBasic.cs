using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="ScoreBasic")]
    [Serializable]
    public partial class ScoreBasic
    {
        /// <summary>
        /// The date and time that the game ended (US Eastern Time)
        /// </summary>
        [Description("The date and time that the game ended (US Eastern Time)")]
        [DataMember(Name = "GameEndDateTime", Order = 1)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength
        /// </summary>
        [Description("Contains relevant series data for playoff series only - HomeTeamWins, AwayTeamWins, GameNumber, and MaxLength")]
        [DataMember(Name = "SeriesInfo", Order = 10002)]
        public Series SeriesInfo { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game
        /// </summary>
        [Description("Total number of points the away team scored in the game")]
        [DataMember(Name = "AwayTeamScore2", Order = 3)]
        public int? AwayTeamScore2 { get; set; }

        /// <summary>
        /// Total number of points the home team scored in the game
        /// </summary>
        [Description("Total number of points the home team scored in the game")]
        [DataMember(Name = "HomeTeamScore2", Order = 4)]
        public int? HomeTeamScore2 { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 5)]
        public int GameID { get; set; }

        /// <summary>
        /// The WNBA season of the game
        /// </summary>
        [Description("The WNBA season of the game")]
        [DataMember(Name = "Season", Order = 6)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 7)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary")]
        [DataMember(Name = "Status", Order = 8)]
        public string Status { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played (US Eastern Time)
        /// </summary>
        [Description("The day that the game is scheduled to be played (US Eastern Time)")]
        [DataMember(Name = "Day", Order = 9)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 10)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 11)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 12)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 13)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 14)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 15)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game
        /// </summary>
        [Description("Total number of points the away team scored in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 16)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in the game
        /// </summary>
        [Description("Total number of points the home team scored in the game")]
        [DataMember(Name = "HomeTeamScore", Order = 17)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this record was last updated (in US Eastern time)
        /// </summary>
        [Description("The timestamp of when this record was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 18)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// A globally unique ID for the game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 19)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 20)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 21)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 22)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue")]
        [DataMember(Name = "NeutralVenue", Order = 23)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The date and time of the game in UTC
        /// </summary>
        [Description("The date and time of the game in UTC")]
        [DataMember(Name = "DateTimeUTC", Order = 24)]
        public DateTime? DateTimeUTC { get; set; }

    }
}

