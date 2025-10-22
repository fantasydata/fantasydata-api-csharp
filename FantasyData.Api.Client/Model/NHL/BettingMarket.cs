using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The ID associated with the name of the market type within a market
        /// </summary>
        [Description("The ID associated with the name of the market type within a market")]
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
        /// The name of the bet type within a market (e.g. Total Points, Moneyline, Puck Line, etc.)
        /// </summary>
        [Description("The name of the bet type within a market (e.g. Total Points, Moneyline, Puck Line, etc.)")]
        [DataMember(Name = "BettingBetType", Order = 6)]
        public string BettingBetType { get; set; }

        /// <summary>
        /// The ID associated with the betting period type which we can result
        /// </summary>
        [Description("The ID associated with the betting period type which we can result")]
        [DataMember(Name = "BettingPeriodTypeID", Order = 7)]
        public int? BettingPeriodTypeID { get; set; }

        /// <summary>
        /// The name of the period type of a market (e.g. Full Game; 1st Period; Overtime; Regular Season)
        /// </summary>
        [Description("The name of the period type of a market (e.g. Full Game; 1st Period; Overtime; Regular Season)")]
        [DataMember(Name = "BettingPeriodType", Order = 8)]
        public string BettingPeriodType { get; set; }

        /// <summary>
        /// The generic name of this market
        /// </summary>
        [Description("The generic name of this market")]
        [DataMember(Name = "Name", Order = 9)]
        public string Name { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamID", Order = 10)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the team tied to this market result (if applicable)
        /// </summary>
        [Description("The abbreviation [Key] of the team tied to this market result (if applicable)")]
        [DataMember(Name = "TeamKey", Order = 11)]
        public string TeamKey { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID will stay with the player throughout their entire career")]
        [DataMember(Name = "PlayerID", Order = 12)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The name of the player tied to this market (if applicable)
        /// </summary>
        [Description("The name of the player tied to this market (if applicable)")]
        [DataMember(Name = "PlayerName", Order = 13)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The date and time when this betting market was created in US Eastern Time.
        /// </summary>
        [Description("The date and time when this betting market was created in US Eastern Time.")]
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
        /// A field that returns "True" if there are any available bets to make within the market in question. If there are no bets available to make, the field returns "False"
        /// </summary>
        [Description("A field that returns \"True\" if there are any available bets to make within the market in question. If there are no bets available to make, the field returns \"False\"")]
        [DataMember(Name = "AnyBetsAvailable", Order = 17)]
        public bool? AnyBetsAvailable { get; set; }

        /// <summary>
        /// The list of betting outcomes from each sportsbook in this market
        /// </summary>
        [Description("The list of betting outcomes from each sportsbook in this market")]
        [DataMember(Name = "BettingOutcomes", Order = 20018)]
        public BettingOutcome[] BettingOutcomes { get; set; }

        /// <summary>
        /// The single set of consensus outcomes of this market
        /// </summary>
        [Description("The single set of consensus outcomes of this market")]
        [DataMember(Name = "ConsensusOutcomes", Order = 20019)]
        public ConsensusOutcome[] ConsensusOutcomes { get; set; }

        /// <summary>
        /// Indicates if the BettingOutcomes have been moved to the archives
        /// </summary>
        [Description("Indicates if the BettingOutcomes have been moved to the archives")]
        [DataMember(Name = "IsArchived", Order = 20)]
        public bool IsArchived { get; set; }

        /// <summary>
        /// If IsArchived is true, this returns the URL that can be used to retrieve the archived BettingOutcomes. An API Key and Sportsbook Grouping will be required to retrieve this information. If IsArchived is false, this returns an emtpy string
        /// </summary>
        [Description("If IsArchived is true, this returns the URL that can be used to retrieve the archived BettingOutcomes. An API Key and Sportsbook Grouping will be required to retrieve this information. If IsArchived is false, this returns an emtpy string")]
        [DataMember(Name = "ArchiveLocation", Order = 21)]
        public string ArchiveLocation { get; set; }

    }
}

