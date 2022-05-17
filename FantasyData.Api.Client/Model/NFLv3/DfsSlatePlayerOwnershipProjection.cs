using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="DfsSlatePlayerOwnershipProjection")]
    [Serializable]
    public partial class DfsSlatePlayerOwnershipProjection
    {
        /// <summary>
        /// Unique ID of a Slate (assigned by SportsDataIO).
        /// </summary>
        [Description("Unique ID of a Slate (assigned by SportsDataIO).")]
        [DataMember(Name = "SlateID", Order = 1)]
        public int SlateID { get; set; }

        /// <summary>
        /// Unique ID of the Associated Player (can be null when it is a Team Defense)
        /// </summary>
        [Description("Unique ID of the Associated Player (can be null when it is a Team Defense)")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Unique ID of the Team Defense (only set for Team Defenses)
        /// </summary>
        [Description("Unique ID of the Team Defense (only set for Team Defenses)")]
        [DataMember(Name = "FantasyDefensePlayerID", Order = 3)]
        public int? FantasyDefensePlayerID { get; set; }

        /// <summary>
        /// Projected Ownership Percentage (0-100)
        /// </summary>
        [Description("Projected Ownership Percentage (0-100)")]
        [DataMember(Name = "ProjectedOwnershipPercentage", Order = 4)]
        public decimal ProjectedOwnershipPercentage { get; set; }

        /// <summary>
        /// Indicates if this is the MVP/Captain slot for single game slates
        /// </summary>
        [Description("Indicates if this is the MVP/Captain slot for single game slates")]
        [DataMember(Name = "IsCaptain", Order = 5)]
        public bool IsCaptain { get; set; }

    }
}

