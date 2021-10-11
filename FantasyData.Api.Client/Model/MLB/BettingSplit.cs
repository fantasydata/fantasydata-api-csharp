using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="BettingSplit")]
    [Serializable]
    public partial class BettingSplit
    {
        /// <summary>
        /// The unique id of this specific instance of the split
        /// </summary>
        [Description("The unique id of this specific instance of the split")]
        [DataMember(Name = "BettingMarketSplitID", Order = 1)]
        public int BettingMarketSplitID { get; set; }

        /// <summary>
        /// The id of the market associated
        /// </summary>
        [Description("The id of the market associated")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The outcome type id this split is associated with
        /// </summary>
        [Description("The outcome type id this split is associated with")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 3)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The string description of this outcome type
        /// </summary>
        [Description("The string description of this outcome type")]
        [DataMember(Name = "BettingOutcomeType", Order = 4)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The percentage of the bets on this market taken by this type of bet
        /// </summary>
        [Description("The percentage of the bets on this market taken by this type of bet")]
        [DataMember(Name = "BetPercentage", Order = 5)]
        public int? BetPercentage { get; set; }

        /// <summary>
        /// The percentage of the money placed in wagers on this market taken by this type of bet
        /// </summary>
        [Description("The percentage of the money placed in wagers on this market taken by this type of bet")]
        [DataMember(Name = "MoneyPercentage", Order = 6)]
        public int? MoneyPercentage { get; set; }

        /// <summary>
        /// The timestamp this set of values was first seen
        /// </summary>
        [Description("The timestamp this set of values was first seen")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp this set of values was last seen
        /// </summary>
        [Description("The timestamp this set of values was last seen")]
        [DataMember(Name = "LastSeen", Order = 8)]
        public DateTime LastSeen { get; set; }

    }
}

