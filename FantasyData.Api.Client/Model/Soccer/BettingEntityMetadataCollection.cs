using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
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
        /// A list of the possible market types within a Betting Event (e.g. Game Line, Team prop, Player Future, etc.)
        /// </summary>
        [Description("A list of the possible market types within a Betting Event (e.g. Game Line, Team prop, Player Future, etc.)")]
        [DataMember(Name = "BettingMarketTypes", Order = 20002)]
        public BettingEntityMetadata[] BettingMarketTypes { get; set; }

        /// <summary>
        /// The name of the period type of a market (e.g. Regular Season; 1st half; 90 Minutes and Stoppage Time; etc.)
        /// </summary>
        [Description("The name of the period type of a market (e.g. Regular Season; 1st half; 90 Minutes and Stoppage Time; etc.)")]
        [DataMember(Name = "BettingPeriodTypes", Order = 20003)]
        public BettingEntityMetadata[] BettingPeriodTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingEventTypes (e.g. Game, Future)
        /// </summary>
        [Description("A list of the possible BettingEventTypes (e.g. Game, Future)")]
        [DataMember(Name = "BettingEventTypes", Order = 20004)]
        public BettingEntityMetadata[] BettingEventTypes { get; set; }

        /// <summary>
        /// A list of the possible BettingOutcomeTypes (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("A list of the possible BettingOutcomeTypes (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeTypes", Order = 20005)]
        public BettingEntityMetadata[] BettingOutcomeTypes { get; set; }

    }
}

