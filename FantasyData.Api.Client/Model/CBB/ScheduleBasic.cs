using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="ScheduleBasic")]
    [Serializable]
    public partial class ScheduleBasic
    {
        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The season that the game occurs in. Note: season is a single year that the majority of the season occurs in
        /// </summary>
        [Description("The season that the game occurs in. Note: season is a single year that the majority of the season occurs in")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in
        /// </summary>
        [Description("The day that the game is scheduled to be played in")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
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
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 10)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// Total number of points the away team scored in the game
        /// </summary>
        [Description("Total number of points the away team scored in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 11)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of points the home team scored in this game
        /// </summary>
        [Description("Total number of points the home team scored in this game")]
        [DataMember(Name = "HomeTeamScore", Order = 12)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The timestamp of when this game was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when this game was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalGameID", Order = 14)]
        public int GlobalGameID { get; set; }

        /// <summary>
        /// The unique ID of the tournament Note: this field is specific to the NCAA tournament & does not include other tournaments
        /// </summary>
        [Description("The unique ID of the tournament Note: this field is specific to the NCAA tournament & does not include other tournaments")]
        [DataMember(Name = "TournamentID", Order = 15)]
        public int? TournamentID { get; set; }

        /// <summary>
        /// The specific bracket of the tournament (e.g. East; West; Midwest; South)
        /// </summary>
        [Description("The specific bracket of the tournament (e.g. East; West; Midwest; South)")]
        [DataMember(Name = "Bracket", Order = 16)]
        public string Bracket { get; set; }

        /// <summary>
        /// The current round of the NCAA tournament. Rounds: 1 = Round of 64, 2 = Round of 32, 3 = Sweet Sixteen, 4 = Elite Eight, 5 = Final Four, 6 = Championship Note: First Four games Round = NULL
        /// </summary>
        [Description("The current round of the NCAA tournament. Rounds: 1 = Round of 64, 2 = Round of 32, 3 = Sweet Sixteen, 4 = Elite Eight, 5 = Final Four, 6 = Championship Note: First Four games Round = NULL")]
        [DataMember(Name = "Round", Order = 17)]
        public int? Round { get; set; }

        /// <summary>
        /// The seed of the away team (1-16). Note: specific to the NCAA tournament & does not include other tournaments
        /// </summary>
        [Description("The seed of the away team (1-16). Note: specific to the NCAA tournament & does not include other tournaments")]
        [DataMember(Name = "AwayTeamSeed", Order = 18)]
        public int? AwayTeamSeed { get; set; }

        /// <summary>
        /// The seed of the home team (1-16). this is specific to the NCAA tournament & does not include other tournaments
        /// </summary>
        [Description("The seed of the home team (1-16). this is specific to the NCAA tournament & does not include other tournaments")]
        [DataMember(Name = "HomeTeamSeed", Order = 19)]
        public int? HomeTeamSeed { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out. Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 20)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// The date and time that the game ended (in US Eastern Time)
        /// </summary>
        [Description("The date and time that the game ended (in US Eastern Time)")]
        [DataMember(Name = "GameEndDateTime", Order = 21)]
        public DateTime? GameEndDateTime { get; set; }

        /// <summary>
        /// Indicates whether this game is played in a neutral venue. Note: Neutral = True, Not Neutral = False
        /// </summary>
        [Description("Indicates whether this game is played in a neutral venue. Note: Neutral = True, Not Neutral = False")]
        [DataMember(Name = "NeutralVenue", Order = 22)]
        public bool? NeutralVenue { get; set; }

        /// <summary>
        /// The date and time of the game in UTC
        /// </summary>
        [Description("The date and time of the game in UTC")]
        [DataMember(Name = "DateTimeUTC", Order = 23)]
        public DateTime? DateTimeUTC { get; set; }

        /// <summary>
        /// A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the away team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalAwayTeamID", Order = 24)]
        public int GlobalAwayTeamID { get; set; }

        /// <summary>
        /// A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the home team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalHomeTeamID", Order = 25)]
        public int GlobalHomeTeamID { get; set; }

    }
}

