using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerHole")]
    [Serializable]
    public partial class PlayerHole
    {
        /// <summary>
        /// The unique ID of this player/round combination
        /// </summary>
        [Description("The unique ID of this player/round combination")]
        [DataMember(Name = "PlayerRoundID", Order = 1)]
        public int PlayerRoundID { get; set; }

        /// <summary>
        /// The hole number on this round
        /// </summary>
        [Description("The hole number on this round")]
        [DataMember(Name = "Number", Order = 2)]
        public int? Number { get; set; }

        /// <summary>
        /// The par of this hole
        /// </summary>
        [Description("The par of this hole")]
        [DataMember(Name = "Par", Order = 3)]
        public int? Par { get; set; }

        /// <summary>
        /// The player's score on this hole (total strokes)
        /// </summary>
        [Description("The player's score on this hole (total strokes)")]
        [DataMember(Name = "Score", Order = 4)]
        public int? Score { get; set; }

        /// <summary>
        /// The player's score on this hole (+/- par)
        /// </summary>
        [Description("The player's score on this hole (+/- par)")]
        [DataMember(Name = "ToPar", Order = 5)]
        public int? ToPar { get; set; }

        /// <summary>
        /// Indicates whether this player shot a hole-in-one on this hole
        /// </summary>
        [Description("Indicates whether this player shot a hole-in-one on this hole")]
        [DataMember(Name = "HoleInOne", Order = 6)]
        public bool HoleInOne { get; set; }

        /// <summary>
        /// Indicates whether this player shot a double eagle on this hole
        /// </summary>
        [Description("Indicates whether this player shot a double eagle on this hole")]
        [DataMember(Name = "DoubleEagle", Order = 7)]
        public bool DoubleEagle { get; set; }

        /// <summary>
        /// Indicates whether this player shot an eagle on this hole
        /// </summary>
        [Description("Indicates whether this player shot an eagle on this hole")]
        [DataMember(Name = "Eagle", Order = 8)]
        public bool Eagle { get; set; }

        /// <summary>
        /// Indicates whether this player shot a birdie on this hole
        /// </summary>
        [Description("Indicates whether this player shot a birdie on this hole")]
        [DataMember(Name = "Birdie", Order = 9)]
        public bool Birdie { get; set; }

        /// <summary>
        /// Indicates whether this player shot par on this hole
        /// </summary>
        [Description("Indicates whether this player shot par on this hole")]
        [DataMember(Name = "IsPar", Order = 10)]
        public bool IsPar { get; set; }

        /// <summary>
        /// Indicates whether this player shot a bogey on this hole
        /// </summary>
        [Description("Indicates whether this player shot a bogey on this hole")]
        [DataMember(Name = "Bogey", Order = 11)]
        public bool Bogey { get; set; }

        /// <summary>
        /// Indicates whether this player shot a double bogey on this hole
        /// </summary>
        [Description("Indicates whether this player shot a double bogey on this hole")]
        [DataMember(Name = "DoubleBogey", Order = 12)]
        public bool DoubleBogey { get; set; }

        /// <summary>
        /// Indicates whether this player shot worse than a double bogey on this hole
        /// </summary>
        [Description("Indicates whether this player shot worse than a double bogey on this hole")]
        [DataMember(Name = "WorseThanDoubleBogey", Order = 13)]
        public bool WorseThanDoubleBogey { get; set; }

    }
}

