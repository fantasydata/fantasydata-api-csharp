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
        /// The player's unique PlayerID as assigned by SportsDataIO Note: this ID will stay with the player throughout their MLB career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO Note: this ID will stay with the player throughout their MLB career")]
        [DataMember(Name = "PlayerID", Order = 1)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO")]
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
        /// Where the player batted in the lineup for the game (1;2;3; etc.)
        /// </summary>
        [Description("Where the player batted in the lineup for the game (1;2;3; etc.)")]
        [DataMember(Name = "BattingOrder", Order = 6)]
        public int? BattingOrder { get; set; }

        /// <summary>
        /// Player's position in the starting lineup (if started); otherwise the position he substituted for
        /// </summary>
        [Description("Player's position in the starting lineup (if started); otherwise the position he substituted for")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// Indicates if this player is starting. Note: started = 1 and non starting= 0
        /// </summary>
        [Description("Indicates if this player is starting. Note: started = 1 and non starting= 0")]
        [DataMember(Name = "Starting", Order = 8)]
        public bool? Starting { get; set; }

        /// <summary>
        /// Indicates if batting order has been confirmed (true/false)
        /// </summary>
        [Description("Indicates if batting order has been confirmed (true/false)")]
        [DataMember(Name = "Confirmed", Order = 9)]
        public bool? Confirmed { get; set; }

    }
}

