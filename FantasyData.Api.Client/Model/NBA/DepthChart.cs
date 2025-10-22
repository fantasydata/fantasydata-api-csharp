using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="DepthChart")]
    [Serializable]
    public partial class DepthChart
    {
        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The player's position category. Possible values: C; F; G
        /// </summary>
        [Description("The player's position category. Possible values: C; F; G")]
        [DataMember(Name = "PositionCategory", Order = 4)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; PF; PG; SF; SG
        /// </summary>
        [Description("The player's primary position. Possible values: C; PF; PG; SF; SG")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// Depth Chart Order
        /// </summary>
        [Description("Depth Chart Order")]
        [DataMember(Name = "DepthOrder", Order = 6)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// The date and time that this depth chart was last updated (in US Eastern Time)
        /// </summary>
        [Description("The date and time that this depth chart was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Unique ID of Depth Chart Record
        /// </summary>
        [Description("Unique ID of Depth Chart Record")]
        [DataMember(Name = "DepthChartID", Order = 8)]
        public int DepthChartID { get; set; }

    }
}

