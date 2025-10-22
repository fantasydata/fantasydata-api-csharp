using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="StatBasic")]
    [Serializable]
    public partial class StatBasic
    {
        /// <summary>
        /// The driver's starting position for the race (typically the same as the PoleFinalPosition)
        /// </summary>
        [Description("The driver's starting position for the race (typically the same as the PoleFinalPosition)")]
        [DataMember(Name = "StartPosition", Order = 1)]
        public decimal? StartPosition { get; set; }

        /// <summary>
        /// The driver's final position for the race
        /// </summary>
        [Description("The driver's final position for the race")]
        [DataMember(Name = "FinalPosition", Order = 2)]
        public decimal? FinalPosition { get; set; }

        /// <summary>
        /// The driver's differential between their final position and their starting position
        /// </summary>
        [Description("The driver's differential between their final position and their starting position")]
        [DataMember(Name = "PositionDifferential", Order = 3)]
        public decimal? PositionDifferential { get; set; }

        /// <summary>
        /// The total number of laps completed by the driver
        /// </summary>
        [Description("The total number of laps completed by the driver")]
        [DataMember(Name = "Laps", Order = 4)]
        public decimal? Laps { get; set; }

        /// <summary>
        /// The total number of laps that this driver completed while in first place
        /// </summary>
        [Description("The total number of laps that this driver completed while in first place")]
        [DataMember(Name = "LapsLed", Order = 5)]
        public decimal? LapsLed { get; set; }

        /// <summary>
        /// The total points scored by this driver
        /// </summary>
        [Description("The total points scored by this driver")]
        [DataMember(Name = "Points", Order = 6)]
        public decimal? Points { get; set; }

        /// <summary>
        /// Indicates whether this driver won the race
        /// </summary>
        [Description("Indicates whether this driver won the race")]
        [DataMember(Name = "Wins", Order = 7)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Indicates whether this driver won the qualifying race (pole)
        /// </summary>
        [Description("Indicates whether this driver won the qualifying race (pole)")]
        [DataMember(Name = "Poles", Order = 8)]
        public decimal? Poles { get; set; }

        /// <summary>
        /// Driver's current position in the race; updated live
        /// </summary>
        [Description("Driver's current position in the race; updated live")]
        [DataMember(Name = "CurrentPosition", Order = 9)]
        public decimal? CurrentPosition { get; set; }

    }
}

