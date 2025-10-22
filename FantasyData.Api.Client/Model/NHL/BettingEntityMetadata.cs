using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="BettingEntityMetadata")]
    [Serializable]
    public partial class BettingEntityMetadata
    {
        /// <summary>
        /// The unique ID of this record. Unique only within the same entity type (i.e. BettingMarketTypeIDs overlap with BettingBetTypeIDs)
        /// </summary>
        [Description("The unique ID of this record. Unique only within the same entity type (i.e. BettingMarketTypeIDs overlap with BettingBetTypeIDs)")]
        [DataMember(Name = "RecordId", Order = 1)]
        public int RecordId { get; set; }

        /// <summary>
        /// A text value for the record (e.g. Moneyline; Player Prop; 3rd Quarter)
        /// </summary>
        [Description("A text value for the record (e.g. Moneyline; Player Prop; 3rd Quarter)")]
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

