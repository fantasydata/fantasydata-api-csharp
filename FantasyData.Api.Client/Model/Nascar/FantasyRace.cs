using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="FantasyRace")]
    [Serializable]
    public partial class FantasyRace
    {
        /// <summary>
        /// The unique ID of this driver (assigned by SportsDataIO)
        /// </summary>
        [Description("The unique ID of this driver (assigned by SportsDataIO)")]
        [DataMember(Name = "DriverID", Order = 1)]
        public int DriverID { get; set; }

        /// <summary>
        /// The season that this race is associated with
        /// </summary>
        [Description("The season that this race is associated with")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The day of this race
        /// </summary>
        [Description("The day of this race")]
        [DataMember(Name = "Day", Order = 3)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time of this race
        /// </summary>
        [Description("The date/time of this race")]
        [DataMember(Name = "DateTime", Order = 4)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The name of this race
        /// </summary>
        [Description("The name of this race")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

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
        /// The date/time when this race was last updated
        /// </summary>
        [Description("The date/time when this race was last updated")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime Updated { get; set; }

    }
}

