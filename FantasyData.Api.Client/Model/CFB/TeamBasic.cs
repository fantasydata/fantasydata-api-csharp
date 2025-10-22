using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
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
        /// A unique abbreviation of the team (e.g. OAE; TAS; UAD; KAF; etc.) These are not recommended for front end use as they may not match common usage; see the ShortDisplayName instead.
        /// </summary>
        [Description("A unique abbreviation of the team (e.g. OAE; TAS; UAD; KAF; etc.) These are not recommended for front end use as they may not match common usage; see the ShortDisplayName instead.")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Whether or not this team is active
        /// </summary>
        [Description("Whether or not this team is active")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The name of the school as used in college sports (e.g. SMU; South Florida; Stony Brook; UCLA; etc.)
        /// </summary>
        [Description("The name of the school as used in college sports (e.g. SMU; South Florida; Stony Brook; UCLA; etc.)")]
        [DataMember(Name = "School", Order = 4)]
        public string School { get; set; }

        /// <summary>
        /// The full name of the stadium
        /// </summary>
        [Description("The full name of the stadium")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the stadium that the team plays its home games at
        /// </summary>
        [Description("The unique ID of the stadium that the team plays its home games at")]
        [DataMember(Name = "StadiumID", Order = 6)]
        public int StadiumID { get; set; }

        /// <summary>
        /// A globally unique ID for the team. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the team. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 7)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The url of the team logo image
        /// </summary>
        [Description("The url of the team logo image")]
        [DataMember(Name = "TeamLogoUrl", Order = 8)]
        public string TeamLogoUrl { get; set; }

        /// <summary>
        /// The unique ID of the team's conference
        /// </summary>
        [Description("The unique ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 9)]
        public int? ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's parent conference (e.g. SEC; Big Ten; etc)
        /// </summary>
        [Description("The name of the team's parent conference (e.g. SEC; Big Ten; etc)")]
        [DataMember(Name = "Conference", Order = 10)]
        public string Conference { get; set; }

        /// <summary>
        /// The shortened name of the team - recommended for front end applications. May not be unique; if you need a 100% unique letter identifier see the Key field in this table.
        /// </summary>
        [Description("The shortened name of the team - recommended for front end applications. May not be unique; if you need a 100% unique letter identifier see the Key field in this table.")]
        [DataMember(Name = "ShortDisplayName", Order = 11)]
        public string ShortDisplayName { get; set; }

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

