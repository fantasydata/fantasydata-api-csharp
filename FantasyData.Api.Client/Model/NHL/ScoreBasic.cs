using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The NHL season of the game
        /// </summary>
        [Description("The NHL season of the game")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition)")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled, InProgress, Final, F/SO, F/OT, Suspended, Postponed, Delayed, Canceled, Forfeit, NotNecessary")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 6)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Indicates whether the game is over and the final score has been verified and closed out Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status
        /// </summary>
        [Description("Indicates whether the game is over and the final score has been verified and closed out Note: it is recommend for bet resulting to use IsClosed = True rather than simply Final game status")]
        [DataMember(Name = "IsClosed", Order = 8)]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 9)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 10)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team
        /// </summary>
        [Description("The unique ID of the away team")]
        [DataMember(Name = "AwayTeamID", Order = 11)]
        public int AwayTeamID { get; set; }

        /// <summary>
        /// The unique ID of the home team
        /// </summary>
        [Description("The unique ID of the home team")]
        [DataMember(Name = "HomeTeamID", Order = 12)]
        public int HomeTeamID { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 13)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// Total number of goals scored by the away team in the game
        /// </summary>
        [Description("Total number of goals scored by the away team in the game")]
        [DataMember(Name = "AwayTeamScore", Order = 14)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// Total number of goals scored by the home team in the game
        /// </summary>
        [Description("Total number of goals scored by the home team in the game")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

        /// <summary>
        /// The date and time that the game ended in US Eastern Time
        /// </summary>
        [Description("The date and time that the game ended in US Eastern Time")]
        [DataMember(Name = "GameEndDateTime", Order = 16)]
        public DateTime? GameEndDateTime { get; set; }

    }
}

