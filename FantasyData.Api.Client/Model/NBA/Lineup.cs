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
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 2)]
        public int TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team
        /// </summary>
        [Description("The abbreviation [Key] of the team")]
        [DataMember(Name = "Team", Order = 3)]
        public string Team { get; set; }

        /// <summary>
        /// The player's first name
        /// </summary>
        [Description("The player's first name")]
        [DataMember(Name = "FirstName", Order = 4)]
        public string FirstName { get; set; }

        /// <summary>
        /// The player's last name
        /// </summary>
        [Description("The player's last name")]
        [DataMember(Name = "LastName", Order = 5)]
        public string LastName { get; set; }

        /// <summary>
        /// The player's primary position. Possible values: C; PF; PG; SF; SG
        /// </summary>
        [Description("The player's primary position. Possible values: C; PF; PG; SF; SG")]
        [DataMember(Name = "Position", Order = 6)]
        public string Position { get; set; }

        /// <summary>
        /// Indicates whether this player is in the starting lineup or on the bench
        /// </summary>
        [Description("Indicates whether this player is in the starting lineup or on the bench")]
        [DataMember(Name = "Starting", Order = 7)]
        public bool? Starting { get; set; }

        /// <summary>
        /// Indicated whether the 'Starting' field has been confirmed for a player
        /// </summary>
        [Description("Indicated whether the 'Starting' field has been confirmed for a player")]
        [DataMember(Name = "Confirmed", Order = 8)]
        public bool? Confirmed { get; set; }

    }
}

