using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="DepthChart")]
    [Serializable]
    public partial class DepthChart
    {
        /// <summary>
        /// The unique ID of the Depth Chard record
        /// </summary>
        [Description("The unique ID of the Depth Chard record")]
        [DataMember(Name = "DepthChartID", Order = 1)]
        public int DepthChartID { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The player's position category. Possible values: DH; IF; OF; P; PH; PR
        /// </summary>
        [Description("The player's position category. Possible values: DH; IF; OF; P; PH; PR")]
        [DataMember(Name = "PositionCategory", Order = 5)]
        public string PositionCategory { get; set; }

        /// <summary>
        /// Player's position in the depth chart. Note: a player can be listed in multiple positions of the depth chart
        /// </summary>
        [Description("Player's position in the depth chart. Note: a player can be listed in multiple positions of the depth chart")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// The Depth Chart order of the player and where they are placed in the depth chart
        /// </summary>
        [Description("The Depth Chart order of the player and where they are placed in the depth chart")]
        [DataMember(Name = "DepthOrder", Order = 7)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// The date and time of the last update made to this depth chart (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the last update made to this depth chart (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

    }
}

