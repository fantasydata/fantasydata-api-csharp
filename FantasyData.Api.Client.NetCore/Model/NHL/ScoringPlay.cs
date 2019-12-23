using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NHL
{
    [DataContract(Namespace="", Name="ScoringPlay")]
    [Serializable]
    public partial class ScoringPlay
    {
        /// <summary>
        /// The unique ID of the scoring play
        /// </summary>
        [Description("The unique ID of the scoring play")]
        [DataMember(Name = "ScoringPlayID", Order = 1)]
        public int ScoringPlayID { get; set; }

        /// <summary>
        /// The unique ID of the period
        /// </summary>
        [Description("The unique ID of the period")]
        [DataMember(Name = "PeriodID", Order = 2)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The sequence/order that this scoring play happened
        /// </summary>
        [Description("The sequence/order that this scoring play happened")]
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
        /// The TeamID of the team that scored the goal
        /// </summary>
        [Description("The TeamID of the team that scored the goal")]
        [DataMember(Name = "ScoredByTeamID", Order = 6)]
        public int? ScoredByTeamID { get; set; }

        /// <summary>
        /// The TeamID of the team that allowe the goal
        /// </summary>
        [Description("The TeamID of the team that allowe the goal")]
        [DataMember(Name = "AllowedByTeamID", Order = 7)]
        public int? AllowedByTeamID { get; set; }

        /// <summary>
        /// The PlayerID of the player who scored the goal
        /// </summary>
        [Description("The PlayerID of the player who scored the goal")]
        [DataMember(Name = "ScoredByPlayerID", Order = 8)]
        public int? ScoredByPlayerID { get; set; }

        /// <summary>
        /// The PlayerID of the player who assisted on the goal
        /// </summary>
        [Description("The PlayerID of the player who assisted on the goal")]
        [DataMember(Name = "AssistedByPlayerID1", Order = 9)]
        public int? AssistedByPlayerID1 { get; set; }

        /// <summary>
        /// The PlayerID of the player who assisted on the goal
        /// </summary>
        [Description("The PlayerID of the player who assisted on the goal")]
        [DataMember(Name = "AssistedByPlayerID2", Order = 10)]
        public int? AssistedByPlayerID2 { get; set; }

        /// <summary>
        /// Whether the goal was scored on the power play (true/false)
        /// </summary>
        [Description("Whether the goal was scored on the power play (true/false)")]
        [DataMember(Name = "PowerPlay", Order = 11)]
        public bool? PowerPlay { get; set; }

        /// <summary>
        /// Whether the goal was scored shorthanded (true/false)
        /// </summary>
        [Description("Whether the goal was scored shorthanded (true/false)")]
        [DataMember(Name = "ShortHanded", Order = 12)]
        public bool? ShortHanded { get; set; }

        /// <summary>
        /// Whether the goal was an empty net goal (true/false)
        /// </summary>
        [Description("Whether the goal was an empty net goal (true/false)")]
        [DataMember(Name = "EmptyNet", Order = 13)]
        public bool? EmptyNet { get; set; }

        /// <summary>
        /// The away team score after the play ended
        /// </summary>
        [Description("The away team score after the play ended")]
        [DataMember(Name = "AwayTeamScore", Order = 14)]
        public int? AwayTeamScore { get; set; }

        /// <summary>
        /// The home team score after the play ended
        /// </summary>
        [Description("The home team score after the play ended")]
        [DataMember(Name = "HomeTeamScore", Order = 15)]
        public int? HomeTeamScore { get; set; }

    }
}

