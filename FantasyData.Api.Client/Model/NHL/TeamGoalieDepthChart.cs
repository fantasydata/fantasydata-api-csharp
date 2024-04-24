using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="TeamGoalieDepthChart")]
    [Serializable]
    public partial class TeamGoalieDepthChart
    {
        /// <summary>
        /// List of Goalie Depth Chart records for each team
        /// </summary>
        [Description("List of Goalie Depth Chart records for each team")]
        [DataMember(Name = "GoalieDepthCharts", Order = 20001)]
        public GoalieDepthChart[] GoalieDepthCharts { get; set; }

        /// <summary>
        /// Unique ID of each team
        /// </summary>
        [Description("Unique ID of each team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

    }
}

