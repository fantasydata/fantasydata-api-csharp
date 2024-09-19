using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="TeamMapping")]
    [Serializable]
    public partial class TeamMapping
    {
        /// <summary>
        /// Id of the Team in the GRid system
        /// </summary>
        [Description("Id of the Team in the GRid system")]
        [DataMember(Name = "TeamGRid", Order = 1)]
        public string TeamGRid { get; set; }

        /// <summary>
        /// Id of the Originator (which source the OriginatorTeamId maps to)
        /// </summary>
        [Description("Id of the Originator (which source the OriginatorTeamId maps to)")]
        [DataMember(Name = "OriginatorGRid", Order = 2)]
        public string OriginatorGRid { get; set; }

        /// <summary>
        /// Id of the team in the originator's system
        /// </summary>
        [Description("Id of the team in the originator's system")]
        [DataMember(Name = "OriginatorTeamId", Order = 3)]
        public string OriginatorTeamId { get; set; }

        /// <summary>
        /// Id of the competition this mapping relates to in the GRid system.
        /// </summary>
        [Description("Id of the competition this mapping relates to in the GRid system.")]
        [DataMember(Name = "CompetitionGRid", Order = 4)]
        public string CompetitionGRid { get; set; }

        /// <summary>
        /// The creation date in UTC of this mapping in GRid
        /// </summary>
        [Description("The creation date in UTC of this mapping in GRid")]
        [DataMember(Name = "Created", Order = 5)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The name of the originator
        /// </summary>
        [Description("The name of the originator")]
        [DataMember(Name = "OriginatorName", Order = 6)]
        public string OriginatorName { get; set; }

        /// <summary>
        /// The name of the competition
        /// </summary>
        [Description("The name of the competition")]
        [DataMember(Name = "CompetitionName", Order = 7)]
        public string CompetitionName { get; set; }

    }
}

