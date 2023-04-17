using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The unique identifier of this outcome
        /// </summary>
        [Description("The unique identifier of this outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 2)]
        public int? BettingOutcomeID { get; set; }

        /// <summary>
        /// The unique identifier of the market this betting outcome exists for
        /// </summary>
        [Description("The unique identifier of the market this betting outcome exists for")]
        [DataMember(Name = "BettingMarketID", Order = 3)]
        public int? BettingMarketID { get; set; }

        /// <summary>
        /// The sportsbook offering this outcome for betting
        /// </summary>
        [Description("The sportsbook offering this outcome for betting")]
        [DataMember(Name = "SportsBook", Order = 10004)]
        public Sportsbook SportsBook { get; set; }

        /// <summary>
        /// The BettingOutcomeTypeID of this outcome
        /// </summary>
        [Description("The BettingOutcomeTypeID of this outcome")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 5)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The BettingOutcomeType of this outcome
        /// </summary>
        [Description("The BettingOutcomeType of this outcome")]
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
        /// The number associated with the outcome (spread/total/etc)
        /// </summary>
        [Description("The number associated with the outcome (spread/total/etc)")]
        [DataMember(Name = "Value", Order = 9)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The name of the participant (typically team or player) associated with the outcome. NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.
        /// </summary>
        [Description("The name of the participant (typically team or player) associated with the outcome. NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.")]
        [DataMember(Name = "Participant", Order = 10)]
        public string Participant { get; set; }

        /// <summary>
        /// Is this outcome available for betting as of last update
        /// </summary>
        [Description("Is this outcome available for betting as of last update")]
        [DataMember(Name = "IsAvailable", Order = 11)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Is this an alternate value or the core value
        /// </summary>
        [Description("Is this an alternate value or the core value")]
        [DataMember(Name = "IsAlternate", Order = 12)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The created date of the outcome
        /// </summary>
        [Description("The created date of the outcome")]
        [DataMember(Name = "Created", Order = 13)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated date of the outcome
        /// </summary>
        [Description("The last updated date of the outcome")]
        [DataMember(Name = "Updated", Order = 14)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The datetime the outcome was unlisted (no longer available for bets)
        /// </summary>
        [Description("The datetime the outcome was unlisted (no longer available for bets)")]
        [DataMember(Name = "Unlisted", Order = 15)]
        public DateTime? Unlisted { get; set; }

        /// <summary>
        /// The TeamID of the team assocated with this outcome (where applicable)
        /// </summary>
        [Description("The TeamID of the team assocated with this outcome (where applicable)")]
        [DataMember(Name = "TeamID", Order = 16)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The PlayerID of the player assocated with this outcome (where applicable)
        /// </summary>
        [Description("The PlayerID of the player assocated with this outcome (where applicable)")]
        [DataMember(Name = "PlayerID", Order = 17)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The GlobalTeamID of the team assocated with this outcome (where applicable)
        /// </summary>
        [Description("The GlobalTeamID of the team assocated with this outcome (where applicable)")]
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

        /// <summary>
        /// The market ID of the given sportsbook when available for deep links
        /// </summary>
        [Description("The market ID of the given sportsbook when available for deep links")]
        [DataMember(Name = "SportsbookMarketID", Order = 21)]
        public string SportsbookMarketID { get; set; }

        /// <summary>
        /// The outcome ID of the given sportsbook when available for deep links
        /// </summary>
        [Description("The outcome ID of the given sportsbook when available for deep links")]
        [DataMember(Name = "SportsbookOutcomeID", Order = 22)]
        public string SportsbookOutcomeID { get; set; }

    }
}

