using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Soccer
{
    [DataContract(Namespace="", Name="TeamDetail")]
    [Serializable]
    public partial class TeamDetail
    {
        /// <summary>
        /// The players who are current on this team's active roster/squad
        /// </summary>
        [Description("The players who are current on this team's active roster/squad")]
        [DataMember(Name = "Players", Order = 20001)]
        public Player[] Players { get; set; }

        /// <summary>
        /// The auto-generated unique ID of the Team
        /// </summary>
        [Description("The auto-generated unique ID of the Team")]
        [DataMember(Name = "TeamId", Order = 2)]
        public int TeamId { get; set; }

        /// <summary>
        /// The unique ID of the team's current home arena
        /// </summary>
        [Description("The unique ID of the team's current home arena")]
        [DataMember(Name = "AreaId", Order = 3)]
        public int? AreaId { get; set; }

        /// <summary>
        /// The unique ID of the team's current home venue
        /// </summary>
        [Description("The unique ID of the team's current home venue")]
        [DataMember(Name = "VenueId", Order = 4)]
        public int? VenueId { get; set; }

        /// <summary>
        /// Abbreviation of the team (e.g. LIV, ARS, etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. LIV, ARS, etc.)")]
        [DataMember(Name = "Key", Order = 5)]
        public string Key { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. The Reds, The Gunners, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. The Reds, The Gunners, etc.)")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The full name of the team (e.g. Liverpool Football Club, Arsenal Football Club, etc.)
        /// </summary>
        [Description("The full name of the team (e.g. Liverpool Football Club, Arsenal Football Club, etc.)")]
        [DataMember(Name = "FullName", Order = 7)]
        public string FullName { get; set; }

        /// <summary>
        /// Whether or not this team is active
        /// </summary>
        [Description("Whether or not this team is active")]
        [DataMember(Name = "Active", Order = 8)]
        public bool Active { get; set; }

        /// <summary>
        /// The area name of the home team
        /// </summary>
        [Description("The area name of the home team")]
        [DataMember(Name = "AreaName", Order = 9)]
        public string AreaName { get; set; }

        /// <summary>
        /// The venue name of the home team
        /// </summary>
        [Description("The venue name of the home team")]
        [DataMember(Name = "VenueName", Order = 10)]
        public string VenueName { get; set; }

        /// <summary>
        /// Indicates the gender of the players on this team (possible values: Make, Female)
        /// </summary>
        [Description("Indicates the gender of the players on this team (possible values: Make, Female)")]
        [DataMember(Name = "Gender", Order = 11)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of this team. Possible values: Club, National
        /// </summary>
        [Description("The type of this team. Possible values: Club, National")]
        [DataMember(Name = "Type", Order = 12)]
        public string Type { get; set; }

        /// <summary>
        /// The address of the home team
        /// </summary>
        [Description("The address of the home team")]
        [DataMember(Name = "Address", Order = 13)]
        public string Address { get; set; }

        /// <summary>
        /// The city of the home team
        /// </summary>
        [Description("The city of the home team")]
        [DataMember(Name = "City", Order = 14)]
        public string City { get; set; }

        /// <summary>
        /// The zip code of the home team
        /// </summary>
        [Description("The zip code of the home team")]
        [DataMember(Name = "Zip", Order = 15)]
        public string Zip { get; set; }

        /// <summary>
        /// The phone number of the home team
        /// </summary>
        [Description("The phone number of the home team")]
        [DataMember(Name = "Phone", Order = 16)]
        public string Phone { get; set; }

        /// <summary>
        /// The fax number of the home team
        /// </summary>
        [Description("The fax number of the home team")]
        [DataMember(Name = "Fax", Order = 17)]
        public string Fax { get; set; }

        /// <summary>
        /// The website address of the home team
        /// </summary>
        [Description("The website address of the home team")]
        [DataMember(Name = "Website", Order = 18)]
        public string Website { get; set; }

        /// <summary>
        /// The email of the home team
        /// </summary>
        [Description("The email of the home team")]
        [DataMember(Name = "Email", Order = 19)]
        public string Email { get; set; }

        /// <summary>
        /// The year the team was founded (e.g. 1950, 1960, etc.)
        /// </summary>
        [Description("The year the team was founded (e.g. 1950, 1960, etc.)")]
        [DataMember(Name = "Founded", Order = 20)]
        public int? Founded { get; set; }

        /// <summary>
        /// The primary color of this team's logo/uniform/branding
        /// </summary>
        [Description("The primary color of this team's logo/uniform/branding")]
        [DataMember(Name = "ClubColor1", Order = 21)]
        public string ClubColor1 { get; set; }

        /// <summary>
        /// The secondary color of this team's logo/uniform/branding
        /// </summary>
        [Description("The secondary color of this team's logo/uniform/branding")]
        [DataMember(Name = "ClubColor2", Order = 22)]
        public string ClubColor2 { get; set; }

        /// <summary>
        /// The tertiary color of this team's logo/uniform/branding
        /// </summary>
        [Description("The tertiary color of this team's logo/uniform/branding")]
        [DataMember(Name = "ClubColor3", Order = 23)]
        public string ClubColor3 { get; set; }

        /// <summary>
        /// A nickname for this team
        /// </summary>
        [Description("A nickname for this team")]
        [DataMember(Name = "Nickname1", Order = 24)]
        public string Nickname1 { get; set; }

        /// <summary>
        /// A nickname for this team
        /// </summary>
        [Description("A nickname for this team")]
        [DataMember(Name = "Nickname2", Order = 25)]
        public string Nickname2 { get; set; }

        /// <summary>
        /// A nickname for this team
        /// </summary>
        [Description("A nickname for this team")]
        [DataMember(Name = "Nickname3", Order = 26)]
        public string Nickname3 { get; set; }

        /// <summary>
        /// The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaLogoUrl", Order = 27)]
        public string WikipediaLogoUrl { get; set; }

        /// <summary>
        /// The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's wordmark logo hosted on Wikipedia. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaWordMarkUrl", Order = 28)]
        public string WikipediaWordMarkUrl { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamId", Order = 29)]
        public int GlobalTeamId { get; set; }

    }
}

