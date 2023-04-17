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
        /// The unique identifier for this betting event
        /// </summary>
        [Description("The unique identifier for this betting event")]
        [DataMember(Name = "BettingEventId", Order = 1)]
        public int BettingEventId { get; set; }

        /// <summary>
        /// The name of this betting event
        /// </summary>
        [Description("The name of this betting event")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The BettingEventTypeId of this betting event
        /// </summary>
        [Description("The BettingEventTypeId of this betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 3)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// The name of the betting event type for this betting event
        /// </summary>
        [Description("The name of the betting event type for this betting event")]
        [DataMember(Name = "BettingEventType", Order = 4)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The start date of this betting event
        /// </summary>
        [Description("The start date of this betting event")]
        [DataMember(Name = "StartDate", Order = 5)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date this betting even was created
        /// </summary>
        [Description("The date this betting even was created")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The last updated date of this betting event
        /// </summary>
        [Description("The last updated date of this betting event")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The Id of the Fight related to this betting event
        /// </summary>
        [Description("The Id of the Fight related to this betting event")]
        [DataMember(Name = "FightId", Order = 8)]
        public int? FightId { get; set; }

        /// <summary>
        /// The list of betting markets for this betting event
        /// </summary>
        [Description("The list of betting markets for this betting event")]
        [DataMember(Name = "BettingMarkets", Order = 20009)]
        public BettingMarket[] BettingMarkets { get; set; }

    }
}

