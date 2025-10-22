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
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 1)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting event
        /// </summary>
        [Description("The unique ID associated with the betting event")]
        [DataMember(Name = "BettingEventID", Order = 2)]
        public int BettingEventID { get; set; }

        /// <summary>
        /// ID that distinguishes the different types of Market Types
        /// </summary>
        [Description("ID that distinguishes the different types of Market Types")]
        [DataMember(Name = "BettingMarketTypeID", Order = 3)]
        public int BettingMarketTypeID { get; set; }

        /// <summary>
        /// The name of the Market Type (e.g. Fighter Prop, Fight Prop, etc.)
        /// </summary>
        [Description("The name of the Market Type (e.g. Fighter Prop, Fight Prop, etc.)")]
        [DataMember(Name = "BettingMarketType", Order = 4)]
        public string BettingMarketType { get; set; }

        /// <summary>
        /// The ID associated with the name of the bet type within a market
        /// </summary>
        [Description("The ID associated with the name of the bet type within a market")]
        [DataMember(Name = "BettingBetTypeID", Order = 5)]
        public int BettingBetTypeID { get; set; }

        /// <summary>
        /// The name of the bet type within a market
        /// </summary>
        [Description("The name of the bet type within a market")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The BettingPeriodTypeID of this type of market which we can result
        /// </summary>
        [Description("The BettingPeriodTypeID of this type of market which we can result")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The BettingPeriodType of this market (e.g. Full Fight; 1st Round, etc.)
        /// </summary>
        [Description("The BettingPeriodType of this market (e.g. Full Fight; 1st Round, etc.)")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The name of the betting market
        /// </summary>
        [Description("The name of the betting market")]
        [DataMember(Name = "Name", Order = 9)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the fighter tied to this market (where applicable)
        /// </summary>
        [Description("The unique ID of the fighter tied to this market (where applicable)")]
        [DataMember(Name = "FIghterId", Order = 10)]
        public int? FIghterId { get; set; }

        /// <summary>
        /// The full name of the fighter tied to this market (where applicable)
        /// </summary>
        [Description("The full name of the fighter tied to this market (where applicable)")]
        [DataMember(Name = "FighterName", Order = 11)]
        public string FighterName { get; set; }

        /// <summary>
        /// The timestamp of when this market was created
        /// </summary>
        [Description("The timestamp of when this market was created")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The updated timestamp of this market (in US Eastern Time)
        /// </summary>
        [Description("The updated timestamp of this market (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The sportsbooks which have had odds in this market
        /// </summary>
        [Description("The sportsbooks which have had odds in this market")]
        [DataMember(Name = "AvailableSportsbooks", Order = 20014)]
        public Sportsbook[] AvailableSportsbooks { get; set; }

        /// <summary>
        /// A field that returns "True" if there are any available bets to make within the market in question. If there are no bets available to make, the field returns "False"
        /// </summary>
        [Description("A field that returns \"True\" if there are any available bets to make within the market in question. If there are no bets available to make, the field returns \"False\"")]
        [DataMember(Name = "AnyBetsAvailable", Order = 15)]
        public bool AnyBetsAvailable { get; set; }

        /// <summary>
        /// The list of betting outcomes from each sportsbook in the market
        /// </summary>
        [Description("The list of betting outcomes from each sportsbook in the market")]
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

