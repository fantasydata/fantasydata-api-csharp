using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
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
        /// Batting Order 
        /// </summary>
        [Description("Batting Order ")]
        [DataMember(Name = "BattingOrder", Order = 6)]
        public int? BattingOrder { get; set; }

        /// <summary>
        /// Player Position
        /// </summary>
        [Description("Player Position")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// Indicates if this player is starting
        /// </summary>
        [Description("Indicates if this player is starting")]
        [DataMember(Name = "Starting", Order = 8)]
        public bool? Starting { get; set; }

        /// <summary>
        /// Indicates if batting order has been confimred
        /// </summary>
        [Description("Indicates if batting order has been confimred")]
        [DataMember(Name = "Confirmed", Order = 9)]
        public bool? Confirmed { get; set; }

    }
}

