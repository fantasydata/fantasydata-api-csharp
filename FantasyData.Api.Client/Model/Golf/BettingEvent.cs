using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="BettingEvent")]
    [Serializable]
    public partial class BettingEvent
    {
        /// <summary>
        /// The unique identifier for this betting event
        /// </summary>
        [Description("The unique identifier for this betting event")]
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
        /// The identifier of the bet type of this betting event
        /// </summary>
        [Description("The identifier of the bet type of this betting event")]
        [DataMember(Name = "BettingEventTypeID", Order = 4)]
        public int BettingEventTypeID { get; set; }

        /// <summary>
        /// The name of the bet type of this betting event
        /// </summary>
        [Description("The name of the bet type of this betting event")]
        [DataMember(Name = "BettingEventType", Order = 5)]
        public string BettingEventType { get; set; }

        /// <summary>
        /// The last day for betting on this event
        /// </summary>
        [Description("The last day for betting on this event")]
        [DataMember(Name = "StartDate", Order = 6)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The created date of this betting event
        /// </summary>
        [Description("The created date of this betting event")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated date of this betting event
        /// </summary>
        [Description("The last updated date of this betting event")]
        [DataMember(Name = "Updated", Order = 8)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The TournamentId of the tournament tied to this event
        /// </summary>
        [Description("The TournamentId of the tournament tied to this event")]
        [DataMember(Name = "TournamentId", Order = 9)]
        public int? TournamentId { get; set; }

        /// <summary>
        /// The list of betting markets for this event
        /// </summary>
        [Description("The list of betting markets for this event")]
        [DataMember(Name = "BettingMarkets", Order = 20010)]
        public BettingMarket[] BettingMarkets { get; set; }

    }
}

