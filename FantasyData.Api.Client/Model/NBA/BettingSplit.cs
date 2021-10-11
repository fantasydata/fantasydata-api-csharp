using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="BettingSplit")]
    [Serializable]
    public partial class BettingSplit
    {
        /// <summary>
        /// Unique ID of this Split instance
        /// </summary>
        [Description("Unique ID of this Split instance")]
        [DataMember(Name = "BettingMarketSplitID", Order = 1)]
        public int BettingMarketSplitID { get; set; }

        /// <summary>
        /// ID of associated Betting Market
        /// </summary>
        [Description("ID of associated Betting Market")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// ID of associated Betting Outcome Type
        /// </summary>
        [Description("ID of associated Betting Outcome Type")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 3)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// Name of Betting Outcome Type (e.g. Home, Away, Under, Over)
        /// </summary>
        [Description("Name of Betting Outcome Type (e.g. Home, Away, Under, Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 4)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// Percent of Bets Placed on this Outcome
        /// </summary>
        [Description("Percent of Bets Placed on this Outcome")]
        [DataMember(Name = "BetPercentage", Order = 5)]
        public int? BetPercentage { get; set; }

        /// <summary>
        /// Percent of Money on this Outcome
        /// </summary>
        [Description("Percent of Money on this Outcome")]
        [DataMember(Name = "MoneyPercentage", Order = 6)]
        public int? MoneyPercentage { get; set; }

        /// <summary>
        /// When this split was first seen
        /// </summary>
        [Description("When this split was first seen")]
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

