using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="TeamDepthChart")]
    [Serializable]
    public partial class TeamDepthChart
    {
        /// <summary>
        /// List of Depth Chart Records for Team
        /// </summary>
        [Description("List of Depth Chart Records for Team")]
        [DataMember(Name = "DepthCharts", Order = 20001)]
        public DepthChart[] DepthCharts { get; set; }

        /// <summary>
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

    }
}

