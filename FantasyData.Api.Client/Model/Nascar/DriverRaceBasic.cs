using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="DriverRaceBasic")]
    [Serializable]
    public partial class DriverRaceBasic
    {
        /// <summary>
        /// The unique ID of this stat record
        /// </summary>
        [Description("The unique ID of this stat record")]
        [DataMember(Name = "StatID", Order = 1)]
        public int StatID { get; set; }

        /// <summary>
        /// The unique ID of this driver
        /// </summary>
        [Description("The unique ID of this driver")]
        [DataMember(Name = "DriverID", Order = 2)]
        public int DriverID { get; set; }

        /// <summary>
        /// The season that this race is associated with
        /// </summary>
        [Description("The season that this race is associated with")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The driver's full name
        /// </summary>
        [Description("The driver's full name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The driver's car number
        /// </summary>
        [Description("The driver's car number")]
        [DataMember(Name = "Number", Order = 5)]
        public int? Number { get; set; }

        /// <summary>
        /// The driver's car number for display purposes (with leading zeros when necessary)
        /// </summary>
        [Description("The driver's car number for display purposes (with leading zeros when necessary)")]
        [DataMember(Name = "NumberDisplay", Order = 6)]
        public string NumberDisplay { get; set; }

        /// <summary>
        /// The manufacturer of the driver's car
        /// </summary>
        [Description("The manufacturer of the driver's car")]
        [DataMember(Name = "Manufacturer", Order = 7)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The driver's starting position for the race (typically the same as the PoleFinalPosition)
        /// </summary>
        [Description("The driver's starting position for the race (typically the same as the PoleFinalPosition)")]
        [DataMember(Name = "StartPosition", Order = 8)]
        public decimal? StartPosition { get; set; }

        /// <summary>
        /// The driver's final position for the race
        /// </summary>
        [Description("The driver's final position for the race")]
        [DataMember(Name = "FinalPosition", Order = 9)]
        public decimal? FinalPosition { get; set; }

        /// <summary>
        /// The driver's differential between their final position and their starting position
        /// </summary>
        [Description("The driver's differential between their final position and their starting position")]
        [DataMember(Name = "PositionDifferential", Order = 10)]
        public decimal? PositionDifferential { get; set; }

        /// <summary>
        /// The total number of laps completed by the driver
        /// </summary>
        [Description("The total number of laps completed by the driver")]
        [DataMember(Name = "Laps", Order = 11)]
        public decimal? Laps { get; set; }

        /// <summary>
        /// The total number of laps that this driver completed while in first place
        /// </summary>
        [Description("The total number of laps that this driver completed while in first place")]
        [DataMember(Name = "LapsLed", Order = 12)]
        public decimal? LapsLed { get; set; }

        /// <summary>
        /// The total points scored by this driver
        /// </summary>
        [Description("The total points scored by this driver")]
        [DataMember(Name = "Points", Order = 13)]
        public decimal? Points { get; set; }

        /// <summary>
        /// Indicates whether this driver won the race
        /// </summary>
        [Description("Indicates whether this driver won the race")]
        [DataMember(Name = "Wins", Order = 14)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Indicates whether this driver won the qualifying race (pole)
        /// </summary>
        [Description("Indicates whether this driver won the qualifying race (pole)")]
        [DataMember(Name = "Poles", Order = 15)]
        public decimal? Poles { get; set; }

        /// <summary>
        /// Driver's current position in the race; updated live
        /// </summary>
        [Description("Driver's current position in the race; updated live")]
        [DataMember(Name = "CurrentPosition", Order = 16)]
        public decimal? CurrentPosition { get; set; }

    }
}

