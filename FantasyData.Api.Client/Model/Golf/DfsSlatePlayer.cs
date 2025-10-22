using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="DfsSlatePlayer")]
    [Serializable]
    public partial class DfsSlatePlayer
    {
        /// <summary>
        /// Unique ID of a SlatePlayer (assigned by SportsDataIO).
        /// </summary>
        [Description("Unique ID of a SlatePlayer (assigned by SportsDataIO).")]
        [DataMember(Name = "SlatePlayerID", Order = 1)]
        public int SlatePlayerID { get; set; }

        /// <summary>
        /// Unique ID of a Slate (assigned by SportsDataIO).
        /// </summary>
        [Description("Unique ID of a Slate (assigned by SportsDataIO).")]
        [DataMember(Name = "SlateID", Order = 2)]
        public int SlateID { get; set; }

        /// <summary>
        /// The unique ID of a SlateTournament (assigned by SportsDataIO).
        /// </summary>
        [Description("The unique ID of a SlateTournament (assigned by SportsDataIO).")]
        [DataMember(Name = "SlateTournamentID", Order = 3)]
        public int? SlateTournamentID { get; set; }

        /// <summary>
        /// The unique SportsDataIO ID of the golfer that this slate refers to
        /// </summary>
        [Description("The unique SportsDataIO ID of the golfer that this slate refers to")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The unique ID for the player tournament projection that this SlatePlayer refers to. Note: This points to data in the respective sports' projected player game stats feeds.
        /// </summary>
        [Description("The unique ID for the player tournament projection that this SlatePlayer refers to. Note: This points to data in the respective sports' projected player game stats feeds.")]
        [DataMember(Name = "PlayerTournamentProjectionID", Order = 5)]
        public int? PlayerTournamentProjectionID { get; set; }

        /// <summary>
        /// The unique ID of the golfer as assigned by the operator
        /// </summary>
        [Description("The unique ID of the golfer as assigned by the operator")]
        [DataMember(Name = "OperatorPlayerID", Order = 6)]
        public string OperatorPlayerID { get; set; }

        /// <summary>
        /// The unique ID of the SlatePlayer as assigned by the operator
        /// </summary>
        [Description("The unique ID of the SlatePlayer as assigned by the operator")]
        [DataMember(Name = "OperatorSlatePlayerID", Order = 7)]
        public string OperatorSlatePlayerID { get; set; }

        /// <summary>
        /// The golfer's name as assigned by the operator
        /// </summary>
        [Description("The golfer's name as assigned by the operator")]
        [DataMember(Name = "OperatorPlayerName", Order = 8)]
        public string OperatorPlayerName { get; set; }

        /// <summary>
        /// The golfer's eligible positions for the contest as assigned by the operator
        /// </summary>
        [Description("The golfer's eligible positions for the contest as assigned by the operator")]
        [DataMember(Name = "OperatorPosition", Order = 9)]
        public string OperatorPosition { get; set; }

        /// <summary>
        /// The golfer's salary for the contest as assigned by the operator
        /// </summary>
        [Description("The golfer's salary for the contest as assigned by the operator")]
        [DataMember(Name = "OperatorSalary", Order = 10)]
        public int? OperatorSalary { get; set; }

        /// <summary>
        /// The golfer's eligible positions for the contest as assigned by the operator; This would include UTIL, etc. plays for those that are eligible
        /// </summary>
        [Description("The golfer's eligible positions for the contest as assigned by the operator; This would include UTIL, etc. plays for those that are eligible")]
        [DataMember(Name = "OperatorRosterSlots", Order = 10011)]
        public string[] OperatorRosterSlots { get; set; }

        /// <summary>
        /// Indicates whether this player was removed/deleted by the operator
        /// </summary>
        [Description("Indicates whether this player was removed/deleted by the operator")]
        [DataMember(Name = "RemovedByOperator", Order = 12)]
        public bool? RemovedByOperator { get; set; }

    }
}

