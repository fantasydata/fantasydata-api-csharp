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
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 5=AllStar; 6=Exhibition).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team associated with this market (Ex. BOS, EDM, LAK)
        /// </summary>
        [Description("The abbreviation [Key] of the team associated with this market (Ex. BOS, EDM, LAK)")]
        [DataMember(Name = "Key", Order = 4)]
        public string Key { get; set; }

        /// <summary>
        /// The city/location of the team (e.g. Los Angeles; Philadelphia; Boston; Chicago; etc.)
        /// </summary>
        [Description("The city/location of the team (e.g. Los Angeles; Philadelphia; Boston; Chicago; etc.)")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// The team's full name (ex. Minnesota Wild; New York Islanders)
        /// </summary>
        [Description("The team's full name (ex. Minnesota Wild; New York Islanders)")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of the team (possible values: Eastern; Western)
        /// </summary>
        [Description("The conference of the team (possible values: Eastern; Western)")]
        [DataMember(Name = "Conference", Order = 7)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. Atlantic; Metropolitan; Central; or Pacific)
        /// </summary>
        [Description("The division of the team (e.g. Atlantic; Metropolitan; Central; or Pacific)")]
        [DataMember(Name = "Division", Order = 8)]
        public string Division { get; set; }

        /// <summary>
        /// Total number of wins by the team in the season
        /// </summary>
        [Description("Total number of wins by the team in the season")]
        [DataMember(Name = "Wins", Order = 9)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total losses for a team in the regular season
        /// </summary>
        [Description("Total losses for a team in the regular season")]
        [DataMember(Name = "Losses", Order = 10)]
        public int? Losses { get; set; }

        /// <summary>
        /// Total overtime losses by the team in the season
        /// </summary>
        [Description("Total overtime losses by the team in the season")]
        [DataMember(Name = "OvertimeLosses", Order = 11)]
        public int? OvertimeLosses { get; set; }

        /// <summary>
        /// The team's winning percentage
        /// </summary>
        [Description("The team's winning percentage")]
        [DataMember(Name = "Percentage", Order = 12)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Total number of conference wins for a team
        /// </summary>
        [Description("Total number of conference wins for a team")]
        [DataMember(Name = "ConferenceWins", Order = 13)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// Total number of conference losses for a team
        /// </summary>
        [Description("Total number of conference losses for a team")]
        [DataMember(Name = "ConferenceLosses", Order = 14)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// Total number of division wins by the team
        /// </summary>
        [Description("Total number of division wins by the team")]
        [DataMember(Name = "DivisionWins", Order = 15)]
        public int? DivisionWins { get; set; }

        /// <summary>
        /// Total number of division losses by the team
        /// </summary>
        [Description("Total number of division losses by the team")]
        [DataMember(Name = "DivisionLosses", Order = 16)]
        public int? DivisionLosses { get; set; }

        /// <summary>
        /// Total regular season shutout wins by the team
        /// </summary>
        [Description("Total regular season shutout wins by the team")]
        [DataMember(Name = "ShutoutWins", Order = 17)]
        public int? ShutoutWins { get; set; }

        /// <summary>
        /// Team rank at the conference level
        /// </summary>
        [Description("Team rank at the conference level")]
        [DataMember(Name = "ConferenceRank", Order = 18)]
        public int? ConferenceRank { get; set; }

        /// <summary>
        /// Team rank at the division level
        /// </summary>
        [Description("Team rank at the division level")]
        [DataMember(Name = "DivisionRank", Order = 19)]
        public int? DivisionRank { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 20)]
        public int? GlobalTeamID { get; set; }

    }
}

