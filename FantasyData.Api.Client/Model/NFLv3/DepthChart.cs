using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="DepthChart")]
    [Serializable]
    public partial class DepthChart
    {
        /// <summary>
        /// Unique ID of Depth Chart Record
        /// </summary>
        [Description("Unique ID of Depth Chart Record")]
        [DataMember(Name = "DepthChartID", Order = 1)]
        public int DepthChartID { get; set; }

        /// <summary>
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// Unique ID of Player
        /// </summary>
        [Description("Unique ID of Player")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Player Name
        /// </summary>
        [Description("Player Name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Player Position Category (OFF, DEF, ST)
        /// </summary>
        [Description("Player Position Category (OFF, DEF, ST)")]
        [DataMember(Name = "PositionCategory", Order = 5)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Player Position
        /// </summary>
        [Description("Player Position")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// Depth Chart Order
        /// </summary>
        [Description("Depth Chart Order")]
        [DataMember(Name = "DepthOrder", Order = 7)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// Date and Time Last Updated
        /// </summary>
        [Description("Date and Time Last Updated")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

    }
}

