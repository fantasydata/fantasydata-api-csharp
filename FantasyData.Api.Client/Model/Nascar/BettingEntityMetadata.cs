using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="BettingEntityMetadata")]
    [Serializable]
    public partial class BettingEntityMetadata
    {
        /// <summary>
        /// The ID of the record. Unique only within the same entity type (i.e. BettingMarketType Ids overlap with BettingBetType Ids).
        /// </summary>
        [Description("The ID of the record. Unique only within the same entity type (i.e. BettingMarketType Ids overlap with BettingBetType Ids).")]
        [DataMember(Name = "RecordID", Order = 1)]
        public int RecordID { get; set; }

        /// <summary>
        /// Denotes the name of the type (e.g. Betting Market Type, Betting Event Type, Betting Period Type)
        /// </summary>
        [Description("Denotes the name of the type (e.g. Betting Market Type, Betting Event Type, Betting Period Type)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not this market is currently in use
        /// </summary>
        [Description("Whether or not this market is currently in use")]
        [DataMember(Name = "Active", Order = 3)]
        public bool? Active { get; set; }

    }
}

