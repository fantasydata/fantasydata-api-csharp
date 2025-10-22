using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="GoalieDepthChart")]
    [Serializable]
    public partial class GoalieDepthChart
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team this player is employed by
        /// </summary>
        [Description("The abbreviation [Key] of the team this player is employed by")]
        [DataMember(Name = "Team", Order = 2)]
        public string Team { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The full name of the goaltender
        /// </summary>
        [Description("The full name of the goaltender")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether it is a goalie tandem or not for a goalie depth chart (returns Tandem; Regular)
        /// </summary>
        [Description("Indicates whether it is a goalie tandem or not for a goalie depth chart (returns Tandem; Regular)")]
        [DataMember(Name = "DepthType", Order = 5)]
        public string DepthType { get; set; }

        /// <summary>
        /// If the goalie depth chart is displayed as a Tandem or as Regular
        /// </summary>
        [Description("If the goalie depth chart is displayed as a Tandem or as Regular")]
        [DataMember(Name = "DisplayType", Order = 6)]
        public string DisplayType { get; set; }

        /// <summary>
        /// The order of the goalie in the team's depth chart
        /// </summary>
        [Description("The order of the goalie in the team's depth chart")]
        [DataMember(Name = "DepthOrder", Order = 7)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// The timestamp of when this depth chart was last edited; based on US Eastern Time (EST/EDT)
        /// </summary>
        [Description("The timestamp of when this depth chart was last edited; based on US Eastern Time (EST/EDT)")]
        [DataMember(Name = "Created", Order = 8)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 9)]
        public DateTime? Updated { get; set; }

    }
}

