using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="Team")]
    [Serializable]
    public partial class Team
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// A unique abbreviation of the team (e.g. LA; PHX; NY; etc.).  Note: Due to being selected for uniqueness; these are not always matching broadcaster abbreviations. For that use case; use ShortDisplayName.
        /// </summary>
        [Description("A unique abbreviation of the team (e.g. LA; PHX; NY; etc.).  Note: Due to being selected for uniqueness; these are not always matching broadcaster abbreviations. For that use case; use ShortDisplayName.")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Whether or not this team is active. Note: Active = True & Inactive = False
        /// </summary>
        [Description("Whether or not this team is active. Note: Active = True & Inactive = False")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The city in which the team is located in (e.g. Los Angeles, Phoenix, New York, etc.)
        /// </summary>
        [Description("The city in which the team is located in (e.g. Los Angeles, Phoenix, New York, etc.)")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sparks, Suns, Dream, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sparks, Suns, Dream, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The conference of a given team (possible values: Eastern; Western)
        /// </summary>
        [Description("The conference of a given team (possible values: Eastern; Western)")]
        [DataMember(Name = "Conference", Order = 6)]
        public string Conference { get; set; }

        /// <summary>
        /// The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaLogoUrl", Order = 7)]
        public string WikipediaLogoUrl { get; set; }

        /// <summary>
        /// A globally unique ID for the team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for the team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 8)]
        public int GlobalTeamID { get; set; }

    }
}

