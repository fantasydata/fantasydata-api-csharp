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
        /// The id of the record.  Unique only within the same entity type (i.e. BettingMarketType Ids overlap with BettingBetType Ids)
        /// </summary>
        [Description("The id of the record.  Unique only within the same entity type (i.e. BettingMarketType Ids overlap with BettingBetType Ids)")]
        [DataMember(Name = "RecordId", Order = 1)]
        public int RecordId { get; set; }

        /// <summary>
        /// A text value for the record (e.g. Moneyline, Player Prop, 3rd Quarter)
        /// </summary>
        [Description("A text value for the record (e.g. Moneyline, Player Prop, 3rd Quarter)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

