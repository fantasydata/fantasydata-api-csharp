using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="BettingEntityMetadataCollection")]
    [Serializable]
    public partial class BettingEntityMetadataCollection
    {
        /// <summary>
        /// The list of the bet types that can be found within a market (e.g. Best Score; Tournament Winner; Top 10 Finish)
        /// </summary>
        [Description("The list of the bet types that can be found within a market (e.g. Best Score; Tournament Winner; Top 10 Finish)")]
        [DataMember(Name = "BettingBetTypes", Order = 20001)]
        public BettingEntityMetadata[] BettingBetTypes { get; set; }

        /// <summary>
        /// A list of the possible market types within a betting event (e.g. Tournament Prop; Matchup Prop; Group Prop)
        /// </summary>
        [Description("A list of the possible market types within a betting event (e.g. Tournament Prop; Matchup Prop; Group Prop)")]
        [DataMember(Name = "BettingMarketTypes", Order = 20002)]
        public BettingEntityMetadata[] BettingMarketTypes { get; set; }

        /// <summary>
        /// A list of the possible period types within a betting event (e.g. Round 1, Through Round 2; Tournament)
        /// </summary>
        [Description("A list of the possible period types within a betting event (e.g. Round 1, Through Round 2; Tournament)")]
        [DataMember(Name = "BettingPeriodTypes", Order = 20003)]
        public BettingEntityMetadata[] BettingPeriodTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingEventTypes
        /// </summary>
        [Description("A list of the possible BettingEventTypes")]
        [DataMember(Name = "BettingEventTypes", Order = 20004)]
        public BettingEntityMetadata[] BettingEventTypes { get; set; }

        /// <summary>
        /// A list of the possible betting outcomes types (e.g. Yes; No)
        /// </summary>
        [Description("A list of the possible betting outcomes types (e.g. Yes; No)")]
        [DataMember(Name = "BettingOutcomeTypes", Order = 20005)]
        public BettingEntityMetadata[] BettingOutcomeTypes { get; set; }

    }
}

