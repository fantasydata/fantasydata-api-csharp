using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Period")]
    [Serializable]
    public partial class Period
    {
        /// <summary>
        /// Unique ID of the Period
        /// </summary>
        [Description("Unique ID of the Period")]
        [DataMember(Name = "PeriodId", Order = 1)]
        public int PeriodId { get; set; }

        /// <summary>
        /// Type of the Period, an ordered description of the set. Indicates a tiebreak, if necessary
        /// </summary>
        [Description("Type of the Period, an ordered description of the set. Indicates a tiebreak, if necessary")]
        [DataMember(Name = "Type", Order = 2)]
        public string Type { get; set; }

        /// <summary>
        /// Score of Contestant A, representing number of won games
        /// </summary>
        [Description("Score of Contestant A, representing number of won games")]
        [DataMember(Name = "ScoreA", Order = 3)]
        public int ScoreA { get; set; }

        /// <summary>
        /// Score of Contestant B, representing number of won games
        /// </summary>
        [Description("Score of Contestant B, representing number of won games")]
        [DataMember(Name = "ScoreB", Order = 4)]
        public int ScoreB { get; set; }

        /// <summary>
        /// Timestamp of the last update of this record (ET)
        /// </summary>
        [Description("Timestamp of the last update of this record (ET)")]
        [DataMember(Name = "Updated", Order = 5)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Timestamp of this record's creation (ET)
        /// </summary>
        [Description("Timestamp of this record's creation (ET)")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime Created { get; set; }

    }
}

