using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
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
        /// The sportsbook offering this outcome for betting
        /// </summary>
        [Description("The sportsbook offering this outcome for betting")]
        [DataMember(Name = "SportsBook", Order = 10003)]
        public Sportsbook SportsBook { get; set; }

        /// <summary>
        /// The BettingOutcomeTypeID of this outcome
        /// </summary>
        [Description("The BettingOutcomeTypeID of this outcome")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// Name of Betting Outcome Type (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("Name of Betting Outcome Type (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The american odds payout 
        /// </summary>
        [Description("The american odds payout ")]
        [DataMember(Name = "PayoutAmerican", Order = 6)]
        public int? PayoutAmerican { get; set; }

        /// <summary>
        /// The decimal odds payout
        /// </summary>
        [Description("The decimal odds payout")]
        [DataMember(Name = "PayoutDecimal", Order = 7)]
        public decimal? PayoutDecimal { get; set; }

        /// <summary>
        /// The number associated with the outcome (spread, total, etc)
        /// </summary>
        [Description("The number associated with the outcome (spread, total, etc)")]
        [DataMember(Name = "Value", Order = 8)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The name of the participant (typically team or player) associated with the outcome.  NOTE: This is provided by the sportsbook. In the case of Player odds; we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.
        /// </summary>
        [Description("The name of the participant (typically team or player) associated with the outcome.  NOTE: This is provided by the sportsbook. In the case of Player odds; we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.")]
        [DataMember(Name = "Participant", Order = 9)]
        public string Participant { get; set; }

        /// <summary>
        /// Denotes whether or not the betting outcome is currently available
        /// </summary>
        [Description("Denotes whether or not the betting outcome is currently available")]
        [DataMember(Name = "IsAvailable", Order = 10)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Denotes whether or not the betting outcome is an alternate line
        /// </summary>
        [Description("Denotes whether or not the betting outcome is an alternate line")]
        [DataMember(Name = "IsAlternate", Order = 11)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The created date of the outcome
        /// </summary>
        [Description("The created date of the outcome")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The last updated timestamp of this outcome (US Eastern Time)
        /// </summary>
        [Description("The last updated timestamp of this outcome (US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The timestamp of when this outcome was unlisted (no longer available for bets)
        /// </summary>
        [Description("The timestamp of when this outcome was unlisted (no longer available for bets)")]
        [DataMember(Name = "Unlisted", Order = 14)]
        public DateTime? Unlisted { get; set; }

        /// <summary>
        /// The unique ID of the team associated with this betting outcome
        /// </summary>
        [Description("The unique ID of the team associated with this betting outcome")]
        [DataMember(Name = "TeamID", Order = 15)]
        public int? TeamID { get; set; }

        /// <summary>
        /// The unique ID of the player as assigned by SportsDataIO tied this outcome (if applicable). Note: this ID remains with the player their entire collegiate career
        /// </summary>
        [Description("The unique ID of the player as assigned by SportsDataIO tied this outcome (if applicable). Note: this ID remains with the player their entire collegiate career")]
        [DataMember(Name = "PlayerID", Order = 16)]
        public int? PlayerID { get; set; }

        /// <summary>
        /// A globally unique ID for the team tied this outcome. Note: This value is guaranteed to be unique across all sports/leagues
        /// </summary>
        [Description("A globally unique ID for the team tied this outcome. Note: This value is guaranteed to be unique across all sports/leagues")]
        [DataMember(Name = "GlobalTeamID", Order = 17)]
        public int? GlobalTeamID { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 18)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// Denotes whether the betting outcome is a live line (i.e. the outcome was created after the start of the game)
        /// </summary>
        [Description("Denotes whether the betting outcome is a live line (i.e. the outcome was created after the start of the game)")]
        [DataMember(Name = "IsInPlay", Order = 19)]
        public bool? IsInPlay { get; set; }

        /// <summary>
        /// The market ID of a given sportsbook when available for deep links
        /// </summary>
        [Description("The market ID of a given sportsbook when available for deep links")]
        [DataMember(Name = "SportsbookMarketID", Order = 20)]
        public string SportsbookMarketID { get; set; }

        /// <summary>
        /// The outcome ID of a given sportsbook when available for deep links
        /// </summary>
        [Description("The outcome ID of a given sportsbook when available for deep links")]
        [DataMember(Name = "SportsbookOutcomeID", Order = 21)]
        public string SportsbookOutcomeID { get; set; }

    }
}

