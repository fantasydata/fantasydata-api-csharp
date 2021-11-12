using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="BettingResultingMetadata")]
    [Serializable]
    public partial class BettingResultingMetadata
    {
        /// <summary>
        /// The BettingMarketTypeID of this type of market which we can result
        /// </summary>
        [Description("The BettingMarketTypeID of this type of market which we can result")]
        [DataMember(Name = "BettingMarketTypeId", Order = 1)]
        public int BettingMarketTypeId { get; set; }

        /// <summary>
        /// The BettingBetTypeID of this type of market which we can result
        /// </summary>
        [Description("The BettingBetTypeID of this type of market which we can result")]
        [DataMember(Name = "BettingBetTypeId", Order = 2)]
        public int BettingBetTypeId { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this type of market which we can result
        /// </summary>
        [Description("The BettingPeriodTypeID of this type of market which we can result")]
        [DataMember(Name = "BettingPeriodTypeId", Order = 3)]
        public int BettingPeriodTypeId { get; set; }

    }
}

