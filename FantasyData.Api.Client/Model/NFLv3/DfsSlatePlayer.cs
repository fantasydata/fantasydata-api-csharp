using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
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
        /// The FantasyData StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds. This field is only filled for Players. For the NFL feeds, this is the PlayerGameProjection.PlayerGameID.
        /// </summary>
        [Description("The FantasyData StatID that this SlatePlayer refers to. This points to data in the respective sports' projected player game stats feeds. This field is only filled for Players. For the NFL feeds, this is the PlayerGameProjection.PlayerGameID.")]
        [DataMember(Name = "PlayerGameProjectionStatID", Order = 5)]
        public int? PlayerGameProjectionStatID { get; set; }

        /// <summary>
        /// The FantasyData StatID that this SlatePlayer refers to. This field is only filled for Defense/Special Teams. For the NFL feeds, this is the FantasyDefenseGameProjection.FantasyDefenseID.
        /// </summary>
        [Description("The FantasyData StatID that this SlatePlayer refers to. This field is only filled for Defense/Special Teams. For the NFL feeds, this is the FantasyDefenseGameProjection.FantasyDefenseID.")]
        [DataMember(Name = "FantasyDefenseProjectionStatID", Order = 6)]
        public int? FantasyDefenseProjectionStatID { get; set; }

        /// <summary>
        /// Unique ID of the Player (assigned by the operator).
        /// </summary>
        [Description("Unique ID of the Player (assigned by the operator).")]
        [DataMember(Name = "OperatorPlayerID", Order = 7)]
        public string OperatorPlayerID { get; set; }

        /// <summary>
        /// Unique ID of the SlatePlayer (assigned by the operator).
        /// </summary>
        [Description("Unique ID of the SlatePlayer (assigned by the operator).")]
        [DataMember(Name = "OperatorSlatePlayerID", Order = 8)]
        public string OperatorSlatePlayerID { get; set; }

        /// <summary>
        /// The player's name (assigned by the operator).
        /// </summary>
        [Description("The player's name (assigned by the operator).")]
        [DataMember(Name = "OperatorPlayerName", Order = 9)]
        public string OperatorPlayerName { get; set; }

        /// <summary>
        /// The player's eligible positions (assigned by the operator).
        /// </summary>
        [Description("The player's eligible positions (assigned by the operator).")]
        [DataMember(Name = "OperatorPosition", Order = 10)]
        public string OperatorPosition { get; set; }

        /// <summary>
        /// The player's eligible positions to be played in the contest (assigned by the operator). This would include FLEX, etc plays for those that are eligible.
        /// </summary>
        [Description("The player's eligible positions to be played in the contest (assigned by the operator). This would include FLEX, etc plays for those that are eligible.")]
        [DataMember(Name = "OperatorRosterSlots", Order = 10011)]
        public string[] OperatorRosterSlots { get; set; }

        /// <summary>
        /// The player's salary for the contest (assigned by the operator).
        /// </summary>
        [Description("The player's salary for the contest (assigned by the operator).")]
        [DataMember(Name = "OperatorSalary", Order = 12)]
        public int? OperatorSalary { get; set; }

        /// <summary>
        /// The fantasy data team key for team the player belongs to
        /// </summary>
        [Description("The fantasy data team key for team the player belongs to")]
        [DataMember(Name = "Team", Order = 13)]
        public string Team { get; set; }

        /// <summary>
        /// The fantasy data team id for team the player belongs to
        /// </summary>
        [Description("The fantasy data team id for team the player belongs to")]
        [DataMember(Name = "TeamID", Order = 14)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Indicates whether this player was removed/deleted by the operator.
        /// </summary>
        [Description("Indicates whether this player was removed/deleted by the operator.")]
        [DataMember(Name = "RemovedByOperator", Order = 15)]
        public bool? RemovedByOperator { get; set; }

    }
}

