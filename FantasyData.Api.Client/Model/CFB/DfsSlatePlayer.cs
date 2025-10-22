using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="DfsSlatePlayer")]
    [Serializable]
    public partial class DfsSlatePlayer
    {
        /// <summary>
        /// The unique ID of a SlatePlayer as assigned by SportsDataIO
        /// </summary>
        [Description("The unique ID of a SlatePlayer as assigned by SportsDataIO")]
        [DataMember(Name = "SlatePlayerID", Order = 1)]
        public int SlatePlayerID { get; set; }

        /// <summary>
        /// The unique ID of the slate that this SlateGame refers to
        /// </summary>
        [Description("The unique ID of the slate that this SlateGame refers to")]
        [DataMember(Name = "SlateID", Order = 2)]
        public int SlateID { get; set; }

        /// <summary>
        /// The unique ID of the SlateGame that this SlatePlayer refers to as assigned by SportsDataIO
        /// </summary>
        [Description("The unique ID of the SlateGame that this SlatePlayer refers to as assigned by SportsDataIO")]
        [DataMember(Name = "SlateGameID", Order = 3)]
        public int? SlateGameID { get; set; }

        /// <summary>
        /// The unique ID of the player as assigned by SportsDataIO that this slate player refers to. Note: this ID remains with the player their entire collegiate career
        /// </summary>
        [Description("The unique ID of the player as assigned by SportsDataIO that this slate player refers to. Note: this ID remains with the player their entire collegiate career")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The SportsDataIO StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds.
        /// </summary>
        [Description("The SportsDataIO StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds.")]
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
        /// Indicates whether this slate was removed/deleted by the operator
        /// </summary>
        [Description("Indicates whether this slate was removed/deleted by the operator")]
        [DataMember(Name = "RemovedByOperator", Order = 12)]
        public bool? RemovedByOperator { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL
        /// </summary>
        [Description("The abbreviation [Key] of the team that the player is on. Note: If this player is a free agent; this field is NULL")]
        [DataMember(Name = "Team", Order = 13)]
        public string Team { get; set; }

        /// <summary>
        /// The unique ID of the team associated with this player
        /// </summary>
        [Description("The unique ID of the team associated with this player")]
        [DataMember(Name = "TeamID", Order = 14)]
        public int? TeamID { get; set; }

    }
}

