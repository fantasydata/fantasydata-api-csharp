﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CBB
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
        /// The school of the team (e.g. Oklahoma University, Texas Tech University, University of Southern California, Kentucky University, etc)
        /// </summary>
        [Description("The school of the team (e.g. Oklahoma University, Texas Tech University, University of Southern California, Kentucky University, etc)")]
        [DataMember(Name = "School", Order = 4)]
        public string School { get; set; }

        /// <summary>
        /// The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)
        /// </summary>
        [Description("The mascot of the team (e.g. Sooners, Red Raiders, Trojans, Wildcats, etc.)")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The AP Rank of the team 
        /// </summary>
        [Description("The AP Rank of the team ")]
        [DataMember(Name = "ApRank", Order = 6)]
        public int? ApRank { get; set; }

        /// <summary>
        /// The total number of wins by the school
        /// </summary>
        [Description("The total number of wins by the school")]
        [DataMember(Name = "Wins", Order = 7)]
        public int? Wins { get; set; }

        /// <summary>
        /// The total number of losses by the school
        /// </summary>
        [Description("The total number of losses by the school")]
        [DataMember(Name = "Losses", Order = 8)]
        public int? Losses { get; set; }

        /// <summary>
        /// The total number of conference wins by the school
        /// </summary>
        [Description("The total number of conference wins by the school")]
        [DataMember(Name = "ConferenceWins", Order = 9)]
        public int? ConferenceWins { get; set; }

        /// <summary>
        /// The total number of conference losses by the school
        /// </summary>
        [Description("The total number of conference losses by the school")]
        [DataMember(Name = "ConferenceLosses", Order = 10)]
        public int? ConferenceLosses { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 11)]
        public int GlobalTeamID { get; set; }

        /// <summary>
        /// The ID of the team's conference
        /// </summary>
        [Description("The ID of the team's conference")]
        [DataMember(Name = "ConferenceID", Order = 12)]
        public int? ConferenceID { get; set; }

        /// <summary>
        /// The name of the team's conference
        /// </summary>
        [Description("The name of the team's conference")]
        [DataMember(Name = "Conference", Order = 13)]
        public string Conference { get; set; }

        /// <summary>
        /// The url of the team logo image.
        /// </summary>
        [Description("The url of the team logo image.")]
        [DataMember(Name = "TeamLogoUrl", Order = 14)]
        public string TeamLogoUrl { get; set; }

        /// <summary>
        /// The short display name of the team
        /// </summary>
        [Description("The short display name of the team")]
        [DataMember(Name = "ShortDisplayName", Order = 15)]
        public string ShortDisplayName { get; set; }

        /// <summary>
        /// The home stadium of the team
        /// </summary>
        [Description("The home stadium of the team")]
        [DataMember(Name = "Stadium", Order = 10016)]
        public Stadium Stadium { get; set; }

    }
}

