using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="ConsensusOutcome")]
    [Serializable]
    public partial class ConsensusOutcome
    {
        /// <summary>
        /// The total number of sportsbooks odds that went into creating this consensus outcome
        /// </summary>
        [Description("The total number of sportsbooks odds that went into creating this consensus outcome")]
        [DataMember(Name = "NumberOfSportsbooks", Order = 1)]
        public int NumberOfSportsbooks { get; set; }

        /// <summary>
        /// The unique ID associated with this specific outcome
        /// </summary>
        [Description("The unique ID associated with this specific outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 2)]
        public int? BettingOutcomeID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 3)]
        public int? BettingMarketID { get; set; }

        /// <summary>
        /// The sportsbook offering this outcome for betting
        /// </summary>
        [Description("The sportsbook offering this outcome for betting")]
        [DataMember(Name = "SportsBook", Order = 10004)]
        public Sportsbook SportsBook { get; set; }

        /// <summary>
        /// The ID of this specific outcome type
        /// </summary>
        [Description("The ID of this specific outcome type")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 5)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of betting outcome type
        /// </summary>
        [Description("The name of betting outcome type")]
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
        /// Indicates if this outcome is available for betting as of last update
        /// </summary>
        [Description("Indicates if this outcome is available for betting as of last update")]
        [DataMember(Name = "IsAvailable", Order = 11)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Indicates if this is an alternate value or the core value
        /// </summary>
        [Description("Indicates if this is an alternate value or the core value")]
        [DataMember(Name = "IsAlternate", Order = 12)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The timestamp of when this betting outcome was created
        /// </summary>
        [Description("The timestamp of when this betting outcome was created")]
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
        /// The unique ID of the golfer tied to this outcome
        /// </summary>
        [Description("The unique ID of the golfer tied to this outcome")]
        [DataMember(Name = "PlayerID", Order = 16)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 17)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// A key to identify outcomes which are related and part of the same offering at a sportsbook (for instance, with SixShooter markets, this key would identify all the options for a particular group of golfers)
        /// </summary>
        [Description("A key to identify outcomes which are related and part of the same offering at a sportsbook (for instance, with SixShooter markets, this key would identify all the options for a particular group of golfers)")]
        [DataMember(Name = "GroupKey", Order = 18)]
        public int? GroupKey { get; set; }

        /// <summary>
        /// Indicates if this outcome is considered in-play/live (i.e. was created after the tournament start date)
        /// </summary>
        [Description("Indicates if this outcome is considered in-play/live (i.e. was created after the tournament start date)")]
        [DataMember(Name = "IsInPlayTournamentOdd", Order = 19)]
        public bool? IsInPlayTournamentOdd { get; set; }

        /// <summary>
        /// The market ID of the given sportsbook when available for deep links
        /// </summary>
        [Description("The market ID of the given sportsbook when available for deep links")]
        [DataMember(Name = "SportsbookMarketID", Order = 20)]
        public string SportsbookMarketID { get; set; }

        /// <summary>
        /// The outcome ID of the given sportsbook when available for deep links
        /// </summary>
        [Description("The outcome ID of the given sportsbook when available for deep links")]
        [DataMember(Name = "SportsbookOutcomeID", Order = 21)]
        public string SportsbookOutcomeID { get; set; }

    }
}

