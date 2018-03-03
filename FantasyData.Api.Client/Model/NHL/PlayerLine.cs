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
        /// The position of the player on the line (e.g. C, RW, LW, or D)
        /// </summary>
        [Description("The position of the player on the line (e.g. C, RW, LW, or D)")]
        [DataMember(Name = "Position", Order = 2)]
        public string Position { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The name of the player on the line
        /// </summary>
        [Description("The name of the player on the line")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The handedness of the player (Possible values: left or right)
        /// </summary>
        [Description("The handedness of the player (Possible values: left or right)")]
        [DataMember(Name = "Shoots", Order = 5)]
        public string Shoots { get; set; }

        /// <summary>
        /// The type of line the player is on (e.g. first, second, third, etc.)
        /// </summary>
        [Description("The type of line the player is on (e.g. first, second, third, etc.)")]
        [DataMember(Name = "LineType", Order = 6)]
        public string LineType { get; set; }

    }
}

