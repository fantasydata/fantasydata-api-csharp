using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerInfo")]
    [Serializable]
    public partial class PlayerInfo
    {
        /// <summary>
        /// Unique ID of the Player (assigned by SportsDataIO)
        /// </summary>
        [Description("Unique ID of the Player (assigned by SportsDataIO)")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Full Name of the Golfer
        /// </summary>
        [Description("Full Name of the Golfer")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

