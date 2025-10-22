using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Competition")]
    [Serializable]
    public partial class Competition
    {
        /// <summary>
        /// The unique ID of the competition
        /// </summary>
        [Description("The unique ID of the competition")]
        [DataMember(Name = "CompetitionId", Order = 1)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// The ID of the area in which competition takes place
        /// </summary>
        [Description("The ID of the area in which competition takes place")]
        [DataMember(Name = "AreaId", Order = 2)]
        public int AreaId { get; set; }

        /// <summary>
        /// The name of the area in which competition takes place
        /// </summary>
        [Description("The name of the area in which competition takes place")]
        [DataMember(Name = "AreaName", Order = 3)]
        public string AreaName { get; set; }

        /// <summary>
        /// Gender(s) participating in this Competition
        /// </summary>
        [Description("Gender(s) participating in this Competition")]
        [DataMember(Name = "Gender", Order = 4)]
        public string Gender { get; set; }

        /// <summary>
        /// The name of the competition
        /// </summary>
        [Description("The name of the competition")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

    }
}

