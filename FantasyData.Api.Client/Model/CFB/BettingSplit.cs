using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
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
        /// The BettingOutcomeTypeID of this outcome
        /// </summary>
        [Description("The BettingOutcomeTypeID of this outcome")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 3)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// Name of Betting Outcome Type (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("Name of Betting Outcome Type (e.g. Home; Away; Under; Over)")]
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
        /// The timestamp this set of values was last seen (in US Eastern Time)
        /// </summary>
        [Description("The timestamp this set of values was last seen (in US Eastern Time)")]
        [DataMember(Name = "LastSeen", Order = 8)]
        public DateTime LastSeen { get; set; }

    }
}

