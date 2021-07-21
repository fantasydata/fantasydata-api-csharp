using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="BettingMarketSplit")]
    [Serializable]
    public partial class BettingMarketSplit
    {
        /// <summary>
        /// The unique id of the betting market 
        /// </summary>
        [Description("The unique id of the betting market ")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique id of the associated betting event
        /// </summary>
        [Description("The unique id of the associated betting event")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The market type id
        /// </summary>
        [Description("The market type id")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int BettingMarketTypeID { get; set; }

        /// <summary>
        /// The string description of the market type
        /// </summary>
        [Description("The string description of the market type")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The bet  type id
        /// </summary>
        [Description("The bet  type id")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// The string description of the bet type
        /// </summary>
        [Description("The string description of the bet type")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The period  type id
        /// </summary>
        [Description("The period  type id")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The string description of the period type
        /// </summary>
        [Description("The string description of the period type")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The id of the team associated (where applicable)
        /// </summary>
        [Description("The id of the team associated (where applicable)")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The string key of the team associated (where applicable)
        /// </summary>
        [Description("The string key of the team associated (where applicable)")]
        [DataMember(Name = "TeamKey", Order = 10)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The id of the player associated (where applicable)
        /// </summary>
        [Description("The id of the player associated (where applicable)")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The full name of the player associated (where applicable)
        /// </summary>
        [Description("The full name of the player associated (where applicable)")]
        [DataMember(Name = "PlayerName", Order = 12)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The list of Splits for the market
        /// </summary>
        [Description("The list of Splits for the market")]
        [DataMember(Name = "BettingSplits", Order = 20013)]
        public BettingSplit[] BettingSplits { get; set; }

    }
}

