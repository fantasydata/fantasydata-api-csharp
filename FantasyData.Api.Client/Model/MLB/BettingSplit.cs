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
        /// The unique ID assciated with the betting split
        /// </summary>
        [Description("The unique ID assciated with the betting split")]
        [DataMember(Name = "BettingMarketSplitID", Order = 1)]
        public int BettingMarketSplitID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique ID associated with this BettingOutcomeType
        /// </summary>
        [Description("The unique ID associated with this BettingOutcomeType")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 3)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of BettingOutcomeType (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of BettingOutcomeType (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 4)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// Percentage of bets placed on a specific outcome
        /// </summary>
        [Description("Percentage of bets placed on a specific outcome")]
        [DataMember(Name = "BetPercentage", Order = 5)]
        public int? BetPercentage { get; set; }

        /// <summary>
        /// The percentage of the money placed in wagers on this market taken by this type of bet
        /// </summary>
        [Description("The percentage of the money placed in wagers on this market taken by this type of bet")]
        [DataMember(Name = "MoneyPercentage", Order = 6)]
        public int? MoneyPercentage { get; set; }

        /// <summary>
        /// The date and time this betting split was created in US Eastern Time
        /// </summary>
        [Description("The date and time this betting split was created in US Eastern Time")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date and time this set of values was last seen
        /// </summary>
        [Description("The date and time this set of values was last seen")]
        [DataMember(Name = "LastSeen", Order = 8)]
        public DateTime LastSeen { get; set; }

    }
}

