using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Team")]
    [Serializable]
    public partial class Team
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 1)]
        public int TeamId { get; set; }

        /// <summary>
        /// The unique ID of the team's current home arena
        /// </summary>
        [Description("The unique ID of the team's current home arena")]
        [DataMember(Name = "AreaId", Order = 2)]
        public int? AreaId { get; set; }

        /// <summary>
        /// The unique ID of the team's venue
        /// </summary>
        [Description("The unique ID of the team's venue")]
        [DataMember(Name = "VenueId", Order = 3)]
        public int? VenueId { get; set; }

        /// <summary>
        /// Abbreviation of the team (e.g. LIV; ARS; MNU; etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. LIV; ARS; MNU; etc.)")]
        [DataMember(Name = "Key", Order = 4)]
        public string Key { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. The Reds, The Gunners, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. The Reds, The Gunners, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The full name of the team (e.g. Liverpool Football Club, Arsenal Football Club, etc.)
        /// </summary>
        [Description("The full name of the team (e.g. Liverpool Football Club, Arsenal Football Club, etc.)")]
        [DataMember(Name = "FullName", Order = 6)]
        public string FullName { get; set; }

        /// <summary>
        /// Whether or not this team is active (true/false)
        /// </summary>
        [Description("Whether or not this team is active (true/false)")]
        [DataMember(Name = "Active", Order = 7)]
        public bool Active { get; set; }

        /// <summary>
        /// The area name of the home team
        /// </summary>
        [Description("The area name of the home team")]
        [DataMember(Name = "AreaName", Order = 8)]
        public string AreaName { get; set; }

        /// <summary>
        /// The name of the home team's venue
        /// </summary>
        [Description("The name of the home team's venue")]
        [DataMember(Name = "VenueName", Order = 9)]
        public string VenueName { get; set; }

        /// <summary>
        /// The gender of the players on the team. Possible Values: Male; Female
        /// </summary>
        [Description("The gender of the players on the team. Possible Values: Male; Female")]
        [DataMember(Name = "Gender", Order = 10)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of this team. Possible values: Club, National
        /// </summary>
        [Description("The type of this team. Possible values: Club, National")]
        [DataMember(Name = "Type", Order = 11)]
        public string Type { get; set; }

        /// <summary>
        /// The address of the home team
        /// </summary>
        [Description("The address of the home team")]
        [DataMember(Name = "Address", Order = 12)]
        public string Address { get; set; }

        /// <summary>
        /// The city of the home team
        /// </summary>
        [Description("The city of the home team")]
        [DataMember(Name = "City", Order = 13)]
        public string City { get; set; }

        /// <summary>
        /// The zip code of the team's home location
        /// </summary>
        [Description("The zip code of the team's home location")]
        [DataMember(Name = "Zip", Order = 14)]
        public string Zip { get; set; }

        /// <summary>
        /// The phone number of the home team
        /// </summary>
        [Description("The phone number of the home team")]
        [DataMember(Name = "Phone", Order = 15)]
        public string Phone { get; set; }

        /// <summary>
        /// The fax number of the home team
        /// </summary>
        [Description("The fax number of the home team")]
        [DataMember(Name = "Fax", Order = 16)]
        public string Fax { get; set; }

        /// <summary>
        /// The website address of the home team
        /// </summary>
        [Description("The website address of the home team")]
        [DataMember(Name = "Website", Order = 17)]
        public string Website { get; set; }

        /// <summary>
        /// The email of the home team
        /// </summary>
        [Description("The email of the home team")]
        [DataMember(Name = "Email", Order = 18)]
        public string Email { get; set; }

        /// <summary>
        /// The calendar year that the team was founded
        /// </summary>
        [Description("The calendar year that the team was founded")]
        [DataMember(Name = "Founded", Order = 19)]
        public int? Founded { get; set; }

        /// <summary>
        /// The primary color of this team's logo/uniform/branding
        /// </summary>
        [Description("The primary color of this team's logo/uniform/branding")]
        [DataMember(Name = "ClubColor1", Order = 20)]
        public string ClubColor1 { get; set; }

        /// <summary>
        /// The secondary color of this team's logo/uniform/branding
        /// </summary>
        [Description("The secondary color of this team's logo/uniform/branding")]
        [DataMember(Name = "ClubColor2", Order = 21)]
        public string ClubColor2 { get; set; }

        /// <summary>
        /// The tertiary color of this team's logo/uniform/branding
        /// </summary>
        [Description("The tertiary color of this team's logo/uniform/branding")]
        [DataMember(Name = "ClubColor3", Order = 22)]
        public string ClubColor3 { get; set; }

        /// <summary>
        /// A nickname for this team
        /// </summary>
        [Description("A nickname for this team")]
        [DataMember(Name = "Nickname1", Order = 23)]
        public string Nickname1 { get; set; }

        /// <summary>
        /// A nickname for this team
        /// </summary>
        [Description("A nickname for this team")]
        [DataMember(Name = "Nickname2", Order = 24)]
        public string Nickname2 { get; set; }

        /// <summary>
        /// A nickname for this team
        /// </summary>
        [Description("A nickname for this team")]
        [DataMember(Name = "Nickname3", Order = 25)]
        public string Nickname3 { get; set; }

        /// <summary>
        /// The link to the team's logo hosted on Wikipedia (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's logo hosted on Wikipedia (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaLogoUrl", Order = 26)]
        public string WikipediaLogoUrl { get; set; }

        /// <summary>
        /// The link to the team's wordmark logo hosted on Wikipedia (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The link to the team's wordmark logo hosted on Wikipedia (This is not licensed for public or commercial use)")]
        [DataMember(Name = "WikipediaWordMarkUrl", Order = 27)]
        public string WikipediaWordMarkUrl { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamId", Order = 28)]
        public int GlobalTeamId { get; set; }

    }
}

