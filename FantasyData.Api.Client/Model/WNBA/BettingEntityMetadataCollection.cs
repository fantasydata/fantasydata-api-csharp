﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="BettingEntityMetadataCollection")]
    [Serializable]
    public partial class BettingEntityMetadataCollection
    {
        /// <summary>
        /// A list of the possible BettingBetTypes (e.g. Moneyline, Spread)
        /// </summary>
        [Description("A list of the possible BettingBetTypes (e.g. Moneyline, Spread)")]
        [DataMember(Name = "BettingBetTypes", Order = 10001)]
        public BettingEntityMetadata BettingBetTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingMartketTypes (e.g. Game Line, Team Prop)
        /// </summary>
        [Description("A list of the possible BettingMartketTypes (e.g. Game Line, Team Prop)")]
        [DataMember(Name = "BettingMarketTypes", Order = 10002)]
        public BettingEntityMetadata BettingMarketTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingPeriodTypes (e.g. Full Game, Regulation Time, 1st Half)
        /// </summary>
        [Description("A list of the possible BettingPeriodTypes (e.g. Full Game, Regulation Time, 1st Half)")]
        [DataMember(Name = "BettingPeriodTypes", Order = 10003)]
        public BettingEntityMetadata BettingPeriodTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingEventTypes (e.g. Game, Future)
        /// </summary>
        [Description("A list of the possible BettingEventTypes (e.g. Game, Future)")]
        [DataMember(Name = "BettingEventTypes", Order = 10004)]
        public BettingEntityMetadata BettingEventTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingOutcomeTypes (e.g. Home, Over)
        /// </summary>
        [Description("A list of the possible BettingOutcomeTypes (e.g. Home, Over)")]
        [DataMember(Name = "BettingOutcomeTypes", Order = 10005)]
        public BettingEntityMetadata BettingOutcomeTypes { get; set; }

        /// <summary>
        /// A list of the combinations of MarketType, BetType, & PeriodType which we willl provide automated resulting for
        /// </summary>
        [Description("A list of the combinations of MarketType, BetType, & PeriodType which we willl provide automated resulting for")]
        [DataMember(Name = "ResultedMarketMetaData", Order = 10006)]
        public BettingResultingMetadata ResultedMarketMetaData { get; set; }

        /// <summary>
        /// A list of the possible BettingResultTypes (e.g. Win, Loss, Push)
        /// </summary>
        [Description("A list of the possible BettingResultTypes (e.g. Win, Loss, Push)")]
        [DataMember(Name = "BettingResultTypes", Order = 10007)]
        public BettingEntityMetadata BettingResultTypes { get; set; }

    }
}
