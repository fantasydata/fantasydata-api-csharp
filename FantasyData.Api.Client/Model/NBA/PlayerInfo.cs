using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="PlayerInfo")]
    [Serializable]
    public partial class PlayerInfo
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The player's full name
        /// </summary>
        [Description("The player's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the player's team
        /// </summary>
        [Description("The unique ID of the player's team")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the player's team
        /// </summary>
        [Description("The abbreviation [Key] of the player's team")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; PF; PG; SF; SG
        /// </summary>
        [Description("The player's primary position. Possible values: C; PF; PG; SF; SG")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

    }
}

