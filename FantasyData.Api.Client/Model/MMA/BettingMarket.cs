using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
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
        /// The id of the parent Betting Event
        /// </summary>
        [Description("The id of the parent Betting Event")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// The BettingMarketTypeId for this market
        /// </summary>
        [Description("The BettingMarketTypeId for this market")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int BettingMarketTypeID { get; set; }

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
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// The BettingBetType of this market
        /// </summary>
        [Description("The BettingBetType of this market")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeId of this market
        /// </summary>
        [Description("The BettingPeriodTypeId of this market")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int BettingPeriodTypeID { get; set; }

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
        /// The Fighter Id of the the Fighter tied to this market (if applicable)
        /// </summary>
        [Description("The Fighter Id of the the Fighter tied to this market (if applicable)")]
        [DataMember(Name = "FIghterId", Order = 10)]
        public int? FIghterId { get; set; }

        /// <summary>
        /// The name of the fighter tied to this market (where applicable)
        /// </summary>
        [Description("The name of the fighter tied to this market (where applicable)")]
        [DataMember(Name = "FighterName", Order = 11)]
        public string FighterName { get; set; }

        /// <summary>
        /// The created date of this market
        /// </summary>
        [Description("The created date of this market")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The updated date of this market
        /// </summary>
        [Description("The updated date of this market")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The sportsbooks which have had odds in this market
        /// </summary>
        [Description("The sportsbooks which have had odds in this market")]
        [DataMember(Name = "AvailableSportsbooks", Order = 20014)]
        public Sportsbook[] AvailableSportsbooks { get; set; }

        /// <summary>
        /// Shows if any bets are currently available for betting in this market
        /// </summary>
        [Description("Shows if any bets are currently available for betting in this market")]
        [DataMember(Name = "AnyBetsAvailable", Order = 15)]
        public bool AnyBetsAvailable { get; set; }

        /// <summary>
        /// The list of betting outcomes from each sportsbook in this market
        /// </summary>
        [Description("The list of betting outcomes from each sportsbook in this market")]
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

