using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="Standing")]
    [Serializable]
    public partial class Standing
    {
        /// <summary>
        /// The NHL regular season for which these totals apply
        /// </summary>
        [Description("The NHL regular season for which these totals apply")]
        [DataMember(Name = "Season", Order = 1)]
        public int Season { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The unique ID for the team
        /// </summary>
        [Description("The unique ID for the team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// Whether or not the team is active
        /// </summary>
        [Description("Whether or not the team is active")]
        [DataMember(Name = "Key", Order = 4)]
        public string Key { get; set; }

        /// <summary>
        /// The name of the city
        /// </summary>
        [Description("The name of the city")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of the team (Eastern or Western)
        /// </summary>
        [Description("The conference of the team (Eastern or Western)")]
        [DataMember(Name = "Conference", Order = 7)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. Atlantic, Metropolitan, Central, or Pacific))
        /// </summary>
        [Description("The division of the team (e.g. Atlantic, Metropolitan, Central, or Pacific))")]
        [DataMember(Name = "Division", Order = 8)]
        public string Division { get; set; }

        /// <summary>
        /// Regular season wins
        /// </summary>
        [Description("Regular season wins")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// Regular season losses
        /// </summary>
        [Description("Regular season losses")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// Regular season overtime losses
        /// </summary>
        [Description("Regular season overtime losses")]
        [DataMember(Name = "OvertimeLosses", Order = 11)]
        public int? OvertimeLosses { get; set; }

        /// <summary>
        /// Winning percentage
        /// </summary>
        [Description("Winning percentage")]
        [DataMember(Name = "Percentage", Order = 12)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Regular season conference wins
        /// </summary>
        [Description("Regular season conference wins")]
        [DataMember(Name = "ConferenceWins", Order = 13)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// Regular season conference losses
        /// </summary>
        [Description("Regular season conference losses")]
        [DataMember(Name = "ConferenceLosses", Order = 14)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// Regular season division wins
        /// </summary>
        [Description("Regular season division wins")]
        [DataMember(Name = "DivisionWins", Order = 15)]
        public int? DivisionWins { get; set; }

        /// <summary>
        /// Regular season division wins
        /// </summary>
        [Description("Regular season division wins")]
        [DataMember(Name = "DivisionLosses", Order = 16)]
        public int? DivisionLosses { get; set; }

        /// <summary>
        /// Regular season shutout wins
        /// </summary>
        [Description("Regular season shutout wins")]
        [DataMember(Name = "ShutoutWins", Order = 17)]
        public int? ShutoutWins { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 18)]
        public int? GlobalTeamID { get; set; }

    }
}

