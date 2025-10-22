using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
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
        /// Unique ID of the Associated Player.
        /// </summary>
        [Description("Unique ID of the Associated Player.")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Projected Ownership Percentage (0-100)
        /// </summary>
        [Description("Projected Ownership Percentage (0-100)")]
        [DataMember(Name = "ProjectedOwnershipPercentage", Order = 3)]
        public decimal ProjectedOwnershipPercentage { get; set; }

    }
}

