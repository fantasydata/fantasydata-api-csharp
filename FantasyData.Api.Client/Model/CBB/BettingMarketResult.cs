using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="BettingMarketResult")]
    [Serializable]
    public partial class BettingMarketResult
    {
        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// ID that distinguishes the different types of Market Types
        /// </summary>
        [Description("ID that distinguishes the different types of Market Types")]
        [DataMember(Name = "BettingMarketTypeID", Order = 2)]
        public int BettingMarketTypeID { get; set; }

        /// <summary>
        /// The name of the market type (e.g. Player Prop, Team Prop, Game Prop, etc.)
        /// </summary>
        [Description("The name of the market type (e.g. Player Prop, Team Prop, Game Prop, etc.)")]
        [DataMember(Name = "BettingMarketType", Order = 3)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeID", Order = 4)]
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// The name of the bet type within a market (e.g. Total Points, Moneyline, Spread, etc.)
        /// </summary>
        [Description("The name of the bet type within a market (e.g. Total Points, Moneyline, Spread, etc.)")]
        [DataMember(Name = "BettingBetType", Order = 5)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this market
        /// </summary>
        [Description("The BettingPeriodTypeID of this market")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 6)]
        public int BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The BettingPeriodType of this market (e.g. Full Game; 1st Half; 2nd Quarter; Regular Season)
        /// </summary>
        [Description("The BettingPeriodType of this market (e.g. Full Game; 1st Half; 2nd Quarter; Regular Season)")]
        [DataMember(Name = "BettingPeriodType", Order = 7)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The generic name of this market
        /// </summary>
        [Description("The generic name of this market")]
        [DataMember(Name = "Name", Order = 8)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the team (if applicable)
        /// </summary>
        [Description("The unique ID of the team (if applicable)")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team tied to this market (if applicable)
        /// </summary>
        [Description("The abbreviation [Key] of the team tied to this market (if applicable)")]
        [DataMember(Name = "TeamKey", Order = 10)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO (if applicable). Note: this ID will stay with the player throughout their collegiate career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO (if applicable). Note: this ID will stay with the player throughout their collegiate career")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The full name of the player associated with this market (if applicable)
        /// </summary>
        [Description("The full name of the player associated with this market (if applicable)")]
        [DataMember(Name = "PlayerName", Order = 12)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The list of outcomes under this market with results
        /// </summary>
        [Description("The list of outcomes under this market with results")]
        [DataMember(Name = "BettingOutcomeResults", Order = 20013)]
        public BettingOutcomeResult[] BettingOutcomeResults { get; set; }

        /// <summary>
        /// Indicates whether resulting is supported for this kind of BettingMarket
        /// </summary>
        [Description("Indicates whether resulting is supported for this kind of BettingMarket")]
        [DataMember(Name = "IsMarketResultingSupported", Order = 14)]
        public bool IsMarketResultingSupported { get; set; }

    }
}

