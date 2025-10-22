using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerRoundScore")]
    [Serializable]
    public partial class PlayerRoundScore
    {
        /// <summary>
        /// The unique ID of this golfer/round combination
        /// </summary>
        [Description("The unique ID of this golfer/round combination")]
        [DataMember(Name = "PlayerRoundId", Order = 1)]
        public int PlayerRoundId { get; set; }

        /// <summary>
        /// The number of the round associated with this score
        /// </summary>
        [Description("The number of the round associated with this score")]
        [DataMember(Name = "Number", Order = 2)]
        public int? Number { get; set; }

        /// <summary>
        /// The date that this round is being played on
        /// </summary>
        [Description("The date that this round is being played on")]
        [DataMember(Name = "Day", Order = 3)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The par of the course this round is played on
        /// </summary>
        [Description("The par of the course this round is played on")]
        [DataMember(Name = "Par", Order = 4)]
        public int? Par { get; set; }

        /// <summary>
        /// The total strokes this golfer has for this round in the tournament
        /// </summary>
        [Description("The total strokes this golfer has for this round in the tournament")]
        [DataMember(Name = "Score", Order = 5)]
        public int? Score { get; set; }

        /// <summary>
        /// The time that this golfer tees off for the upcoming round (in US Eastern Time)
        /// </summary>
        [Description("The time that this golfer tees off for the upcoming round (in US Eastern Time)")]
        [DataMember(Name = "TeeTime", Order = 6)]
        public DateTime? TeeTime { get; set; }

        /// <summary>
        /// Indicates whether the player has withdrawn from the tournament
        /// </summary>
        [Description("Indicates whether the player has withdrawn from the tournament")]
        [DataMember(Name = "IsWithdrawn", Order = 7)]
        public bool IsWithdrawn { get; set; }

    }
}

