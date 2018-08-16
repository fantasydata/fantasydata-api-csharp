using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Race")]
    [Serializable]
    public partial class Race
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
        public DateTime Day { get; set; }

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
        /// The station broadcasting this race
        /// </summary>
        [Description("The station broadcasting this race")]
        [DataMember(Name = "Broadcast", Order = 9)]
        public string Broadcast { get; set; }

        /// <summary>
        /// The unique ID of the driver who won this race
        /// </summary>
        [Description("The unique ID of the driver who won this race")]
        [DataMember(Name = "WinnerID", Order = 10)]
        public int? WinnerID { get; set; }

        /// <summary>
        /// The unique ID of the driver who won the qualifying pole
        /// </summary>
        [Description("The unique ID of the driver who won the qualifying pole")]
        [DataMember(Name = "PoleWinnerID", Order = 11)]
        public int? PoleWinnerID { get; set; }

        /// <summary>
        /// Indicates whether this race is currently in progress
        /// </summary>
        [Description("Indicates whether this race is currently in progress")]
        [DataMember(Name = "IsInProgress", Order = 12)]
        public bool IsInProgress { get; set; }

        /// <summary>
        /// Indicates whether this race is over
        /// </summary>
        [Description("Indicates whether this race is over")]
        [DataMember(Name = "IsOver", Order = 13)]
        public bool IsOver { get; set; }

        /// <summary>
        /// The date/time when this race was last updated
        /// </summary>
        [Description("The date/time when this race was last updated")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date/time when this race was created
        /// </summary>
        [Description("The date/time when this race was created")]
        [DataMember(Name = "Created", Order = 15)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The day that this is race is rescheduled for (if race was postponed)
        /// </summary>
        [Description("The day that this is race is rescheduled for (if race was postponed)")]
        [DataMember(Name = "RescheduledDay", Order = 16)]
        public DateTime RescheduledDay { get; set; }

        /// <summary>
        /// The date/time that this is race is rescheduled for (if race was postponed)
        /// </summary>
        [Description("The date/time that this is race is rescheduled for (if race was postponed)")]
        [DataMember(Name = "RescheduledDateTime", Order = 17)]
        public DateTime? RescheduledDateTime { get; set; }

    }
}

