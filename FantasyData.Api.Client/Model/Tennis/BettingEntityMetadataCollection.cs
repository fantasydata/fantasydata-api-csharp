using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="BettingEntityMetadataCollection")]
    [Serializable]
    public partial class BettingEntityMetadataCollection
    {
        /// <summary>
        /// A list of the possible BettingBetTypes
        /// </summary>
        [Description("A list of the possible BettingBetTypes")]
        [DataMember(Name = "BettingBetTypes", Order = 10001)]
        public BettingEntityMetadata BettingBetTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingMartketTypes
        /// </summary>
        [Description("A list of the possible BettingMartketTypes")]
        [DataMember(Name = "BettingMarketTypes", Order = 10002)]
        public BettingEntityMetadata BettingMarketTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingPeriodTypes
        /// </summary>
        [Description("A list of the possible BettingPeriodTypes")]
        [DataMember(Name = "BettingPeriodTypes", Order = 10003)]
        public BettingEntityMetadata BettingPeriodTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingEventTypes
        /// </summary>
        [Description("A list of the possible BettingEventTypes")]
        [DataMember(Name = "BettingEventTypes", Order = 10004)]
        public BettingEntityMetadata BettingEventTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingOutcomeTypes
        /// </summary>
        [Description("A list of the possible BettingOutcomeTypes")]
        [DataMember(Name = "BettingOutcomeTypes", Order = 10005)]
        public BettingEntityMetadata BettingOutcomeTypes { get; set; }

        /// <summary>
        /// A list of the combinations of MarketType; BetType; & PeriodType which we will provide automated resulting for
        /// </summary>
        [Description("A list of the combinations of MarketType; BetType; & PeriodType which we will provide automated resulting for")]
        [DataMember(Name = "ResultedMarketMetaData", Order = 10006)]
        public BettingResultingMetadata ResultedMarketMetaData { get; set; }

        /// <summary>
        /// A list of the possible BettingResultTypes
        /// </summary>
        [Description("A list of the possible BettingResultTypes")]
        [DataMember(Name = "BettingResultTypes", Order = 10007)]
        public BettingEntityMetadata BettingResultTypes { get; set; }

    }
}

