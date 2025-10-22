using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="ConsensusOutcome")]
    [Serializable]
    public partial class ConsensusOutcome
    {
        /// <summary>
        /// The number of sportsbooks odds that went into creating this consensus outcome
        /// </summary>
        [Description("The number of sportsbooks odds that went into creating this consensus outcome")]
        [DataMember(Name = "NumberOfSportsbooks", Order = 1)]
        public int NumberOfSportsbooks { get; set; }

        /// <summary>
        /// The unique ID associated with this specific outcome
        /// </summary>
        [Description("The unique ID associated with this specific outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 2)]
        public int? BettingOutcomeID { get; set; }

        /// <summary>
        /// The unique ID of the betting market
        /// </summary>
        [Description("The unique ID of the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 3)]
        public int? BettingMarketID { get; set; }

        /// <summary>
        /// The sportsbook offering this outcome for betting
        /// </summary>
        [Description("The sportsbook offering this outcome for betting")]
        [DataMember(Name = "SportsBook", Order = 10004)]
        public Sportsbook SportsBook { get; set; }

        /// <summary>
        /// The ID associated with the betting outcome type
        /// </summary>
        [Description("The ID associated with the betting outcome type")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 5)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of the betting outcome within a betting market (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of the betting outcome within a betting market (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 6)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The american odds payout 
        /// </summary>
        [Description("The american odds payout ")]
        [DataMember(Name = "PayoutAmerican", Order = 7)]
        public int? PayoutAmerican { get; set; }

        /// <summary>
        /// The decimal odds payout
        /// </summary>
        [Description("The decimal odds payout")]
        [DataMember(Name = "PayoutDecimal", Order = 8)]
        public decimal? PayoutDecimal { get; set; }

        /// <summary>
        /// The number associated with the outcome of a market (e.g. the spread, game total, etc.)
        /// </summary>
        [Description("The number associated with the outcome of a market (e.g. the spread, game total, etc.)")]
        [DataMember(Name = "Value", Order = 9)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The name of the participant (typically team or player) associated with the outcome.  NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.
        /// </summary>
        [Description("The name of the participant (typically team or player) associated with the outcome.  NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.")]
        [DataMember(Name = "Participant", Order = 10)]
        public string Participant { get; set; }

        /// <summary>
        /// Indicates if this outcome is available for betting as of the last update
        /// </summary>
        [Description("Indicates if this outcome is available for betting as of the last update")]
        [DataMember(Name = "IsAvailable", Order = 11)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Indicates if this is an alternate value or the core value
        /// </summary>
        [Description("Indicates if this is an alternate value or the core value")]
        [DataMember(Name = "IsAlternate", Order = 12)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The created date of the outcome (in US Eastern Time)
        /// </summary>
        [Description("The created date of the outcome (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 13)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when the betting outcome was last updated (US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the betting outcome was last updated (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when the outcome was no longer available for betting
        /// </summary>
        [Description("The timestamp of when the outcome was no longer available for betting")]
        [DataMember(Name = "Unlisted", Order = 15)]
        public DateTime? Unlisted { get; set; }

        /// <summary>
        /// The unique ID of the team associated with betting outcome
        /// </summary>
        [Description("The unique ID of the team associated with betting outcome")]
        [DataMember(Name = "TeamID", Order = 16)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO. Note: this ID stays with the player their entire career")]
        [DataMember(Name = "PlayerID", Order = 17)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// A globally unique ID for this team associated with this outcome (where applicable)
        /// </summary>
        [Description("A globally unique ID for this team associated with this outcome (where applicable)")]
        [DataMember(Name = "GlobalTeamID", Order = 18)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 19)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// Was this outcome created after the start time of the game (only applies when the betting event is of type game)
        /// </summary>
        [Description("Was this outcome created after the start time of the game (only applies when the betting event is of type game)")]
        [DataMember(Name = "IsInPlay", Order = 20)]
        public bool? IsInPlay { get; set; }

    }
}

