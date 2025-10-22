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
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 2)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career.")]
        [DataMember(Name = "PlayerId", Order = 3)]
        public int PlayerId { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "PlayerName", Order = 4)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "TeamName", Order = 5)]
        public string TeamName { get; set; }

        /// <summary>
        /// The area the team is located within their home country
        /// </summary>
        [Description("The area the team is located within their home country")]
        [DataMember(Name = "TeamArea", Order = 6)]
        public string TeamArea { get; set; }

        /// <summary>
        /// Whether the player's membership is active (true/false)
        /// </summary>
        [Description("Whether the player's membership is active (true/false)")]
        [DataMember(Name = "Active", Order = 7)]
        public bool Active { get; set; }

        /// <summary>
        /// The start date of the membership (in UTC)
        /// </summary>
        [Description("The start date of the membership (in UTC)")]
        [DataMember(Name = "StartDate", Order = 8)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of the membership (in UTC)
        /// </summary>
        [Description("The end date of the membership (in UTC)")]
        [DataMember(Name = "EndDate", Order = 9)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 10)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The player's jersey number on this team
        /// </summary>
        [Description("The player's jersey number on this team")]
        [DataMember(Name = "Jersey", Order = 11)]
        public int? Jersey { get; set; }

    }
}

