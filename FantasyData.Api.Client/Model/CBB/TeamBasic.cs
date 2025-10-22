using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="TeamBasic")]
    [Serializable]
    public partial class TeamBasic
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// A unique abbreviation of the team (e.g. OKL; TXTECH; USC; UK; etc.). Note: Due to being selected for uniqueness; these are not always a match with broadcaster abbreviations. For that use case; use ShortDisplayName.
        /// </summary>
        [Description("A unique abbreviation of the team (e.g. OKL; TXTECH; USC; UK; etc.). Note: Due to being selected for uniqueness; these are not always a match with broadcaster abbreviations. For that use case; use ShortDisplayName.")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Whether or not this team is active. Note: Active = True & Inactive = False
        /// </summary>
        [Description("Whether or not this team is active. Note: Active = True & Inactive = False")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The name of the school as used in college sports (e.g. SMU; South Florida; Stony Brook; UCLA; etc.)
        /// </summary>
        [Description("The name of the school as used in college sports (e.g. SMU; South Florida; Stony Brook; UCLA; etc.)")]
        [DataMember(Name = "School", Order = 4)]
        public string School { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 6)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The ID of the team's conference
        /// </summary>
        [Description("The ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 7)]
        public int? ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's conference (e.g.  American Athletic, Big Ten, Conference USA)
        /// </summary>
        [Description("The name of the team's conference (e.g.  American Athletic, Big Ten, Conference USA)")]
        [DataMember(Name = "Conference", Order = 8)]
        public string Conference { get; set; }

        /// <summary>
        /// The URL of the team logo image (png format)
        /// </summary>
        [Description("The URL of the team logo image (png format)")]
        [DataMember(Name = "TeamLogoUrl", Order = 9)]
        public string TeamLogoUrl { get; set; }

        /// <summary>
        /// A abbreviation of the team as seen on most broadcasts. Note: This field could have the same name for multiple teams. If a completely unique name is need use [Key]
        /// </summary>
        [Description("A abbreviation of the team as seen on most broadcasts. Note: This field could have the same name for multiple teams. If a completely unique name is need use [Key]")]
        [DataMember(Name = "ShortDisplayName", Order = 10)]
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// The active home stadium of the team
        /// </summary>
        [Description("The active home stadium of the team")]
        [DataMember(Name = "Stadium", Order = 10011)]
        public Stadium Stadium { get; set; }

        /// <summary>
        /// The team's primary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's primary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "PrimaryColor", Order = 12)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The team's secondary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's secondary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "SecondaryColor", Order = 13)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The team's tertiary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's tertiary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "TertiaryColor", Order = 14)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The team's quaternary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's quaternary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "QuaternaryColor", Order = 15)]
        public string QuaternaryColor { get; set; }

    }
}

