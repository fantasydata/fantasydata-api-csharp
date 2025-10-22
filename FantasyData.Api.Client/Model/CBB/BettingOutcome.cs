using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="BettingOutcome")]
    [Serializable]
    public partial class BettingOutcome
    {
        /// <summary>
        /// The unique ID associated with this specific outcome
        /// </summary>
        [Description("The unique ID associated with this specific outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 1)]
        public int? BettingOutcomeID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int? BettingMarketID { get; set; }

        /// <summary>
        /// The name of the sportsbook that is offering this outcome for betting
        /// </summary>
        [Description("The name of the sportsbook that is offering this outcome for betting")]
        [DataMember(Name = "SportsBook", Order = 10003)]
        public Sportsbook SportsBook { get; set; }

        /// <summary>
        /// The BettingOutcomeTypeID of this outcome
        /// </summary>
        [Description("The BettingOutcomeTypeID of this outcome")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of betting outcome type (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of betting outcome type (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The payout of the bet, shown in American odds format
        /// </summary>
        [Description("The payout of the bet, shown in American odds format")]
        [DataMember(Name = "PayoutAmerican", Order = 6)]
        public int? PayoutAmerican { get; set; }

        /// <summary>
        /// The payout of the bet, shown in Decimal odds format
        /// </summary>
        [Description("The payout of the bet, shown in Decimal odds format")]
        [DataMember(Name = "PayoutDecimal", Order = 7)]
        public decimal? PayoutDecimal { get; set; }

        /// <summary>
        /// The number associated with the outcome of a market (e.g. the spread, game total, etc.)
        /// </summary>
        [Description("The number associated with the outcome of a market (e.g. the spread, game total, etc.)")]
        [DataMember(Name = "Value", Order = 8)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The name of the participant (typically a team or player) associated with a given outcome. Note: This is provided by the sportsbook. In the case of Player odds; we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks
        /// </summary>
        [Description("The name of the participant (typically a team or player) associated with a given outcome. Note: This is provided by the sportsbook. In the case of Player odds; we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks")]
        [DataMember(Name = "Participant", Order = 9)]
        public string Participant { get; set; }

        /// <summary>
        /// Indicates whether a BettingOutcome is available for betting or not
        /// </summary>
        [Description("Indicates whether a BettingOutcome is available for betting or not")]
        [DataMember(Name = "IsAvailable", Order = 10)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Is this an alternate value or the core value
        /// </summary>
        [Description("Is this an alternate value or the core value")]
        [DataMember(Name = "IsAlternate", Order = 11)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The date and time when this betting outcome was created (in US Eastern Time)
        /// </summary>
        [Description("The date and time when this betting outcome was created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of the last time this betting outcome was updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of the last time this betting outcome was updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first made unavailable to be bet on any further
        /// </summary>
        [Description("The timestamp of when these odds were first made unavailable to be bet on any further")]
        [DataMember(Name = "Unlisted", Order = 14)]
        public DateTime? Unlisted { get; set; }

        /// <summary>
        /// The unique ID of the team (if applicable)
        /// </summary>
        [Description("The unique ID of the team (if applicable)")]
        [DataMember(Name = "TeamID", Order = 15)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO (if applicable). Note: this ID will stay with the player throughout their collegiate career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO (if applicable). Note: this ID will stay with the player throughout their collegiate career")]
        [DataMember(Name = "PlayerID", Order = 16)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues (where applicable)
        /// </summary>
        [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues (where applicable)")]
        [DataMember(Name = "GlobalTeamID", Order = 17)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 18)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// Was this outcome created after the start time of the game (only applies when the betting event is of type game)
        /// </summary>
        [Description("Was this outcome created after the start time of the game (only applies when the betting event is of type game)")]
        [DataMember(Name = "IsInPlay", Order = 19)]
        public bool? IsInPlay { get; set; }

        /// <summary>
        /// The market ID from the given sportsbook when available
        /// </summary>
        [Description("The market ID from the given sportsbook when available")]
        [DataMember(Name = "SportsbookMarketID", Order = 20)]
        public string SportsbookMarketID { get; set; }

        /// <summary>
        /// The outcome ID from the given sportsbook when available
        /// </summary>
        [Description("The outcome ID from the given sportsbook when available")]
        [DataMember(Name = "SportsbookOutcomeID", Order = 21)]
        public string SportsbookOutcomeID { get; set; }

    }
}

