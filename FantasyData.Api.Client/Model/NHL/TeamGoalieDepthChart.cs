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
        /// List of players that make up the goalie depth chart for each team
        /// </summary>
        [Description("List of players that make up the goalie depth chart for each team")]
        [DataMember(Name = "GoalieDepthCharts", Order = 20001)]
        public GoalieDepthChart[] GoalieDepthCharts { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

    }
}

