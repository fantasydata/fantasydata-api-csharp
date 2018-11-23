using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="DfsSlate")]
    [Serializable]
    public partial class DfsSlate
    {
        /// <summary>
        /// Unique ID of a Slate (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of a Slate (assigned by FantasyData).")]
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
        /// The day (in EST/EDT) that the slate begins (assigned by the operator).
        /// </summary>
        [Description("The day (in EST/EDT) that the slate begins (assigned by the operator).")]
        [DataMember(Name = "OperatorDay", Order = 5)]
        public DateTime? OperatorDay { get; set; }

        /// <summary>
        /// The date/time (in EST/EDT) that the slate begins (assigned by the operator).
        /// </summary>
        [Description("The date/time (in EST/EDT) that the slate begins (assigned by the operator).")]
        [DataMember(Name = "OperatorStartTime", Order = 6)]
        public DateTime? OperatorStartTime { get; set; }

        /// <summary>
        /// The number of actual games that this slate covers.
        /// </summary>
        [Description("The number of actual games that this slate covers.")]
        [DataMember(Name = "NumberOfGames", Order = 7)]
        public int? NumberOfGames { get; set; }

        /// <summary>
        /// Whether this slate uses games that take place on different days.
        /// </summary>
        [Description("Whether this slate uses games that take place on different days.")]
        [DataMember(Name = "IsMultiDaySlate", Order = 8)]
        public bool? IsMultiDaySlate { get; set; }

        /// <summary>
        /// Indicates whether this slate was removed/deleted by the operator.
        /// </summary>
        [Description("Indicates whether this slate was removed/deleted by the operator.")]
        [DataMember(Name = "RemovedByOperator", Order = 9)]
        public bool? RemovedByOperator { get; set; }

        /// <summary>
        /// The game type of the slate. Will often be null as most operators only have one game type.
        /// </summary>
        [Description("The game type of the slate. Will often be null as most operators only have one game type.")]
        [DataMember(Name = "OperatorGameType", Order = 10)]
        public string OperatorGameType { get; set; }

        /// <summary>
        /// The games that are included in this slate
        /// </summary>
        [Description("The games that are included in this slate")]
        [DataMember(Name = "DfsSlateGames", Order = 20011)]
        public DfsSlateGame[] DfsSlateGames { get; set; }

        /// <summary>
        /// The players that are included in this slate
        /// </summary>
        [Description("The players that are included in this slate")]
        [DataMember(Name = "DfsSlatePlayers", Order = 20012)]
        public DfsSlatePlayer[] DfsSlatePlayers { get; set; }

    }
}

