using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="BettingSplit")]
    [Serializable]
    public partial class BettingSplit
    {
        /// <summary>
        /// The unique ID of this betting split insatnce
        /// </summary>
        [Description("The unique ID of this betting split insatnce")]
        [DataMember(Name = "BettingMarketSplitID", Order = 1)]
        public int BettingMarketSplitID { get; set; }

        /// <summary>
        /// The unique ID of the betting market
        /// </summary>
        [Description("The unique ID of the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The ID associated with the betting outcome type
        /// </summary>
        [Description("The ID associated with the betting outcome type")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 3)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of the betting outcome within a betting market (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of the betting outcome within a betting market (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 4)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// Percentage of bets placed on a specific outcome
        /// </summary>
        [Description("Percentage of bets placed on a specific outcome")]
        [DataMember(Name = "BetPercentage", Order = 5)]
        public int? BetPercentage { get; set; }

        /// <summary>
        /// The percent of money on this outcome
        /// </summary>
        [Description("The percent of money on this outcome")]
        [DataMember(Name = "MoneyPercentage", Order = 6)]
        public int? MoneyPercentage { get; set; }

        /// <summary>
        /// The date and time when this betting split was created in US Eastern Time
        /// </summary>
        [Description("The date and time when this betting split was created in US Eastern Time")]
        [DataMember(Name = "Created", Order = 7)]
        public DateTime Created { get; set; }

        /// <summary>
        /// When this split was last updated
        /// </summary>
        [Description("When this split was last updated")]
        [DataMember(Name = "LastSeen", Order = 8)]
        public DateTime LastSeen { get; set; }

    }
}

