using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="BettingResultingMetadata")]
    [Serializable]
    public partial class BettingResultingMetadata
    {
        /// <summary>
        /// The unique ID associated with the market type of the betting market
        /// </summary>
        [Description("The unique ID associated with the market type of the betting market")]
        [DataMember(Name = "BettingMarketTypeId", Order = 1)]
        public int BettingMarketTypeId { get; set; }

        /// <summary>
        /// The ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeId", Order = 2)]
        public int BettingBetTypeId { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this market
        /// </summary>
        [Description("The BettingPeriodTypeID of this market")]
        [DataMember(Name = "BettingPeriodTypeId", Order = 3)]
        public int BettingPeriodTypeId { get; set; }

    }
}

