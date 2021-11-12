using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="Lineup")]
    [Serializable]
    public partial class Lineup
    {
        /// <summary>
        /// Unique ID of Player
        /// </summary>
        [Description("Unique ID of Player")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Unique ID of Team
        /// </summary>
        [Description("Unique ID of Team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// Name of Team
        /// </summary>
        [Description("Name of Team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// Player First Name
        /// </summary>
        [Description("Player First Name")]
        [DataMember(Name = "FirstName", Order = 4)]
        public string FirstName { get; set; }

        /// <summary>
        /// Player Last Name
        /// </summary>
        [Description("Player Last Name")]
        [DataMember(Name = "LastName", Order = 5)]
        public string LastName { get; set; }

        /// <summary>
        /// Player Position
        /// </summary>
        [Description("Player Position")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// Indicates whether this player is in the starting lineup or on the bench
        /// </summary>
        [Description("Indicates whether this player is in the starting lineup or on the bench")]
        [DataMember(Name = "Starting", Order = 7)]
        public bool? Starting { get; set; }

        /// <summary>
        /// Indicates whether  Starting status has been confirmed for this player
        /// </summary>
        [Description("Indicates whether  Starting status has been confirmed for this player")]
        [DataMember(Name = "Confirmed", Order = 8)]
        public bool? Confirmed { get; set; }

    }
}

