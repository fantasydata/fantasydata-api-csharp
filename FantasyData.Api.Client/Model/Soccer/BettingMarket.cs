using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="BettingMarket")]
    [Serializable]
    public partial class BettingMarket
    {
        /// <summary>
        /// The unique ID of the betting market
        /// </summary>
        [Description("The unique ID of the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique ID assocated with the betting event
        /// </summary>
        [Description("The unique ID assocated with the betting event")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The unique ID associated with the name of the market type
        /// </summary>
        [Description("The unique ID associated with the name of the market type")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int? BettingMarketTypeID { get; set; }

        /// <summary>
        /// The name of the market type within a betting market (e.g. Player Prop, Team Prop, Game Prop, etc.)
        /// </summary>
        [Description("The name of the market type within a betting market (e.g. Player Prop, Team Prop, Game Prop, etc.)")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int? BettingBetTypeID { get; set; }

        /// <summary>
        /// The name of the bet type within a market (e.g. Spread, Moneyline, Total Goals, etc.)
        /// </summary>
        [Description("The name of the bet type within a market (e.g. Spread, Moneyline, Total Goals, etc.)")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The ID associated with the betting period type which we can result
        /// </summary>
        [Description("The ID associated with the betting period type which we can result")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int? BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The name of the period type of a market (e.g. Regular Season; 1st half; 90 Minutes and Stoppage Time; etc.)
        /// </summary>
        [Description("The name of the period type of a market (e.g. Regular Season; 1st half; 90 Minutes and Stoppage Time; etc.)")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The name of this betting market
        /// </summary>
        [Description("The name of this betting market")]
        [DataMember(Name = "Name", Order = 9)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the team associated with betting market
        /// </summary>
        [Description("The unique ID of the team associated with betting market")]
        [DataMember(Name = "TeamID", Order = 10)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team associated with this betting market
        /// </summary>
        [Description("The abbreviation [Key] of the team associated with this betting market")]
        [DataMember(Name = "TeamKey", Order = 11)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career")]
        [DataMember(Name = "PlayerID", Order = 12)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The player's full name tied to this betting market
        /// </summary>
        [Description("The player's full name tied to this betting market")]
        [DataMember(Name = "PlayerName", Order = 13)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The created date of this market (in US Eastern Time)
        /// </summary>
        [Description("The created date of this market (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 14)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when the betting market record was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the betting market record was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 15)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The sportsbooks that have had odds in this market
        /// </summary>
        [Description("The sportsbooks that have had odds in this market")]
        [DataMember(Name = "AvailableSportsbooks", Order = 20016)]
        public Sportsbook[] AvailableSportsbooks { get; set; }

        /// <summary>
        /// Shows if any bets are currently available for betting in this market
        /// </summary>
        [Description("Shows if any bets are currently available for betting in this market")]
        [DataMember(Name = "AnyBetsAvailable", Order = 17)]
        public bool? AnyBetsAvailable { get; set; }

        /// <summary>
        /// The list of betting outcomes from each sportsbook in this market
        /// </summary>
        [Description("The list of betting outcomes from each sportsbook in this market")]
        [DataMember(Name = "BettingOutcomes", Order = 20018)]
        public BettingOutcome[] BettingOutcomes { get; set; }

        /// <summary>
        /// The single set of consesnus outcomes of this market
        /// </summary>
        [Description("The single set of consesnus outcomes of this market")]
        [DataMember(Name = "ConsensusOutcomes", Order = 20019)]
        public ConsensusOutcome[] ConsensusOutcomes { get; set; }

    }
}

