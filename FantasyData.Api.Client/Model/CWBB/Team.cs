using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CWBB
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
        /// A unique abbreviation of the team (e.g. OKL; TXTECH; USC; UK; etc.). Note: Due to being selected for uniqueness; these are not always matching broadcaster abbreviations. For that use case; use ShortDisplayName
        /// </summary>
        [Description("A unique abbreviation of the team (e.g. OKL; TXTECH; USC; UK; etc.). Note: Due to being selected for uniqueness; these are not always matching broadcaster abbreviations. For that use case; use ShortDisplayName")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Indicates whether or not this team is active
        /// </summary>
        [Description("Indicates whether or not this team is active")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The name of the team as used in college sports (e.g. SMU; South Florida; Stony Brook; UCLA; etc.)
        /// </summary>
        [Description("The name of the team as used in college sports (e.g. SMU; South Florida; Stony Brook; UCLA; etc.)")]
        [DataMember(Name = "School", Order = 4)]
        public string School { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The AP Rank of the team (1-25)
        /// </summary>
        [Description("The AP Rank of the team (1-25)")]
        [DataMember(Name = "ApRank", Order = 6)]
        public int? ApRank { get; set; }

        /// <summary>
        /// The total number of wins by the team
        /// </summary>
        [Description("The total number of wins by the team")]
        [DataMember(Name = "Wins", Order = 7)]
        public int? Wins { get; set; }

        /// <summary>
        /// The total number of losses by the team
        /// </summary>
        [Description("The total number of losses by the team")]
        [DataMember(Name = "Losses", Order = 8)]
        public int? Losses { get; set; }

        /// <summary>
        /// The total number of conference wins by the team
        /// </summary>
        [Description("The total number of conference wins by the team")]
        [DataMember(Name = "ConferenceWins", Order = 9)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// The total number of conference losses by the team
        /// </summary>
        [Description("The total number of conference losses by the team")]
        [DataMember(Name = "ConferenceLosses", Order = 10)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 11)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The ID of the team's conference
        /// </summary>
        [Description("The ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 12)]
        public int? ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's conference (e.g.  American Conference; Big Ten Conference; Conference USA)
        /// </summary>
        [Description("The name of the team's conference (e.g.  American Conference; Big Ten Conference; Conference USA)")]
        [DataMember(Name = "Conference", Order = 13)]
        public string Conference { get; set; }

        /// <summary>
        /// The URL of the team logo image
        /// </summary>
        [Description("The URL of the team logo image")]
        [DataMember(Name = "TeamLogoUrl", Order = 14)]
        public string TeamLogoUrl { get; set; }

        /// <summary>
        /// A abbreviation of the team as seen on most broadcasts. Note: This field could have the same name for multiple teams. If a completely unique name is need use [Key]
        /// </summary>
        [Description("A abbreviation of the team as seen on most broadcasts. Note: This field could have the same name for multiple teams. If a completely unique name is need use [Key]")]
        [DataMember(Name = "ShortDisplayName", Order = 15)]
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// The team's primary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's primary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "PrimaryColor", Order = 16)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The team's secondary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's secondary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "SecondaryColor", Order = 17)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// The team's tertiary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's tertiary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "TertiaryColor", Order = 18)]
        public string TertiaryColor { get; set; }

        /// <summary>
        /// The team's quaternary color. (This is not licensed for public or commercial use)
        /// </summary>
        [Description("The team's quaternary color. (This is not licensed for public or commercial use)")]
        [DataMember(Name = "QuaternaryColor", Order = 19)]
        public string QuaternaryColor { get; set; }

    }
}

