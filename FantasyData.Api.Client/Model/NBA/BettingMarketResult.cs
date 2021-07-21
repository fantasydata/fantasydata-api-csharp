using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="BettingMarketResult")]
    [Serializable]
    public partial class BettingMarketResult
    {
        /// <summary>
        /// The unique identifier of this market
        /// </summary>
        [Description("The unique identifier of this market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The BettingMarketTypeID of this market
        /// </summary>
        [Description("The BettingMarketTypeID of this market")]
        [DataMember(Name = "BettingMarketTypeID", Order = 2)]
        public int BettingMarketTypeID { get; set; }

        /// <summary>
        /// The BettingMarketType of this market
        /// </summary>
        [Description("The BettingMarketType of this market")]
        [DataMember(Name = "BettingMarketType", Order = 3)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The BettingBetTypeID of this market
        /// </summary>
        [Description("The BettingBetTypeID of this market")]
        [DataMember(Name = "BettingBetTypeID", Order = 4)]
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// The BettingBetType of this market
        /// </summary>
        [Description("The BettingBetType of this market")]
        [DataMember(Name = "BettingBetType", Order = 5)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this market
        /// </summary>
        [Description("The BettingPeriodTypeID of this market")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 6)]
        public int BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The BettingPeriodType of this market
        /// </summary>
        [Description("The BettingPeriodType of this market")]
        [DataMember(Name = "BettingPeriodType", Order = 7)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The generic name of this market
        /// </summary>
        [Description("The generic name of this market")]
        [DataMember(Name = "Name", Order = 8)]
        public string Name { get; set; }

        /// <summary>
        /// The team id of the team tied to this market (if applicable)
        /// </summary>
        [Description("The team id of the team tied to this market (if applicable)")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The team key of the team tied to this market (if applicable)
        /// </summary>
        [Description("The team key of the team tied to this market (if applicable)")]
        [DataMember(Name = "TeamKey", Order = 10)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The player id of the player tied to this market (if applicable)
        /// </summary>
        [Description("The player id of the player tied to this market (if applicable)")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The name of the player tied to this market (if applicable)
        /// </summary>
        [Description("The name of the player tied to this market (if applicable)")]
        [DataMember(Name = "PlayerName", Order = 12)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The list of outcomes under this market with results
        /// </summary>
        [Description("The list of outcomes under this market with results")]
        [DataMember(Name = "BettingOutcomeResults", Order = 20013)]
        public BettingOutcomeResult[] BettingOutcomeResults { get; set; }

    }
}

