using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="ScoreBasic")]
    [Serializable]
    public partial class ScoreBasic
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The College Football season of the game
        /// </summary>
        [Description("The College Football season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The week of the game
        /// </summary>
        [Description("The week of the game")]
        [DataMember(Name = "Week", Order = 4)]
        public int? Week { get; set; }

        /// <summary>
        /// The status of the game. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit
        /// </summary>
        [Description("The status of the game. Possible values include: Scheduled; InProgress; Final; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit")]
        [DataMember(Name = "Status", Order = 5)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 6)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "DateTime", Order = 7)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 8)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 9)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 10)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 11)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The name of the away team
        /// </summary>
        [Description("The name of the away team")]
        [DataMember(Name = "AwayTeamName", Order = 12)]
        public string AwayTeamName { get; set; }

        /// <summary>
        /// The name of the home team
        /// </summary>
        [Description("The name of the home team")]
        [DataMember(Name = "HomeTeamName", Order = 13)]
        public string HomeTeamName { get; set; }

        /// <summary>
        /// Total number of points the away team scored in this game
        /// </summary>
        [Description("Total number of points the away team scored in this game")]
        [DataMember(Name = "AwayTeamScore", Order = 14)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game
        /// </summary>
        [Description("Total number of points the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 16)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when this game was first created (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was first created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 17)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// A globally unique ID for this game.  Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this game.  Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalGameID", Order = 18)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the away team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 19)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the home team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 20)]
        public int GlobalHomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium/venue where this game was played
        /// </summary>
        [Description("The unique ID of the stadium/venue where this game was played")]
        [DataMember(Name = "StadiumID", Order = 21)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified")]
        [DataMember(Name = "IsClosed", Order = 22)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The date and time that the game ended (in US Eastern Time)
        /// </summary>
        [Description("The date and time that the game ended (in US Eastern Time)")]
        [DataMember(Name = "GameEndDateTime", Order = 23)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// The title of the game (e.g. Rose Bowl, Citrus Bowl, etc)
        /// </summary>
        [Description("The title of the game (e.g. Rose Bowl, Citrus Bowl, etc)")]
        [DataMember(Name = "Title", Order = 24)]
        public string Title { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue")]
        [DataMember(Name = "NeutralVenue", Order = 25)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The date and time of the game (in UTC)
        /// </summary>
        [Description("The date and time of the game (in UTC)")]
        [DataMember(Name = "DateTimeUTC", Order = 26)]
        public DateTime? DateTimeUTC { get; set; }

    }
}

