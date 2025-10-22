using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="StartingGoaltenders")]
    [Serializable]
    public partial class StartingGoaltenders
    {
        /// <summary>
        /// The unique ID of the game tied to the StartingGoaltenders
        /// </summary>
        [Description("The unique ID of the game tied to the StartingGoaltenders")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The end year of season (2021-22 would be 2022)
        /// </summary>
        [Description("The end year of season (2021-22 would be 2022)")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date and time of the game in US Eastern Time
        /// </summary>
        [Description("The date and time of the game in US Eastern Time")]
        [DataMember(Name = "DateTime", Order = 5)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/SO; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit
        /// </summary>
        [Description("Indicates the game's status. Possible values include: Scheduled; InProgress; Final; F/SO; F/OT; Suspended; Postponed; Delayed; Canceled; Forfeit")]
        [DataMember(Name = "Status", Order = 6)]
        public string Status { get; set; }

        /// <summary>
        /// The unique ID of the home team tied to these StartingGoaltenders
        /// </summary>
        [Description("The unique ID of the home team tied to these StartingGoaltenders")]
        [DataMember(Name = "HomeTeamID", Order = 7)]
        public int? HomeTeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The unique ID of the away team as it relates to the starting goaltenders
        /// </summary>
        [Description("The unique ID of the away team as it relates to the starting goaltenders")]
        [DataMember(Name = "AwayTeamID", Order = 9)]
        public int? AwayTeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 10)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The information of the home goaltender (PlayerID, TeamID, Team, First & Last Name, Jersey Number, Confirmed)
        /// </summary>
        [Description("The information of the home goaltender (PlayerID, TeamID, Team, First & Last Name, Jersey Number, Confirmed)")]
        [DataMember(Name = "HomeGoaltender", Order = 10011)]
        public Goaltender HomeGoaltender { get; set; }

        /// <summary>
        /// The information of the away goaltender (PlayerID, TeamID, Team, First & Last Name, Jersey Number, Confirmed)
        /// </summary>
        [Description("The information of the away goaltender (PlayerID, TeamID, Team, First & Last Name, Jersey Number, Confirmed)")]
        [DataMember(Name = "AwayGoaltender", Order = 10012)]
        public Goaltender AwayGoaltender { get; set; }

    }
}

