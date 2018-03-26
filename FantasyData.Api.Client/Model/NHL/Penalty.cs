using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="Penalty")]
    [Serializable]
    public partial class Penalty
    {
        /// <summary>
        /// The unique ID of this penalty
        /// </summary>
        [Description("The unique ID of this penalty")]
        [DataMember(Name = "PenaltyID", Order = 1)]
        public int PenaltyID { get; set; }

        /// <summary>
        /// The unique ID of the period during which this penalty occurred
        /// </summary>
        [Description("The unique ID of the period during which this penalty occurred")]
        [DataMember(Name = "PeriodID", Order = 2)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The sequence/order that this penalty happened
        /// </summary>
        [Description("The sequence/order that this penalty happened")]
        [DataMember(Name = "Sequence", Order = 3)]
        public int? Sequence { get; set; }

        /// <summary>
        /// Number of minutes that have passed in the current period. Please note this field name is misleading, and actually represents the game clock minutes, which are the number of minutes that have already passed in the period. Possible values: 0-20.
        /// </summary>
        [Description("Number of minutes that have passed in the current period. Please note this field name is misleading, and actually represents the game clock minutes, which are the number of minutes that have already passed in the period. Possible values: 0-20.")]
        [DataMember(Name = "TimeRemainingMinutes", Order = 4)]
        public int? TimeRemainingMinutes { get; set; }

        /// <summary>
        /// Number of seconds that have passed in the current period. Please note this field name is misleading, and actually represents the game clock seconds, which are the number of seconds that have already passed in the period. Possible values: 0-60.
        /// </summary>
        [Description("Number of seconds that have passed in the current period. Please note this field name is misleading, and actually represents the game clock seconds, which are the number of seconds that have already passed in the period. Possible values: 0-60.")]
        [DataMember(Name = "TimeRemainingSeconds", Order = 5)]
        public int? TimeRemainingSeconds { get; set; }

        /// <summary>
        /// The description of the penalty
        /// </summary>
        [Description("The description of the penalty")]
        [DataMember(Name = "Description", Order = 6)]
        public string Description { get; set; }

        /// <summary>
        /// The number of minutes the penalty lasts
        /// </summary>
        [Description("The number of minutes the penalty lasts")]
        [DataMember(Name = "PenaltyMinutes", Order = 7)]
        public int? PenaltyMinutes { get; set; }

        /// <summary>
        /// The TeamID of the penalized team
        /// </summary>
        [Description("The TeamID of the penalized team")]
        [DataMember(Name = "PenalizedTeamID", Order = 8)]
        public int? PenalizedTeamID { get; set; }

        /// <summary>
        /// The PlayerID who commited the penalty
        /// </summary>
        [Description("The PlayerID who commited the penalty")]
        [DataMember(Name = "PenalizedPlayerID", Order = 9)]
        public int? PenalizedPlayerID { get; set; }

        /// <summary>
        /// The TeamID of the team who drew the penalty
        /// </summary>
        [Description("The TeamID of the team who drew the penalty")]
        [DataMember(Name = "DrawnByTeamID", Order = 10)]
        public int? DrawnByTeamID { get; set; }

        /// <summary>
        /// The PlayerID who drew the penalty
        /// </summary>
        [Description("The PlayerID who drew the penalty")]
        [DataMember(Name = "DrawnByPlayerID", Order = 11)]
        public int? DrawnByPlayerID { get; set; }

        /// <summary>
        /// Whether or not the penalty is a bench penalty (true/false)
        /// </summary>
        [Description("Whether or not the penalty is a bench penalty (true/false)")]
        [DataMember(Name = "IsBenchPenalty", Order = 12)]
        public bool? IsBenchPenalty { get; set; }

        /// <summary>
        /// The PlayerID of the player who served the bench penalty
        /// </summary>
        [Description("The PlayerID of the player who served the bench penalty")]
        [DataMember(Name = "BenchPenaltyServedByPlayerID", Order = 13)]
        public int? BenchPenaltyServedByPlayerID { get; set; }

    }
}

