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
        /// The unique ID of the period
        /// </summary>
        [Description("The unique ID of the period")]
        [DataMember(Name = "PeriodId", Order = 1)]
        public int PeriodId { get; set; }

        /// <summary>
        /// Type of the Period, an ordered description of the set. Indicates a tiebreak, if necessary. For a complete list, see <a href="https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status" target="_blank">here</a>.
        /// </summary>
        [Description("Type of the Period, an ordered description of the set. Indicates a tiebreak, if necessary. For a complete list, see <a href=\"https://support.sportsdata.io/hc/en-us/articles/14287629964567-Process-Guide-Game-Status\" target=\"_blank\">here</a>.")]
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
        /// Timestamp of the last update of this record (in US Eastern Time)
        /// </summary>
        [Description("Timestamp of the last update of this record (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 5)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Timestamp of this record's creation (in US Eastern Time)
        /// </summary>
        [Description("Timestamp of this record's creation (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime Created { get; set; }

    }
}

