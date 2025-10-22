using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="BettingEntityMetadataCollection")]
    [Serializable]
    public partial class BettingEntityMetadataCollection
    {
        /// <summary>
        /// The list of the bet types that can be found within a market
        /// </summary>
        [Description("The list of the bet types that can be found within a market")]
        [DataMember(Name = "BettingBetTypes", Order = 20001)]
        public BettingEntityMetadata[] BettingBetTypes { get; set; }

        /// <summary>
        /// A list of the possible Market Types within a Betting Event (e.g. Game Line, Team prop, Player Future, etc.)
        /// </summary>
        [Description("A list of the possible Market Types within a Betting Event (e.g. Game Line, Team prop, Player Future, etc.)")]
        [DataMember(Name = "BettingMarketTypes", Order = 20002)]
        public BettingEntityMetadata[] BettingMarketTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingPeriodTypes (e.g. Full Game, Regulation Time, 1st Half)
        /// </summary>
        [Description("A list of the possible BettingPeriodTypes (e.g. Full Game, Regulation Time, 1st Half)")]
        [DataMember(Name = "BettingPeriodTypes", Order = 20003)]
        public BettingEntityMetadata[] BettingPeriodTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingEventTypes (e.g. Game; Future)
        /// </summary>
        [Description("A list of the possible BettingEventTypes (e.g. Game; Future)")]
        [DataMember(Name = "BettingEventTypes", Order = 20004)]
        public BettingEntityMetadata[] BettingEventTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingOutcomeTypes (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("A list of the possible BettingOutcomeTypes (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeTypes", Order = 20005)]
        public BettingEntityMetadata[] BettingOutcomeTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingResultTypes (e.g. Win; Loss; Push; Not Resulted; Incomplete)
        /// </summary>
        [Description("A list of the possible BettingResultTypes (e.g. Win; Loss; Push; Not Resulted; Incomplete)")]
        [DataMember(Name = "BettingResultTypes", Order = 20006)]
        public BettingEntityMetadata[] BettingResultTypes { get; set; }

        /// <summary>
        /// A list of the combinations of BettingMarketTypeID, BettingBetTypeID, and BettingPeriodTypeID that will be resulted
        /// </summary>
        [Description("A list of the combinations of BettingMarketTypeID, BettingBetTypeID, and BettingPeriodTypeID that will be resulted")]
        [DataMember(Name = "ResultedMarketMetaData", Order = 20007)]
        public BettingResultingMetadata[] ResultedMarketMetaData { get; set; }

    }
}

