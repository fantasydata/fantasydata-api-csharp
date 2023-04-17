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
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// Unique ID of Player
        /// </summary>
        [Description("Unique ID of Player")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Name of Player
        /// </summary>
        [Description("Name of Player")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// General Position of Player (G, F, or C)
        /// </summary>
        [Description("General Position of Player (G, F, or C)")]
        [DataMember(Name = "PositionCategory", Order = 4)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Position of Player (PG, SG, SF, PF, or C)
        /// </summary>
        [Description("Position of Player (PG, SG, SF, PF, or C)")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

        /// <summary>
        /// Depth Chart Order
        /// </summary>
        [Description("Depth Chart Order")]
        [DataMember(Name = "DepthOrder", Order = 6)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// Date and Time Last Updated
        /// </summary>
        [Description("Date and Time Last Updated")]
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

