using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="DfsSlateGame")]
    [Serializable]
    public partial class DfsSlateGame
    {
        /// <summary>
        /// Unique ID of a SlateGame (assigned by SportsDataIO).
        /// </summary>
        [Description("Unique ID of a SlateGame (assigned by SportsDataIO).")]
        [DataMember(Name = "SlateGameID", Order = 1)]
        public int SlateGameID { get; set; }

        /// <summary>
        /// Unique ID of a Slate (assigned by SportsDataIO).
        /// </summary>
        [Description("Unique ID of a Slate (assigned by SportsDataIO).")]
        [DataMember(Name = "SlateID", Order = 2)]
        public int SlateID { get; set; }

        /// <summary>
        /// The unique ID of this game tied to this SlateGame
        /// </summary>
        [Description("The unique ID of this game tied to this SlateGame")]
        [DataMember(Name = "GameID", Order = 3)]
        public int? GameID { get; set; }

        /// <summary>
        /// Unique ID of a SlateGame (assigned by the operator)
        /// </summary>
        [Description("Unique ID of a SlateGame (assigned by the operator)")]
        [DataMember(Name = "OperatorGameID", Order = 4)]
        public int? OperatorGameID { get; set; }

        /// <summary>
        /// Indicates whether this game was removed/deleted by the operator.
        /// </summary>
        [Description("Indicates whether this game was removed/deleted by the operator.")]
        [DataMember(Name = "RemovedByOperator", Order = 5)]
        public bool? RemovedByOperator { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game
        /// </summary>
        [Description("Unique ID of the Score/Game")]
        [DataMember(Name = "ScoreID", Order = 6)]
        public int? ScoreID { get; set; }

        /// <summary>
        /// The details of the Score/Game that this SlateGame refers to
        /// </summary>
        [Description("The details of the Score/Game that this SlateGame refers to")]
        [DataMember(Name = "Game", Order = 10007)]
        public Schedule Game { get; set; }

    }
}

