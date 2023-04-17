﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="PlayerBasic")]
    [Serializable]
    public partial class PlayerBasic
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO.")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The first name of the player.
        /// </summary>
        [Description("The first name of the player.")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the player.
        /// </summary>
        [Description("The last name of the player.")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// Indicates the player's status of being on an active roster. Possible values include: Active, Inactive
        /// </summary>
        [Description("Indicates the player's status of being on an active roster. Possible values include: Active, Inactive")]
        [DataMember(Name = "Status", Order = 4)]
        public string Status { get; set; }

        /// <summary>
        /// The TeamID of the team this player is employed by.
        /// </summary>
        [Description("The TeamID of the team this player is employed by.")]
        [DataMember(Name = "TeamID", Order = 5)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The key/abbreviation of the team this player is employed by.
        /// </summary>
        [Description("The key/abbreviation of the team this player is employed by.")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C, RW, LW, D, or G.
        /// </summary>
        [Description("The player's primary position. Possible values: C, RW, LW, D, or G.")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 8)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's height in inches.
        /// </summary>
        [Description("The player's height in inches.")]
        [DataMember(Name = "Height", Order = 9)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs).
        /// </summary>
        [Description("The player's weight in pounds (lbs).")]
        [DataMember(Name = "Weight", Order = 10)]
        public int? Weight { get; set; }

        /// <summary>
        /// The player's date of birth.
        /// </summary>
        [Description("The player's date of birth.")]
        [DataMember(Name = "BirthDate", Order = 11)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The city in which the player was born.
        /// </summary>
        [Description("The city in which the player was born.")]
        [DataMember(Name = "BirthCity", Order = 12)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The state in which the player was born.
        /// </summary>
        [Description("The state in which the player was born.")]
        [DataMember(Name = "BirthState", Order = 13)]
        public string BirthState { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 14)]
        public int? GlobalTeamID { get; set; }

    }
}

