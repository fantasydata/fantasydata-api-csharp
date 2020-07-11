using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NBA
{
    [DataContract(Namespace="", Name="Team")]
    [Serializable]
    public partial class Team
    {
        /// <summary>
        /// The auto-generated unique ID of the Team
        /// </summary>
        [Description("The auto-generated unique ID of the Team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// Abbreviation of the team (e.g. LAL, PHI, BOS, CHI, etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. LAL, PHI, BOS, CHI, etc.)")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Whether or not this team is active
        /// </summary>
        [Description("Whether or not this team is active")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The city/location of the team (e.g. Los Angeles, Philadelphia, Boston, Chicago, etc.)
        /// </summary>
        [Description("The city/location of the team (e.g. Los Angeles, Philadelphia, Boston, Chicago, etc.)")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Lakers, 76ers, Celtics, Bulls, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Lakers, 76ers, Celtics, Bulls, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The league of the team (possible values: Eastern, Western)
        /// </summary>
        [Description("The league of the team (possible values: Eastern, Western)")]
        [DataMember(Name = "LeagueID", Order = 6)]
        public int? LeagueID { get; set; }

        /// <summary>
        /// The unique ID of the team's current home stadium
        /// </summary>
        [Description("The unique ID of the team's current home stadium")]
        [DataMember(Name = "StadiumID", Order = 7)]
        public int? StadiumID { get; set; }

        /// <summary>
        /// The conference of the team (possible values: Eastern, Western)
        /// </summary>
        [Description("The conference of the team (possible values: Eastern, Western)")]
        [DataMember(Name = "Conference", Order = 8)]
        public string Conference { get; set; }

        /// <summary>
        /// The division of the team (e.g. Atlantic, Central, Southeast, etc)
        /// </summary>
        [Description("The division of the team (e.g. Atlantic, Central, Southeast, etc)")]
        [DataMember(Name = "Division", Order = 9)]
        public string Division { get; set; }

        /// <summary>
        /// The team's primary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's primary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "PrimaryColor", Order = 10)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The team's secondary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's secondary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "SecondaryColor", Order = 11)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The team's tertiary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's tertiary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "TertiaryColor", Order = 12)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The team's quaternary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's quaternary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "QuaternaryColor", Order = 13)]
        public string QuaternaryColor { get; set; }

        /// <summary>
        /// The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaLogoUrl", Order = 14)]
        public string WikipediaLogoUrl { get; set; }

        /// <summary>
        /// The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaWordMarkUrl", Order = 15)]
        public string WikipediaWordMarkUrl { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 16)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The team's ID on nba dot com
        /// </summary>
        [Description("The team's ID on nba dot com")]
        [DataMember(Name = "NbaDotComTeamID", Order = 17)]
        public int? NbaDotComTeamID { get; set; }

    }
}

