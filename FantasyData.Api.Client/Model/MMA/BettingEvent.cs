using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="BettingEvent")]
    [Serializable]
    public partial class BettingEvent
    {
        /// <summary>
        /// The unique ID associated with the betting event
        /// </summary>
        [Description("The unique ID associated with the betting event")]
        [DataMember(Name = "BettingEventId", Order = 1)]
        public int BettingEventId { get; set; }

        /// <summary>
        /// The name of the betting event
        /// </summary>
        [Description("The name of the betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The ID associated with the type of betting event
        /// </summary>
        [Description("The ID associated with the type of betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 3)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// Indicates the type of betting event
        /// </summary>
        [Description("Indicates the type of betting event")]
        [DataMember(Name = "BettingEventType", Order = 4)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The start date of this betting event
        /// </summary>
        [Description("The start date of this betting event")]
        [DataMember(Name = "StartDate", Order = 5)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The timestamp of when the betting event was created
        /// </summary>
        [Description("The timestamp of when the betting event was created")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The last updated date of this betting event (in US Eastern Time)
        /// </summary>
        [Description("The last updated date of this betting event (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The unique ID of the fight related to the betting event
        /// </summary>
        [Description("The unique ID of the fight related to the betting event")]
        [DataMember(Name = "FightId", Order = 8)]
        public int? FightId { get; set; }

        /// <summary>
        /// A list of possible betting markets found within the betting event
        /// </summary>
        [Description("A list of possible betting markets found within the betting event")]
        [DataMember(Name = "BettingMarkets", Order = 20009)]
        public BettingMarket[] BettingMarkets { get; set; }

    }
}

