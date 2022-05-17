using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="BettingMarketSplit")]
    [Serializable]
    public partial class BettingMarketSplit
    {
        /// <summary>
        /// Unique ID of Betting Market
        /// </summary>
        [Description("Unique ID of Betting Market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// Unique ID of associated Betting Event
        /// </summary>
        [Description("Unique ID of associated Betting Event")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// Market Type ID
        /// </summary>
        [Description("Market Type ID")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int BettingMarketTypeID { get; set; }

        /// <summary>
        /// Name of Market Type
        /// </summary>
        [Description("Name of Market Type")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// Bet Type ID 
        /// </summary>
        [Description("Bet Type ID ")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// Name of Bet Type
        /// </summary>
        [Description("Name of Bet Type")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// Betting Period Type ID
        /// </summary>
        [Description("Betting Period Type ID")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int BettingPeriodTypeID { get; set; }

        /// <summary>
        /// Name of Betting Period
        /// </summary>
        [Description("Name of Betting Period")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// ID of associated Team
        /// </summary>
        [Description("ID of associated Team")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// Short Team Name
        /// </summary>
        [Description("Short Team Name")]
        [DataMember(Name = "TeamKey", Order = 10)]
        public string TeamKey { get; set; }

        /// <summary>
        /// ID of associated Team
        /// </summary>
        [Description("ID of associated Team")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// Name of Player
        /// </summary>
        [Description("Name of Player")]
        [DataMember(Name = "PlayerName", Order = 12)]
        public string PlayerName { get; set; }

        /// <summary>
        /// List of Splits
        /// </summary>
        [Description("List of Splits")]
        [DataMember(Name = "BettingSplits", Order = 20013)]
        public BettingSplit[] BettingSplits { get; set; }

    }
}

