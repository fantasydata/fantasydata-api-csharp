using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="TeamDepthChartWeekly")]
    [Serializable]
    public partial class TeamDepthChartWeekly
    {
        /// <summary>
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// List of Offensive Depth Charts for Team
        /// </summary>
        [Description("List of Offensive Depth Charts for Team")]
        [DataMember(Name = "Offense", Order = 20002)]
        public DepthChartWeekly[] Offense { get; set; }

        /// <summary>
        /// List of Defensive Depth Charts for Team
        /// </summary>
        [Description("List of Defensive Depth Charts for Team")]
        [DataMember(Name = "Defense", Order = 20003)]
        public DepthChartWeekly[] Defense { get; set; }

        /// <summary>
        /// List of Special Teams Depth Charts for Team
        /// </summary>
        [Description("List of Special Teams Depth Charts for Team")]
        [DataMember(Name = "SpecialTeams", Order = 20004)]
        public DepthChartWeekly[] SpecialTeams { get; set; }

    }
}

