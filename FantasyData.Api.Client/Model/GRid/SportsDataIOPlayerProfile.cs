using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="SportsDataIOPlayerProfile")]
    [Serializable]
    public partial class SportsDataIOPlayerProfile
    {
        /// <summary>
        /// The height of the player (in inches)
        /// </summary>
        [Description("The height of the player (in inches)")]
        [DataMember(Name = "Height", Order = 1)]
        public int? Height { get; set; }

        /// <summary>
        /// The weight of the player (in pounds/lbs)
        /// </summary>
        [Description("The weight of the player (in pounds/lbs)")]
        [DataMember(Name = "Weight", Order = 2)]
        public int? Weight { get; set; }

        /// <summary>
        /// The jersey number of the player where applicable
        /// </summary>
        [Description("The jersey number of the player where applicable")]
        [DataMember(Name = "Jersey", Order = 3)]
        public int? Jersey { get; set; }

        /// <summary>
        /// The position of the player where applicable
        /// </summary>
        [Description("The position of the player where applicable")]
        [DataMember(Name = "Position", Order = 4)]
        public string Position { get; set; }

        /// <summary>
        /// The GRid of the player's current team
        /// </summary>
        [Description("The GRid of the player's current team")]
        [DataMember(Name = "CurrentTeamGRid", Order = 5)]
        public string CurrentTeamGRid { get; set; }

    }
}

