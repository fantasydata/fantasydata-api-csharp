using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="BettingMarket")]
    [Serializable]
    public partial class BettingMarket
    {
        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting market within the betting event
        /// </summary>
        [Description("The unique ID associated with the betting market within the betting event")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The ID that distinguishes the different types of Market Types
        /// </summary>
        [Description("The ID that distinguishes the different types of Market Types")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int? BettingMarketTypeID { get; set; }

        /// <summary>
        /// The name of the market type within a market (e.g. Golfer Prop, Tournament Prop, etc.)
        /// </summary>
        [Description("The name of the market type within a market (e.g. Golfer Prop, Tournament Prop, etc.)")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int? BettingBetTypeID { get; set; }

        /// <summary>
        /// The name of the bet type within a market (e.g. Tournament Winner, Best Score, etc.)
        /// </summary>
        [Description("The name of the bet type within a market (e.g. Tournament Winner, Best Score, etc.)")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this type of market which we can result
        /// </summary>
        [Description("The BettingPeriodTypeID of this type of market which we can result")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int? BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The name of the period type of this market (e.g. Round 1, Tournament, etc.)
        /// </summary>
        [Description("The name of the period type of this market (e.g. Round 1, Tournament, etc.)")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The generic name of this market
        /// </summary>
        [Description("The generic name of this market")]
        [DataMember(Name = "Name", Order = 9)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the golfer tied to this market (if applicable)
        /// </summary>
        [Description("The unique ID of the golfer tied to this market (if applicable)")]
        [DataMember(Name = "PlayerID", Order = 10)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The name of the golfer tied to this market (if applicable)
        /// </summary>
        [Description("The name of the golfer tied to this market (if applicable)")]
        [DataMember(Name = "PlayerName", Order = 11)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The timestamp of when this betting market was created
        /// </summary>
        [Description("The timestamp of when this betting market was created")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated date of this market
        /// </summary>
        [Description("The last updated date of this market")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The sportsbooks that have had odds in this market
        /// </summary>
        [Description("The sportsbooks that have had odds in this market")]
        [DataMember(Name = "AvailableSportsbooks", Order = 20014)]
        public Sportsbook[] AvailableSportsbooks { get; set; }

        /// <summary>
        /// Shows if any bets are currently available for betting in this market
        /// </summary>
        [Description("Shows if any bets are currently available for betting in this market")]
        [DataMember(Name = "AnyBetsAvailable", Order = 15)]
        public bool? AnyBetsAvailable { get; set; }

        /// <summary>
        /// A list of the possible betting outcomes from each sportsbook in this market
        /// </summary>
        [Description("A list of the possible betting outcomes from each sportsbook in this market")]
        [DataMember(Name = "BettingOutcomes", Order = 20016)]
        public BettingOutcome[] BettingOutcomes { get; set; }

        /// <summary>
        /// The single set of consensus outcomes of this market
        /// </summary>
        [Description("The single set of consensus outcomes of this market")]
        [DataMember(Name = "ConsensusOutcomes", Order = 20017)]
        public ConsensusOutcome[] ConsensusOutcomes { get; set; }

    }
}

