using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="BettingEntityMetadataCollection")]
    [Serializable]
    public partial class BettingEntityMetadataCollection
    {
        /// <summary>
        /// A list of the bet types that can be found within a market (e.g. Total Significant Strikes Landed; To Win by Unanimous Decision; Moneyline)
        /// </summary>
        [Description("A list of the bet types that can be found within a market (e.g. Total Significant Strikes Landed; To Win by Unanimous Decision; Moneyline)")]
        [DataMember(Name = "BettingBetTypes", Order = 20001)]
        public BettingEntityMetadata[] BettingBetTypes { get; set; }

        /// <summary>
        /// A list of the possible market types that can be found within a market (e.g. Fight Line; Fighter Prop)
        /// </summary>
        [Description("A list of the possible market types that can be found within a market (e.g. Fight Line; Fighter Prop)")]
        [DataMember(Name = "BettingMarketTypes", Order = 20002)]
        public BettingEntityMetadata[] BettingMarketTypes { get; set; }

        /// <summary>
        /// A list of the period types that can be found within a market (e.g. Round 1; Round 2; Full Fight)
        /// </summary>
        [Description("A list of the period types that can be found within a market (e.g. Round 1; Round 2; Full Fight)")]
        [DataMember(Name = "BettingPeriodTypes", Order = 20003)]
        public BettingEntityMetadata[] BettingPeriodTypes { get; set; }

        /// <summary>
        /// A list of the possible betting events
        /// </summary>
        [Description("A list of the possible betting events")]
        [DataMember(Name = "BettingEventTypes", Order = 20004)]
        public BettingEntityMetadata[] BettingEventTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingOutcomeTypes (e.g. Under; Over; X+; etc.)
        /// </summary>
        [Description("A list of the possible BettingOutcomeTypes (e.g. Under; Over; X+; etc.)")]
        [DataMember(Name = "BettingOutcomeTypes", Order = 20005)]
        public BettingEntityMetadata[] BettingOutcomeTypes { get; set; }

    }
}

