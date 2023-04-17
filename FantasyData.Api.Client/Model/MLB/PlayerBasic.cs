﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
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
        /// Deprecated. Use SportRadarPlayerID instead.
        /// </summary>
        [Description("Deprecated. Use SportRadarPlayerID instead.")]
        [DataMember(Name = "SportsDataID", Order = 2)]
        public string SportsDataID { get; set; }

        /// <summary>
        /// Indicates the player's status of being on an Major League Active Roster. Possible values include: Active, 40 Man Active, Non-Roster Invitee, Minors, Inactive, 7 Day Injury List, 10 Day Injury List, 15 Day Injury List, 60 Day Injury List, Restricted List, Paternity List, Bereavement List, Military List
        /// </summary>
        [Description("Indicates the player's status of being on an Major League Active Roster. Possible values include: Active, 40 Man Active, Non-Roster Invitee, Minors, Inactive, 7 Day Injury List, 10 Day Injury List, 15 Day Injury List, 60 Day Injury List, Restricted List, Paternity List, Bereavement List, Military List")]
        [DataMember(Name = "Status", Order = 3)]
        public string Status { get; set; }

        /// <summary>
        /// The TeamID of the team this player is employed by.
        /// </summary>
        [Description("The TeamID of the team this player is employed by.")]
        [DataMember(Name = "TeamID", Order = 4)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The key/abbreviation of the team this player is employed by.
        /// </summary>
        [Description("The key/abbreviation of the team this player is employed by.")]
        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        /// <summary>
        /// The player's jersey number.
        /// </summary>
        [Description("The player's jersey number.")]
        [DataMember(Name = "Jersey", Order = 6)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The player's position category. Possible values: DH, IF, OF, P, PH, PR
        /// </summary>
        [Description("The player's position category. Possible values: DH, IF, OF, P, PH, PR")]
        [DataMember(Name = "PositionCategory", Order = 7)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS
        /// </summary>
        [Description("The player's primary position. Possible values: 1B, 2B, 3B, C, CF, DH, IF, LF, OF, P, PH, PR, RF, RP, SP, SS")]
        [DataMember(Name = "Position", Order = 8)]
        public string Position { get; set; }

        /// <summary>
        /// The player's first name.
        /// </summary>
        [Description("The player's first name.")]
        [DataMember(Name = "FirstName", Order = 9)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name.
        /// </summary>
        [Description("The player's last name.")]
        [DataMember(Name = "LastName", Order = 10)]
        public string LastName { get; set; }

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
        /// The country in which the player was born.
        /// </summary>
        [Description("The country in which the player was born.")]
        [DataMember(Name = "BirthCountry", Order = 14)]
        public string BirthCountry { get; set; }

        /// <summary>
        /// A globally unique ID for this player. This value is guaranteed to be unique across all sports/leagues.
        /// </summary>
        [Description("A globally unique ID for this player. This value is guaranteed to be unique across all sports/leagues.")]
        [DataMember(Name = "GlobalTeamID", Order = 15)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The player's batting hand. Possible values: R, L, S
        /// </summary>
        [Description("The player's batting hand. Possible values: R, L, S")]
        [DataMember(Name = "BatHand", Order = 16)]
        public string BatHand { get; set; }

        /// <summary>
        /// The player's throwing hand. Possible values: R, L, S
        /// </summary>
        [Description("The player's throwing hand. Possible values: R, L, S")]
        [DataMember(Name = "ThrowHand", Order = 17)]
        public string ThrowHand { get; set; }

        /// <summary>
        /// The player's height in inches.
        /// </summary>
        [Description("The player's height in inches.")]
        [DataMember(Name = "Height", Order = 18)]
        public int? Height { get; set; }

        /// <summary>
        /// The player's weight in pounds (lbs).
        /// </summary>
        [Description("The player's weight in pounds (lbs).")]
        [DataMember(Name = "Weight", Order = 19)]
        public int? Weight { get; set; }

    }
}

