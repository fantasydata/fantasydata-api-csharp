using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="DfsSlateWithOwnershipProjection")]
    [Serializable]
    public partial class DfsSlateWithOwnershipProjection
    {
        /// <summary>
        /// Unique ID of a Slate (assigned by SportsDataIO).
        /// </summary>
        [Description("Unique ID of a Slate (assigned by SportsDataIO).")]
        [DataMember(Name = "SlateID", Order = 1)]
        public int SlateID { get; set; }

        /// <summary>
        /// The name of the operator who is running contests for this slate. Possible values: FanDuel, DraftKings, Yahoo, FantasyDraft, etc.
        /// </summary>
        [Description("The name of the operator who is running contests for this slate. Possible values: FanDuel, DraftKings, Yahoo, FantasyDraft, etc.")]
        [DataMember(Name = "Operator", Order = 2)]
        public string Operator { get; set; }

        /// <summary>
        /// Unique ID of a slate (assigned by the operator).
        /// </summary>
        [Description("Unique ID of a slate (assigned by the operator).")]
        [DataMember(Name = "OperatorSlateID", Order = 3)]
        public int? OperatorSlateID { get; set; }

        /// <summary>
        /// The name of the slate (assigned by the operator). Possible values: Main, Express, Arcade, Late Night, etc.
        /// </summary>
        [Description("The name of the slate (assigned by the operator). Possible values: Main, Express, Arcade, Late Night, etc.")]
        [DataMember(Name = "OperatorName", Order = 4)]
        public string OperatorName { get; set; }

        /// <summary>
        /// The day that the slate begins; assigned by the operator (in US Eastern Time)
        /// </summary>
        [Description("The day that the slate begins; assigned by the operator (in US Eastern Time)")]
        [DataMember(Name = "OperatorDay", Order = 5)]
        public DateTime? OperatorDay { get; set; }

        /// <summary>
        /// The date/time (in EST/EDT) that the slate begins (assigned by the operator).
        /// </summary>
        [Description("The date/time (in EST/EDT) that the slate begins (assigned by the operator).")]
        [DataMember(Name = "OperatorStartTime", Order = 6)]
        public DateTime? OperatorStartTime { get; set; }

        /// <summary>
        /// The list of projected ownership
        /// </summary>
        [Description("The list of projected ownership")]
        [DataMember(Name = "SlateOwnershipProjections", Order = 20007)]
        public DfsSlatePlayerOwnershipProjection[] SlateOwnershipProjections { get; set; }

    }
}

