using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="PlayerInfo")]
    [Serializable]
    public partial class PlayerInfo
    {
        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their MLB career.")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player's full name
        /// </summary>
        [Description("Player's full name")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO")]
        [DataMember(Name = "TeamID", Order = 3)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 4)]
        public string Team { get; set; }

        /// <summary>
        /// The player's position associated with the given game or season. Possible values: 1B; 2B; 3B; C; CF; DH; IF; LF; OF; P; PH; PR; RF; RP; SP; SS.
        /// </summary>
        [Description("The player's position associated with the given game or season. Possible values: 1B; 2B; 3B; C; CF; DH; IF; LF; OF; P; PH; PR; RF; RP; SP; SS.")]
        [DataMember(Name = "Position", Order = 5)]
        public string Position { get; set; }

    }
}

