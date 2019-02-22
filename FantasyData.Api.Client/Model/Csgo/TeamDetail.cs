using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Csgo
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
        /// The unique ID of the team's area
        /// </summary>
        [Description("The unique ID of the team's area")]
        [DataMember(Name = "AreaId", Order = 3)]
        public int? AreaId { get; set; }

        /// <summary>
        /// The area name of the team
        /// </summary>
        [Description("The area name of the team")]
        [DataMember(Name = "AreaName", Order = 4)]
        public string AreaName { get; set; }

        /// <summary>
        /// Abbreviation of the team
        /// </summary>
        [Description("Abbreviation of the team")]
        [DataMember(Name = "Key", Order = 5)]
        public string Key { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The short name of the team
        /// </summary>
        [Description("The short name of the team")]
        [DataMember(Name = "ShortName", Order = 7)]
        public string ShortName { get; set; }

        /// <summary>
        /// Whether or not this team is active
        /// </summary>
        [Description("Whether or not this team is active")]
        [DataMember(Name = "Active", Order = 8)]
        public bool Active { get; set; }

        /// <summary>
        /// Indicates the gender of the players on this team (possible values: Male, Female)
        /// </summary>
        [Description("Indicates the gender of the players on this team (possible values: Male, Female)")]
        [DataMember(Name = "Gender", Order = 9)]
        public string Gender { get; set; }

        /// <summary>
        /// The type of this team (possible values: Club, National)
        /// </summary>
        [Description("The type of this team (possible values: Club, National)")]
        [DataMember(Name = "Type", Order = 10)]
        public string Type { get; set; }

        /// <summary>
        /// The URL of the website of this team
        /// </summary>
        [Description("The URL of the website of this team")]
        [DataMember(Name = "Website", Order = 11)]
        public string Website { get; set; }

        /// <summary>
        /// The email address of this team
        /// </summary>
        [Description("The email address of this team")]
        [DataMember(Name = "Email", Order = 12)]
        public string Email { get; set; }

        /// <summary>
        /// The year the team was founded
        /// </summary>
        [Description("The year the team was founded")]
        [DataMember(Name = "Founded", Order = 13)]
        public int? Founded { get; set; }

        /// <summary>
        /// The primary color of this team's logo/branding
        /// </summary>
        [Description("The primary color of this team's logo/branding")]
        [DataMember(Name = "PrimaryColor", Order = 14)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The secondary color of this team's logo/branding
        /// </summary>
        [Description("The secondary color of this team's logo/branding")]
        [DataMember(Name = "SecondaryColor", Order = 15)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The tertiary color of this team's logo/branding
        /// </summary>
        [Description("The tertiary color of this team's logo/branding")]
        [DataMember(Name = "TertiaryColor", Order = 16)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The quaternary color of this team's logo/branding
        /// </summary>
        [Description("The quaternary color of this team's logo/branding")]
        [DataMember(Name = "QuaternaryColor", Order = 17)]
        public string QuaternaryColor { get; set; }

        /// <summary>
        /// The URL of this team's Facebook page
        /// </summary>
        [Description("The URL of this team's Facebook page")]
        [DataMember(Name = "Facebook", Order = 18)]
        public string Facebook { get; set; }

        /// <summary>
        /// The URL of this team's Twitter page
        /// </summary>
        [Description("The URL of this team's Twitter page")]
        [DataMember(Name = "Twitter", Order = 19)]
        public string Twitter { get; set; }

        /// <summary>
        /// The URL of this team's YouTube page
        /// </summary>
        [Description("The URL of this team's YouTube page")]
        [DataMember(Name = "YouTube", Order = 20)]
        public string YouTube { get; set; }

        /// <summary>
        /// The URL of this team's Instagram page
        /// </summary>
        [Description("The URL of this team's Instagram page")]
        [DataMember(Name = "Instagram", Order = 21)]
        public string Instagram { get; set; }

    }
}

