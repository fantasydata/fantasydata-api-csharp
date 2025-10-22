using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="PenaltyShootout")]
    [Serializable]
    public partial class PenaltyShootout
    {
        /// <summary>
        /// The unique ID of the penalty shootout
        /// </summary>
        [Description("The unique ID of the penalty shootout")]
        [DataMember(Name = "PenaltyShootoutId", Order = 1)]
        public int PenaltyShootoutId { get; set; }

        /// <summary>
        /// The unique ID of the game tied to this penalty shootout
        /// </summary>
        [Description("The unique ID of the game tied to this penalty shootout")]
        [DataMember(Name = "GameId", Order = 2)]
        public int GameId { get; set; }

        /// <summary>
        /// The result of this penalty shootout kick. Possible values: Goal; Miss.
        /// </summary>
        [Description("The result of this penalty shootout kick. Possible values: Goal; Miss.")]
        [DataMember(Name = "Type", Order = 3)]
        public string Type { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 4)]
        public int TeamId { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career.
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career.")]
        [DataMember(Name = "PlayerId", Order = 5)]
        public int? PlayerId { get; set; }

        /// <summary>
        /// The name of the player in the penalty shootout
        /// </summary>
        [Description("The name of the player in the penalty shootout")]
        [DataMember(Name = "Name", Order = 6)]
        public string Name { get; set; }

        /// <summary>
        /// The position of the player. Possible values include: A (Attacker); M (Midfielder); D (Defender); GK (Goalkeeper).
        /// </summary>
        [Description("The position of the player. Possible values include: A (Attacker); M (Midfielder); D (Defender); GK (Goalkeeper).")]
        [DataMember(Name = "Position", Order = 7)]
        public string Position { get; set; }

        /// <summary>
        /// The order of the penalty shootout
        /// </summary>
        [Description("The order of the penalty shootout")]
        [DataMember(Name = "Order", Order = 8)]
        public int Order { get; set; }

    }
}

