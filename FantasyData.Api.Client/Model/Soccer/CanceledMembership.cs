using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="CanceledMembership")]
    [Serializable]
    public partial class CanceledMembership
    {
        /// <summary>
        /// The unique ID of the canceled membership
        /// </summary>
        [Description("The unique ID of the canceled membership")]
        [DataMember(Name = "CanceledMembershipId", Order = 1)]
        public int CanceledMembershipId { get; set; }

        /// <summary>
        /// The unique ID of the membership which is being canceled; should be used to find memberships which may be safely deleted.
        /// </summary>
        [Description("The unique ID of the membership which is being canceled; should be used to find memberships which may be safely deleted.")]
        [DataMember(Name = "MembershipId", Order = 2)]
        public int MembershipId { get; set; }

        /// <summary>
        /// The unique ID of the team associated with this canceled membership
        /// </summary>
        [Description("The unique ID of the team associated with this canceled membership")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The date and time when this canceled membership was created
        /// </summary>
        [Description("The date and time when this canceled membership was created")]
        [DataMember(Name = "Created", Order = 5)]
        public DateTime Created { get; set; }

    }
}

