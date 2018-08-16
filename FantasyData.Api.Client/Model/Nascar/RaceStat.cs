using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceStat")]
    [Serializable]
    public partial class RaceStat
    {
        /// <summary>
        /// The unique ID of this race
        /// </summary>
        [Description("The unique ID of this race")]
        [DataMember(Name = "RaceID", Order = 1)]
        public int? RaceID { get; set; }

        /// <summary>
        /// The day of this race
        /// </summary>
        [Description("The day of this race")]
        [DataMember(Name = "Day", Order = 2)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The date/time of this race
        /// </summary>
        [Description("The date/time of this race")]
        [DataMember(Name = "DateTime", Order = 3)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The date/time when this record was last updated
        /// </summary>
        [Description("The date/time when this record was last updated")]
        [DataMember(Name = "Updated", Order = 4)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date/time when this record was created
        /// </summary>
        [Description("The date/time when this record was created")]
        [DataMember(Name = "Created", Order = 5)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The fantasy points scored by this driver
        /// </summary>
        [Description("The fantasy points scored by this driver")]
        [DataMember(Name = "FantasyPoints", Order = 6)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The fantasy points scored by this driver, according to the DraftKings scoring system
        /// </summary>
        [Description("The fantasy points scored by this driver, according to the DraftKings scoring system")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 7)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The speed of this driver's car during the qualifying race
        /// </summary>
        [Description("The speed of this driver's car during the qualifying race")]
        [DataMember(Name = "QualifyingSpeed", Order = 8)]
        public decimal? QualifyingSpeed { get; set; }

        /// <summary>
        /// The final position this driver finished in the qualifying race (pole)
        /// </summary>
        [Description("The final position this driver finished in the qualifying race (pole)")]
        [DataMember(Name = "PoleFinalPosition", Order = 9)]
        public decimal? PoleFinalPosition { get; set; }

        /// <summary>
        /// The driver's starting position for the race (typically the same as the PoleFinalPosition)
        /// </summary>
        [Description("The driver's starting position for the race (typically the same as the PoleFinalPosition)")]
        [DataMember(Name = "StartPosition", Order = 10)]
        public decimal? StartPosition { get; set; }

        /// <summary>
        /// The driver's final position for the race
        /// </summary>
        [Description("The driver's final position for the race")]
        [DataMember(Name = "FinalPosition", Order = 11)]
        public decimal? FinalPosition { get; set; }

        /// <summary>
        /// The driver's differential between the final position and the starting position
        /// </summary>
        [Description("The driver's differential between the final position and the starting position")]
        [DataMember(Name = "PositionDifferential", Order = 12)]
        public decimal? PositionDifferential { get; set; }

        /// <summary>
        /// The total number of laps completed by the driver
        /// </summary>
        [Description("The total number of laps completed by the driver")]
        [DataMember(Name = "Laps", Order = 13)]
        public decimal? Laps { get; set; }

        /// <summary>
        /// The total number of laps that this driver finished in first place
        /// </summary>
        [Description("The total number of laps that this driver finished in first place")]
        [DataMember(Name = "LapsLed", Order = 14)]
        public decimal? LapsLed { get; set; }

        /// <summary>
        /// The total number of laps that this driver finished fastest
        /// </summary>
        [Description("The total number of laps that this driver finished fastest")]
        [DataMember(Name = "FastestLaps", Order = 15)]
        public decimal? FastestLaps { get; set; }

        /// <summary>
        /// The total points scored by this driver
        /// </summary>
        [Description("The total points scored by this driver")]
        [DataMember(Name = "Points", Order = 16)]
        public decimal? Points { get; set; }

        /// <summary>
        /// The total bonus points scored by this driver
        /// </summary>
        [Description("The total bonus points scored by this driver")]
        [DataMember(Name = "Bonus", Order = 17)]
        public decimal? Bonus { get; set; }

        /// <summary>
        /// The total penalty points applied to this driver
        /// </summary>
        [Description("The total penalty points applied to this driver")]
        [DataMember(Name = "Penalty", Order = 18)]
        public decimal? Penalty { get; set; }

        /// <summary>
        /// Indicates whether this driver won the race
        /// </summary>
        [Description("Indicates whether this driver won the race")]
        [DataMember(Name = "Wins", Order = 19)]
        public decimal? Wins { get; set; }

        /// <summary>
        /// Indicates whether this driver won the qualifying race (pole)
        /// </summary>
        [Description("Indicates whether this driver won the qualifying race (pole)")]
        [DataMember(Name = "Poles", Order = 20)]
        public decimal? Poles { get; set; }

    }
}

