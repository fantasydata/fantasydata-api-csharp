using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="BettingMarket")]
    [Serializable]
    public partial class BettingMarket
    {
        /// <summary>
        /// The unique identifier of this betting market
        /// </summary>
        [Description("The unique identifier of this betting market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique identifier of the event this betting market exists for
        /// </summary>
        [Description("The unique identifier of the event this betting market exists for")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The BettingMarketTypeID of this market
        /// </summary>
        [Description("The BettingMarketTypeID of this market")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int? BettingMarketTypeID { get; set; }

        /// <summary>
        /// The BettingMarketType of this market
        /// </summary>
        [Description("The BettingMarketType of this market")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The BettingBetTypeID of this market
        /// </summary>
        [Description("The BettingBetTypeID of this market")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int? BettingBetTypeID { get; set; }

        /// <summary>
        /// The BettingBetType of this market
        /// </summary>
        [Description("The BettingBetType of this market")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this market
        /// </summary>
        [Description("The BettingPeriodTypeID of this market")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int? BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The BettingPeriodType of this market
        /// </summary>
        [Description("The BettingPeriodType of this market")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The generic name of this market
        /// </summary>
        [Description("The generic name of this market")]
        [DataMember(Name = "Name", Order = 9)]
        public string Name { get; set; }

        /// <summary>
        /// The team id of the team tied to this market (if applicable)
        /// </summary>
        [Description("The team id of the team tied to this market (if applicable)")]
        [DataMember(Name = "TeamID", Order = 10)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The team key of the team tied to this market (if applicable)
        /// </summary>
        [Description("The team key of the team tied to this market (if applicable)")]
        [DataMember(Name = "TeamKey", Order = 11)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The player id of the player tied to this market (if applicable)
        /// </summary>
        [Description("The player id of the player tied to this market (if applicable)")]
        [DataMember(Name = "PlayerID", Order = 12)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The name of the player tied to this market (if applicable)
        /// </summary>
        [Description("The name of the player tied to this market (if applicable)")]
        [DataMember(Name = "PlayerName", Order = 13)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The created date of this market
        /// </summary>
        [Description("The created date of this market")]
        [DataMember(Name = "Created", Order = 14)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated date of this market
        /// </summary>
        [Description("The last updated date of this market")]
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

