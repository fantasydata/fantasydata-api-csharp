using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="DfsSlatePlayer")]
    [Serializable]
    public partial class DfsSlatePlayer
    {
        /// <summary>
        /// Unique ID of a SlatePlayer (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of a SlatePlayer (assigned by FantasyData).")]
        [DataMember(Name = "SlatePlayerID", Order = 1)]
        public int SlatePlayerID { get; set; }

        /// <summary>
        /// The SlateID that this SlatePlayer refers to.
        /// </summary>
        [Description("The SlateID that this SlatePlayer refers to.")]
        [DataMember(Name = "SlateID", Order = 2)]
        public int SlateID { get; set; }

        /// <summary>
        /// The SlateGameID that this SlatePlayer refers to.
        /// </summary>
        [Description("The SlateGameID that this SlatePlayer refers to.")]
        [DataMember(Name = "SlateGameID", Order = 3)]
        public int? SlateGameID { get; set; }

        /// <summary>
        /// The FantasyData PlayerID that this SlatePlayer refers to. This points to data in the respective sports' player feeds.
        /// </summary>
        [Description("The FantasyData PlayerID that this SlatePlayer refers to. This points to data in the respective sports' player feeds.")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The FantasyData StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds.
        /// </summary>
        [Description("The FantasyData StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds.")]
        [DataMember(Name = "PlayerGameProjectionStatID", Order = 5)]
        public int? PlayerGameProjectionStatID { get; set; }

        /// <summary>
        /// Unique ID of the Player (assigned by the operator).
        /// </summary>
        [Description("Unique ID of the Player (assigned by the operator).")]
        [DataMember(Name = "OperatorPlayerID", Order = 6)]
        public string OperatorPlayerID { get; set; }

        /// <summary>
        /// Unique ID of the SlatePlayer (assigned by the operator).
        /// </summary>
        [Description("Unique ID of the SlatePlayer (assigned by the operator).")]
        [DataMember(Name = "OperatorSlatePlayerID", Order = 7)]
        public string OperatorSlatePlayerID { get; set; }

        /// <summary>
        /// The player's name (assigned by the operator).
        /// </summary>
        [Description("The player's name (assigned by the operator).")]
        [DataMember(Name = "OperatorPlayerName", Order = 8)]
        public string OperatorPlayerName { get; set; }

        /// <summary>
        /// The player's eligible positions for the contest (assigned by the operator).
        /// </summary>
        [Description("The player's eligible positions for the contest (assigned by the operator).")]
        [DataMember(Name = "OperatorPosition", Order = 9)]
        public string OperatorPosition { get; set; }

        /// <summary>
        /// The player's salary for the contest (assigned by the operator).
        /// </summary>
        [Description("The player's salary for the contest (assigned by the operator).")]
        [DataMember(Name = "OperatorSalary", Order = 10)]
        public int? OperatorSalary { get; set; }

        /// <summary>
        /// The player's eligible positions to be played in the contest (assigned by the operator). This would include UTIL, etc plays for those that are eligible.
        /// </summary>
        [Description("The player's eligible positions to be played in the contest (assigned by the operator). This would include UTIL, etc plays for those that are eligible.")]
        [DataMember(Name = "OperatorRosterSlots", Order = 10011)]
        public string[] OperatorRosterSlots { get; set; }

        /// <summary>
        /// Indicates whether this player was removed/deleted by the operator.
        /// </summary>
        [Description("Indicates whether this player was removed/deleted by the operator.")]
        [DataMember(Name = "RemovedByOperator", Order = 12)]
        public bool? RemovedByOperator { get; set; }

    }
}

