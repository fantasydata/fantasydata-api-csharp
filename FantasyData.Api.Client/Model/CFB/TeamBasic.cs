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
        /// The auto-generated unique ID of the Team
        /// </summary>
        [Description("The auto-generated unique ID of the Team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// Abbreviation of the team (e.g. OU, TTU, USC, UK, etc.)
        /// </summary>
        [Description("Abbreviation of the team (e.g. OU, TTU, USC, UK, etc.)")]
        [DataMember(Name = "Key", Order = 2)]
        public string Key { get; set; }

        /// <summary>
        /// Whether or not this team is active
        /// </summary>
        [Description("Whether or not this team is active")]
        [DataMember(Name = "Active", Order = 3)]
        public bool Active { get; set; }

        /// <summary>
        /// The school of the team (e.g. Oklahoma University, Texas Tech University, University of Southern California,  University of Kentucky, etc)
        /// </summary>
        [Description("The school of the team (e.g. Oklahoma University, Texas Tech University, University of Southern California,  University of Kentucky, etc)")]
        [DataMember(Name = "School", Order = 4)]
        public string School { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 6)]
        public int StadiumID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 7)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The url of the team logo image.
        /// </summary>
        [Description("The url of the team logo image.")]
        [DataMember(Name = "TeamLogoUrl", Order = 8)]
        public string TeamLogoUrl { get; set; }

        /// <summary>
        /// The ID of the team's conference
        /// </summary>
        [Description("The ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 9)]
        public int? ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's conference
        /// </summary>
        [Description("The name of the team's conference")]
        [DataMember(Name = "Conference", Order = 10)]
        public string Conference { get; set; }

        /// <summary>
        /// The short display name of the team
        /// </summary>
        [Description("The short display name of the team")]
        [DataMember(Name = "ShortDisplayName", Order = 11)]
        public string ShortDisplayName { get; set; }

    }
}

