using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="BettingEntityMetadata")]
    [Serializable]
    public partial class BettingEntityMetadata
    {
        /// <summary>
        /// The ID of the record. Unique only within the same entity type (i.e. BettingMarketType IDs have commonality with BettingBetType IDs)
        /// </summary>
        [Description("The ID of the record. Unique only within the same entity type (i.e. BettingMarketType IDs have commonality with BettingBetType IDs)")]
        [DataMember(Name = "RecordId", Order = 1)]
        public int RecordId { get; set; }

        /// <summary>
        /// Denotes the name of the type  (e.g. Betting Market Type, Betting Event Type, Betting Period Type)
        /// </summary>
        [Description("Denotes the name of the type  (e.g. Betting Market Type, Betting Event Type, Betting Period Type)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not this market is currently is use
        /// </summary>
        [Description("Whether or not this market is currently is use")]
        [DataMember(Name = "Active", Order = 3)]
        public bool? Active { get; set; }

    }
}

