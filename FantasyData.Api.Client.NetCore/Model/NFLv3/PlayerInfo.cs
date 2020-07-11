using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NFLv3
{
    [DataContract(Namespace="", Name="PlayerInfo")]
    [Serializable]
    public partial class PlayerInfo
    {
        /// <summary>
        /// Unique ID of the Player (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of the Player (assigned by FantasyData).")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Name of Player.
        /// </summary>
        [Description("Name of Player.")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Unique ID of the Team the player belongs to (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of the Team the player belongs to (assigned by FantasyData).")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Name of the team the player belongs to.
        /// </summary>
        [Description("Name of the team the player belongs to.")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// Position player plays.
        /// </summary>
        [Description("Position player plays.")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

    }
}

