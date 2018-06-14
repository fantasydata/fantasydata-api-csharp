using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="DfsSlateTournament")]
    [Serializable]
    public partial class DfsSlateTournament
    {
        /// <summary>
        /// Unique ID of a SlateTournament (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of a SlateTournament (assigned by FantasyData).")]
        [DataMember(Name = "SlateTournamentID", Order = 1)]
        public int SlateTournamentID { get; set; }

        /// <summary>
        /// The SlateID that this SlateTournament refers to.
        /// </summary>
        [Description("The SlateID that this SlateTournament refers to.")]
        [DataMember(Name = "SlateID", Order = 2)]
        public int SlateID { get; set; }

        /// <summary>
        /// The FantasyData TournamentID that this SlateTournament refers to. This points to data in the respective sports' schedule/game/box score feeds.
        /// </summary>
        [Description("The FantasyData TournamentID that this SlateTournament refers to. This points to data in the respective sports' schedule/game/box score feeds.")]
        [DataMember(Name = "TournamentID", Order = 3)]
        public int? TournamentID { get; set; }

        /// <summary>
        /// The details of the Tournament that this SlateTournament refers to.
        /// </summary>
        [Description("The details of the Tournament that this SlateTournament refers to.")]
        [DataMember(Name = "Tournament", Order = 10004)]
        public Tournament Tournament { get; set; }

        /// <summary>
        /// Unique ID of a SlateTournament (assigned by the operator).
        /// </summary>
        [Description("Unique ID of a SlateTournament (assigned by the operator).")]
        [DataMember(Name = "OperatorTournamentID", Order = 5)]
        public int? OperatorTournamentID { get; set; }

        /// <summary>
        /// Indicates whether this tournament was removed/deleted by the operator.
        /// </summary>
        [Description("Indicates whether this tournament was removed/deleted by the operator.")]
        [DataMember(Name = "RemovedByOperator", Order = 6)]
        public bool? RemovedByOperator { get; set; }

    }
}

