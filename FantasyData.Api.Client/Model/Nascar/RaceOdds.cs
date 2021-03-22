using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="RaceOdds")]
    [Serializable]
    public partial class RaceOdds
    {
        /// <summary>
        /// The unique ID of this race
        /// </summary>
        [Description("The unique ID of this race")]
        [DataMember(Name = "RaceID", Order = 1)]
        public int RaceID { get; set; }

        /// <summary>
        /// The unique ID of the series that this race is associated with
        /// </summary>
        [Description("The unique ID of the series that this race is associated with")]
        [DataMember(Name = "SeriesID", Order = 2)]
        public int SeriesID { get; set; }

        /// <summary>
        /// The name of the series that this race is associated with
        /// </summary>
        [Description("The name of the series that this race is associated with")]
        [DataMember(Name = "SeriesName", Order = 3)]
        public string SeriesName { get; set; }

        /// <summary>
        /// The season that this race is associated with
        /// </summary>
        [Description("The season that this race is associated with")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The name of this race
        /// </summary>
        [Description("The name of this race")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

        /// <summary>
        /// The day of this race
        /// </summary>
        [Description("The day of this race")]
        [DataMember(Name = "Day", Order = 6)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The date/time of this race
        /// </summary>
        [Description("The date/time of this race")]
        [DataMember(Name = "DateTime", Order = 7)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The name of the track for this race
        /// </summary>
        [Description("The name of the track for this race")]
        [DataMember(Name = "Track", Order = 8)]
        public string Track { get; set; }

        /// <summary>
        /// Indicates whether this race is currently in progress
        /// </summary>
        [Description("Indicates whether this race is currently in progress")]
        [DataMember(Name = "IsInProgress", Order = 9)]
        public bool? IsInProgress { get; set; }

        /// <summary>
        /// Indicates whether this race is over
        /// </summary>
        [Description("Indicates whether this race is over")]
        [DataMember(Name = "IsOver", Order = 10)]
        public bool? IsOver { get; set; }

        /// <summary>
        /// List of the odds leading up to the start of the race
        /// </summary>
        [Description("List of the odds leading up to the start of the race")]
        [DataMember(Name = "PreGameOdds", Order = 20011)]
        public DriverRaceOdd[] PreGameOdds { get; set; }

    }
}

