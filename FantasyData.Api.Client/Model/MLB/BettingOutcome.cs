using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="BettingOutcome")]
    [Serializable]
    public partial class BettingOutcome
    {
        /// <summary>
        /// The unique ID associated with the betting outcome
        /// </summary>
        [Description("The unique ID associated with the betting outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 1)]
        public int? BettingOutcomeID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int? BettingMarketID { get; set; }

        /// <summary>
        /// Name of sportsbook
        /// </summary>
        [Description("Name of sportsbook")]
        [DataMember(Name = "SportsBook", Order = 10003)]
        public Sportsbook SportsBook { get; set; }

        /// <summary>
        /// The unique ID associated with this BettingOutcomeType
        /// </summary>
        [Description("The unique ID associated with this BettingOutcomeType")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of BettingOutcomeType (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of BettingOutcomeType (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The payout of the bet, shown in American odds format
        /// </summary>
        [Description("The payout of the bet, shown in American odds format")]
        [DataMember(Name = "PayoutAmerican", Order = 6)]
        public int? PayoutAmerican { get; set; }

        /// <summary>
        /// The payout of the bet, shown in decimal odds format
        /// </summary>
        [Description("The payout of the bet, shown in decimal odds format")]
        [DataMember(Name = "PayoutDecimal", Order = 7)]
        public decimal? PayoutDecimal { get; set; }

        /// <summary>
        /// The number associated with the outcome of a market (e.g. the run line, game total, etc.)
        /// </summary>
        [Description("The number associated with the outcome of a market (e.g. the run line, game total, etc.)")]
        [DataMember(Name = "Value", Order = 8)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The name of the participant (typically team or player) associated with the outcome. NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.
        /// </summary>
        [Description("The name of the participant (typically team or player) associated with the outcome. NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.")]
        [DataMember(Name = "Participant", Order = 9)]
        public string Participant { get; set; }

        /// <summary>
        /// Indicates whether a BettingOutcome is available for betting or not (true/false)
        /// </summary>
        [Description("Indicates whether a BettingOutcome is available for betting or not (true/false)")]
        [DataMember(Name = "IsAvailable", Order = 10)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Indicates whether this is an alternate value or the core value (true/false)
        /// </summary>
        [Description("Indicates whether this is an alternate value or the core value (true/false)")]
        [DataMember(Name = "IsAlternate", Order = 11)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The date and time when this betting outcome was created in US Eastern Time.
        /// </summary>
        [Description("The date and time when this betting outcome was created in US Eastern Time.")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date and time of the last update made to this betting outcome (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the last update made to this betting outcome (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first made unavailable to be bet on any further (In US Eastern Time)
        /// </summary>
        [Description("The timestamp of when these odds were first made unavailable to be bet on any further (In US Eastern Time)")]
        [DataMember(Name = "Unlisted", Order = 14)]
        public DateTime? Unlisted { get; set; }

        /// <summary>
        /// The team's unique TeamID as assigned by SportsDataIO tied this outcome (if applicable)
        /// </summary>
        [Description("The team's unique TeamID as assigned by SportsDataIO tied this outcome (if applicable)")]
        [DataMember(Name = "TeamID", Order = 15)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The player's unique PlayerID as assigned by SportsDataIO tied to this outcome (if applicable) Note: this ID will stay with the player throughout their MLB career
        /// </summary>
        [Description("The player's unique PlayerID as assigned by SportsDataIO tied to this outcome (if applicable) Note: this ID will stay with the player throughout their MLB career")]
        [DataMember(Name = "PlayerID", Order = 16)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// A globally unique ID for this team tied to this outcome. This value is guaranteed to be unique across all sports/leagues (where applicable)
        /// </summary>
        [Description("A globally unique ID for this team tied to this outcome. This value is guaranteed to be unique across all sports/leagues (where applicable)")]
        [DataMember(Name = "GlobalTeamID", Order = 17)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 18)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// Was this outcome created after the start time of the game (only applies when the betting event is of type game; true/false)
        /// </summary>
        [Description("Was this outcome created after the start time of the game (only applies when the betting event is of type game; true/false)")]
        [DataMember(Name = "IsInPlay", Order = 19)]
        public bool? IsInPlay { get; set; }

        /// <summary>
        /// The market ID on the given sportsbook for deeplinking (when available)
        /// </summary>
        [Description("The market ID on the given sportsbook for deeplinking (when available)")]
        [DataMember(Name = "SportsbookMarketID", Order = 20)]
        public string SportsbookMarketID { get; set; }

        /// <summary>
        /// The outcome ID on the given sportsbook for deeplinking (when available)
        /// </summary>
        [Description("The outcome ID on the given sportsbook for deeplinking (when available)")]
        [DataMember(Name = "SportsbookOutcomeID", Order = 21)]
        public string SportsbookOutcomeID { get; set; }

    }
}

