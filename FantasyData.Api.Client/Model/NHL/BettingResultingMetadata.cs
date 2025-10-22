using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="BettingResultingMetadata")]
    [Serializable]
    public partial class BettingResultingMetadata
    {
        /// <summary>
        /// The ID associated with the name of the market type within a market
        /// </summary>
        [Description("The ID associated with the name of the market type within a market")]
        [DataMember(Name = "BettingMarketTypeId", Order = 1)]
        public int BettingMarketTypeId { get; set; }

        /// <summary>
        /// The ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeId", Order = 2)]
        public int BettingBetTypeId { get; set; }

        /// <summary>
        /// The ID associated with the betting period type which we can result
        /// </summary>
        [Description("The ID associated with the betting period type which we can result")]
        [DataMember(Name = "BettingPeriodTypeId", Order = 3)]
        public int BettingPeriodTypeId { get; set; }

    }
}

