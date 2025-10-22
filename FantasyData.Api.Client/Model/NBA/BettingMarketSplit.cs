using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="BettingMarketSplit")]
    [Serializable]
    public partial class BettingMarketSplit
    {
        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique ID of the betting event associated with this split
        /// </summary>
        [Description("The unique ID of the betting event associated with this split")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The unique ID that distinguishes the different types of Market Types
        /// </summary>
        [Description("The unique ID that distinguishes the different types of Market Types")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int BettingMarketTypeID { get; set; }

        /// <summary>
        /// The name of the market type within a market (e.g. Player Prop, Team Prop, Game Prop, etc.)
        /// </summary>
        [Description("The name of the market type within a market (e.g. Player Prop, Team Prop, Game Prop, etc.)")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The unique ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The unique ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// The name of the bet type within a market (e.g. Total Points, Moneyline, Spread, etc.)
        /// </summary>
        [Description("The name of the bet type within a market (e.g. Total Points, Moneyline, Spread, etc.)")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this type of market which we can result
        /// </summary>
        [Description("The BettingPeriodTypeID of this type of market which we can result")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The name of the period type of this market (e.g. Full Game; 1st Half; 2nd Quarter; Regular Season)
        /// </summary>
        [Description("The name of the period type of this market (e.g. Full Game; 1st Half; 2nd Quarter; Regular Season)")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The unique ID of the team tied to this market split (if applicable)
        /// </summary>
        [Description("The unique ID of the team tied to this market split (if applicable)")]
        [DataMember(Name = "TeamID", Order = 9)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team associated with this market
        /// </summary>
        [Description("The abbreviation [Key] of the team associated with this market")]
        [DataMember(Name = "TeamKey", Order = 10)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 11)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The name of the player tied to this market (if applicable)
        /// </summary>
        [Description("The name of the player tied to this market (if applicable)")]
        [DataMember(Name = "PlayerName", Order = 12)]
        public string PlayerName { get; set; }

        /// <summary>
        /// A list of betting splits for a given game
        /// </summary>
        [Description("A list of betting splits for a given game")]
        [DataMember(Name = "BettingSplits", Order = 20013)]
        public BettingSplit[] BettingSplits { get; set; }

    }
}

