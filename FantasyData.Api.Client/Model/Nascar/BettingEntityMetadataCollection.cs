using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="BettingEntityMetadataCollection")]
    [Serializable]
    public partial class BettingEntityMetadataCollection
    {
        /// <summary>
        /// The list of the bet types that can be found within a market (e.g. Race Winner; Top 3 Finish)
        /// </summary>
        [Description("The list of the bet types that can be found within a market (e.g. Race Winner; Top 3 Finish)")]
        [DataMember(Name = "BettingBetTypes", Order = 20001)]
        public BettingEntityMetadata[] BettingBetTypes { get; set; }

        /// <summary>
        /// A list of the possible market types within a betting event (e.g. Race Line; Drive Future)
        /// </summary>
        [Description("A list of the possible market types within a betting event (e.g. Race Line; Drive Future)")]
        [DataMember(Name = "BettingMarketTypes", Order = 20002)]
        public BettingEntityMetadata[] BettingMarketTypes { get; set; }

        /// <summary>
        /// A list of the possible period types within a betting event (e.g. Race; Truck Series; Cup Series)
        /// </summary>
        [Description("A list of the possible period types within a betting event (e.g. Race; Truck Series; Cup Series)")]
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

