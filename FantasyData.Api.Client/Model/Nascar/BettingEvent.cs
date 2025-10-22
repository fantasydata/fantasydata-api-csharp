using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="BettingEvent")]
    [Serializable]
    public partial class BettingEvent
    {
        /// <summary>
        /// The unique ID assocated with the betting event
        /// </summary>
        [Description("The unique ID assocated with the betting event")]
        [DataMember(Name = "BettingEventID", Order = 1)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The name of this betting event
        /// </summary>
        [Description("The name of this betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The season of this betting event
        /// </summary>
        [Description("The season of this betting event")]
        [DataMember(Name = "Season", Order = 3)]
        public int? Season { get; set; }

        /// <summary>
        /// The ID associated with the type of betting event
        /// </summary>
        [Description("The ID associated with the type of betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 4)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// Indicates the type of betting event
        /// </summary>
        [Description("Indicates the type of betting event")]
        [DataMember(Name = "BettingEventType", Order = 5)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The last day for betting on this event
        /// </summary>
        [Description("The last day for betting on this event")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date/time when this betting event was created (in US Eastern Time)
        /// </summary>
        [Description("The date/time when this betting event was created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated date of this betting event
        /// </summary>
        [Description("The last updated date of this betting event")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The unique ID of the race tied to this event
        /// </summary>
        [Description("The unique ID of the race tied to this event")]
        [DataMember(Name = "RaceID", Order = 9)]
        public int? RaceID { get; set; }

        /// <summary>
        /// A list of the possible betting markets within a betting event
        /// </summary>
        [Description("A list of the possible betting markets within a betting event")]
        [DataMember(Name = "BettingMarkets", Order = 20010)]
        public BettingMarket[] BettingMarkets { get; set; }

    }
}

