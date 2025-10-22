using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 4)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The SportsDataIO StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds.
        /// </summary>
        [Description("The SportsDataIO StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds.")]
        [DataMember(Name = "PlayerGameProjectionStatID", Order = 5)]
        public int? PlayerGameProjectionStatID { get; set; }

        /// <summary>
        /// The unique ID of the player as assigned by the operator
        /// </summary>
        [Description("The unique ID of the player as assigned by the operator")]
        [DataMember(Name = "OperatorPlayerID", Order = 6)]
        public string OperatorPlayerID { get; set; }

        /// <summary>
        /// The unique ID of the SlatePlayer as assigned by the operator
        /// </summary>
        [Description("The unique ID of the SlatePlayer as assigned by the operator")]
        [DataMember(Name = "OperatorSlatePlayerID", Order = 7)]
        public string OperatorSlatePlayerID { get; set; }

        /// <summary>
        /// The player's name as assigned by the operator
        /// </summary>
        [Description("The player's name as assigned by the operator")]
        [DataMember(Name = "OperatorPlayerName", Order = 8)]
        public string OperatorPlayerName { get; set; }

        /// <summary>
        /// The player's eligible positions for the contest assigned by the operator
        /// </summary>
        [Description("The player's eligible positions for the contest assigned by the operator")]
        [DataMember(Name = "OperatorPosition", Order = 9)]
        public string OperatorPosition { get; set; }

        /// <summary>
        /// The player's salary for the contest as assigned by the operator
        /// </summary>
        [Description("The player's salary for the contest as assigned by the operator")]
        [DataMember(Name = "OperatorSalary", Order = 10)]
        public int? OperatorSalary { get; set; }

        /// <summary>
        /// The player's eligible positions to be played in the contest as assigned by the operator. NOTE: This would include UTIL; etc plays for those that are eligible
        /// </summary>
        [Description("The player's eligible positions to be played in the contest as assigned by the operator. NOTE: This would include UTIL; etc plays for those that are eligible")]
        [DataMember(Name = "OperatorRosterSlots", Order = 10011)]
        public string[] OperatorRosterSlots { get; set; }

        /// <summary>
        /// Indicates whether this slate was removed/deleted by the operator
        /// </summary>
        [Description("Indicates whether this slate was removed/deleted by the operator")]
        [DataMember(Name = "RemovedByOperator", Order = 12)]
        public bool? RemovedByOperator { get; set; }

        /// <summary>
        /// The team the player plays for
        /// </summary>
        [Description("The team the player plays for")]
        [DataMember(Name = "Team", Order = 13)]
        public string Team { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 14)]
        public int? TeamID { get; set; }

    }
}

