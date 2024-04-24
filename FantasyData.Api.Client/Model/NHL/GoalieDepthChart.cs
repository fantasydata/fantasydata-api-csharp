using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="GoalieDepthChart")]
    [Serializable]
    public partial class GoalieDepthChart
    {
        /// <summary>
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 1)]
        public int TeamID { get; set; }

        /// <summary>
        /// The key/abbreviation of the team this player is employed by.
        /// </summary>
        [Description("The key/abbreviation of the team this player is employed by.")]
        [DataMember(Name = "Team", Order = 2)]
        public string Team { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO.")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Name of Player
        /// </summary>
        [Description("Name of Player")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// Type of Depth
        /// </summary>
        [Description("Type of Depth")]
        [DataMember(Name = "DepthType", Order = 5)]
        public string DepthType { get; set; }

        /// <summary>
        /// Type of Display
        /// </summary>
        [Description("Type of Display")]
        [DataMember(Name = "DisplayType", Order = 6)]
        public string DisplayType { get; set; }

        /// <summary>
        /// Order of Depth
        /// </summary>
        [Description("Order of Depth")]
        [DataMember(Name = "DepthOrder", Order = 7)]
        public int? DepthOrder { get; set; }

        /// <summary>
        /// The timestamp of when the record was created (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was created (US Eastern Time).")]
        [DataMember(Name = "Created", Order = 8)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (US Eastern Time).
        /// </summary>
        [Description("The timestamp of when the record was last updated (US Eastern Time).")]
        [DataMember(Name = "Updated", Order = 9)]
        public DateTime? Updated { get; set; }

    }
}

