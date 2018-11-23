using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="Membership")]
    [Serializable]
    public partial class Membership
    {
        /// <summary>
        /// The unique ID for the membership
        /// </summary>
        [Description("The unique ID for the membership")]
        [DataMember(Name = "MembershipId", Order = 1)]
        public int MembershipId { get; set; }

        /// <summary>
        /// The unique ID for the team
        /// </summary>
        [Description("The unique ID for the team")]
        [DataMember(Name = "TeamId", Order = 2)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by FantasyData.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by FantasyData.")]
        [DataMember(Name = "PlayerId", Order = 3)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The full name of the player.
        /// </summary>
        [Description("The full name of the player.")]
        [DataMember(Name = "PlayerName", Order = 4)]
        public string PlayerName { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        [Description("Name of the team")]
        [DataMember(Name = "TeamName", Order = 5)]
        public string TeamName { get; set; }

        /// <summary>
        /// Area of the team
        /// </summary>
        [Description("Area of the team")]
        [DataMember(Name = "TeamArea", Order = 6)]
        public string TeamArea { get; set; }

        /// <summary>
        /// Whether the membership is active (true/false)
        /// </summary>
        [Description("Whether the membership is active (true/false)")]
        [DataMember(Name = "Active", Order = 7)]
        public bool Active { get; set; }

        /// <summary>
        /// The start date of the membership (UTC)
        /// </summary>
        [Description("The start date of the membership (UTC)")]
        [DataMember(Name = "StartDate", Order = 8)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the membership (UTC)
        /// </summary>
        [Description("The end date of the membership (UTC)")]
        [DataMember(Name = "EndDate", Order = 9)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The updated date and time of the membership (EST/EDT)
        /// </summary>
        [Description("The updated date and time of the membership (EST/EDT)")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

    }
}

