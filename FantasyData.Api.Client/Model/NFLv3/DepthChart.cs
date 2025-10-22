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
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The category of the player's depth chart position (OFF; DEF; ST)
        /// </summary>
        [Description("The category of the player's depth chart position (OFF; DEF; ST)")]
        [DataMember(Name = "PositionCategory", Order = 5)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// The player's depth chart position
        /// </summary>
        [Description("The player's depth chart position")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// The order this player is at his position (1 = Starter; 2 = Backup; 3 = 3rd String; 4 = 4th String; 5 = 5th String)
        /// </summary>
        [Description("The order this player is at his position (1 = Starter; 2 = Backup; 3 = 3rd String; 4 = 4th String; 5 = 5th String)")]
        [DataMember(Name = "DepthOrder", Order = 7)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// Date and time last updated (in US Eastern Time)
        /// </summary>
        [Description("Date and time last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

    }
}

