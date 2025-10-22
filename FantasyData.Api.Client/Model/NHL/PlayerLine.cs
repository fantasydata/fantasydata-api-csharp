using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="PlayerLine")]
    [Serializable]
    public partial class PlayerLine
    {
        /// <summary>
        /// The line the player is on (e.g. 1, 2, 3, or 4)
        /// </summary>
        [Description("The line the player is on (e.g. 1, 2, 3, or 4)")]
        [DataMember(Name = "LineNumber", Order = 1)]
        public int LineNumber { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; RW; LW; D; or G
        /// </summary>
        [Description("The player's primary position. Possible values: C; RW; LW; D; or G")]
        [DataMember(Name = "Position", Order = 2)]
        public string Position { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The full name of the player on the line
        /// </summary>
        [Description("The full name of the player on the line")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The hand the player shoots the puck with (right or left)
        /// </summary>
        [Description("The hand the player shoots the puck with (right or left)")]
        [DataMember(Name = "Shoots", Order = 5)]
        public string Shoots { get; set; }

        /// <summary>
        /// The type of line the player is on (e.g. EvenStrength (EV); PowerPlay (PP); ShortHanded (SH))
        /// </summary>
        [Description("The type of line the player is on (e.g. EvenStrength (EV); PowerPlay (PP); ShortHanded (SH))")]
        [DataMember(Name = "LineType", Order = 6)]
        public string LineType { get; set; }

    }
}

