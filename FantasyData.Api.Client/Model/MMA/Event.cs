using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="Event")]
    [Serializable]
    public partial class Event
    {
        /// <summary>
        /// The unique ID of this event
        /// </summary>
        [Description("The unique ID of this event")]
        [DataMember(Name = "EventId", Order = 1)]
        public int EventId { get; set; }

        /// <summary>
        /// The unique ID of this event's MMA league
        /// </summary>
        [Description("The unique ID of this event's MMA league")]
        [DataMember(Name = "LeagueId", Order = 2)]
        public int LeagueId { get; set; }

        /// <summary>
        /// The full name of the event
        /// </summary>
        [Description("The full name of the event")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The short name of the event
        /// </summary>
        [Description("The short name of the event")]
        [DataMember(Name = "ShortName", Order = 4)]
        public string ShortName { get; set; }

        /// <summary>
        /// The season the event took place
        /// </summary>
        [Description("The season the event took place")]
        [DataMember(Name = "Season", Order = 5)]
        public int? Season { get; set; }

        /// <summary>
        /// The date of the event
        /// </summary>
        [Description("The date of the event")]
        [DataMember(Name = "Day", Order = 6)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The start time and day of the event
        /// </summary>
        [Description("The start time and day of the event")]
        [DataMember(Name = "DateTime", Order = 7)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Indicates the event's status. Possible values include: Scheduled, In Progress, Final, Suspended, Postponed, Canceled
        /// </summary>
        [Description("Indicates the event's status. Possible values include: Scheduled, In Progress, Final, Suspended, Postponed, Canceled")]
        [DataMember(Name = "Status", Order = 8)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates if the event is active
        /// </summary>
        [Description("Indicates if the event is active")]
        [DataMember(Name = "Active", Order = 9)]
        public bool? Active { get; set; }

    }
}

