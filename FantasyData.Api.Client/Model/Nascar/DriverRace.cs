using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="DriverRace")]
    [Serializable]
    public partial class DriverRace
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
        /// The driver's name
        /// </summary>
        [Description("The driver's name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The driver's car number
        /// </summary>
        [Description("The driver's car number")]
        [DataMember(Name = "Number", Order = 5)]
        public int? Number { get; set; }

        /// <summary>
        /// The manufacturer of the driver's car
        /// </summary>
        [Description("The manufacturer of the driver's car")]
        [DataMember(Name = "Manufacturer", Order = 6)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The DraftKings salary of the driver for this race
        /// </summary>
        [Description("The DraftKings salary of the driver for this race")]
        [DataMember(Name = "DraftKingsSalary", Order = 7)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// The unique ID of this race
        /// </summary>
        [Description("The unique ID of this race")]
        [DataMember(Name = "RaceID", Order = 8)]
        public int? RaceID { get; set; }

        /// <summary>
        /// The day of this race
        /// </summary>
        [Description("The day of this race")]
        [DataMember(Name = "Day", Order = 9)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The date/time of this race
        /// </summary>
        [Description("The date/time of this race")]
        [DataMember(Name = "DateTime", Order = 10)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The date/time when this record was last updated
        /// </summary>
        [Description("The date/time when this record was last updated")]
        [DataMember(Name = "Updated", Order = 11)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date/time when this record was created
        /// </summary>
        [Description("The date/time when this record was created")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The fantasy points scored by this driver
        /// </summary>
        [Description("The fantasy points scored by this driver")]
        [DataMember(Name = "FantasyPoints", Order = 13)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The fantasy points scored by this driver, according to the DraftKings scoring system
        /// </summary>
        [Description("The fantasy points scored by this driver, according to the DraftKings scoring system")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 14)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The speed of this driver's car during the qualifying race
        /// </summary>
        [Description("The speed of this driver's car during the qualifying race")]
        [DataMember(Name = "QualifyingSpeed", Order = 15)]
        public decimal? QualifyingSpeed { get; set; }

        /// <summary>
        /// The final position this driver finished in the qualifying race (pole)
        /// </summary>
        [Description("The final position this driver finished in the qualifying race (pole)")]
        [DataMember(Name = "PoleFinalPosition", Order = 16)]
        public decimal? PoleFinalPosition { get; set; }

        /// <summary>
        /// The driver's starting position for the race (typically the same as the PoleFinalPosition)
        /// </summary>
        [Description("The driver's starting position for the race (typically the same as the PoleFinalPosition)")]
        [DataMember(Name = "StartPosition", Order = 17)]
        public decimal? StartPosition { get; set; }

        /// <summary>
        /// The driver's final position for the race
        /// </summary>
        [Description("The driver's final position for the race")]
        [DataMember(Name = "FinalPosition", Order = 18)]
        public decimal? FinalPosition { get; set; }

        /// <summary>
        /// The driver's differential between the final position and the starting position
        /// </summary>
        [Description("The driver's differential between the final position and the starting position")]
        [DataMember(Name = "PositionDifferential", Order = 19)]
        public decimal? PositionDifferential { get; set; }

        /// <summary>
        /// The total number of laps completed by the driver
        /// </summary>
        [Description("The total number of laps completed by the driver")]
        [DataMember(Name = "Laps", Order = 20)]
        public decimal? Laps { get; set; }

        /// <summary>
        /// The total number of laps that this driver finished in first place
        /// </summary>
        [Description("The total number of laps that this driver finished in first place")]
        [DataMember(Name = "LapsLed", Order = 21)]
        public decimal? LapsLed { get; set; }

        /// <summary>
        /// The total number of laps that this driver finished fastest
        /// </summary>
        [Description("The total number of laps that this driver finished fastest")]
        [DataMember(Name = "FastestLaps", Order = 22)]
        public decimal? FastestLaps { get; set; }

        /// <summary>
        /// The total points scored by this driver
        /// </summary>
        [Description("The total points scored by this driver")]
        [DataMember(Name = "Points", Order = 23)]
        public decimal? Points { get; set; }

        /// <summary>
        /// The total bonus points scored by this driver
        /// </summary>
        [Description("The total bonus points scored by this driver")]
        [DataMember(Name = "Bonus", Order = 24)]
        public decimal? Bonus { get; set; }

        /// <summary>
        /// The total penalty points applied to this driver
        /// </summary>
        [Description("The total penalty points applied to this driver")]
        [DataMember(Name = "Penalty", Order = 25)]
        public decimal? Penalty { get; set; }

        /// <summary>
        /// Indicates whether this driver won the race
        /// </summary>
        [Description("Indicates whether this driver won the race")]
        [DataMember(Name = "Wins", Order = 26)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Indicates whether this driver won the qualifying race (pole)
        /// </summary>
        [Description("Indicates whether this driver won the qualifying race (pole)")]
        [DataMember(Name = "Poles", Order = 27)]
        public decimal? Poles { get; set; }

    }
}

