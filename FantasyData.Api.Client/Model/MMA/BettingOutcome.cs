using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="BettingOutcome")]
    [Serializable]
    public partial class BettingOutcome
    {
        /// <summary>
        /// The unique ID of this outcome
        /// </summary>
        [Description("The unique ID of this outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 1)]
        public int BettingOutcomeID { get; set; }

        /// <summary>
        /// The unique ID associated with the betting market
        /// </summary>
        [Description("The unique ID associated with the betting market")]
        [DataMember(Name = "BettingMarketID", Order = 2)]
        public int BettingMarketID { get; set; }

        /// <summary>
        /// The sportsbook offering this outcome for betting
        /// </summary>
        [Description("The sportsbook offering this outcome for betting")]
        [DataMember(Name = "Sportsbook", Order = 10003)]
        public Sportsbook Sportsbook { get; set; }

        /// <summary>
        /// The BettingOutcomeTypeID of this outcome
        /// </summary>
        [Description("The BettingOutcomeTypeID of this outcome")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of Betting Outcome Type (e.g. Under; Over; etc.)
        /// </summary>
        [Description("The name of Betting Outcome Type (e.g. Under; Over; etc.)")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The American odds payout
        /// </summary>
        [Description("The American odds payout")]
        [DataMember(Name = "PayoutAmerican", Order = 6)]
        public int PayoutAmerican { get; set; }

        /// <summary>
        /// The decimal odds payout
        /// </summary>
        [Description("The decimal odds payout")]
        [DataMember(Name = "PayoutDecimal", Order = 7)]
        public int PayoutDecimal { get; set; }

        /// <summary>
        /// The number/handicap associated with the outcome (spread/total/etc.,)
        /// </summary>
        [Description("The number/handicap associated with the outcome (spread/total/etc.,)")]
        [DataMember(Name = "Value", Order = 8)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The name of the participant (typically team or player) associated with the outcome. NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.
        /// </summary>
        [Description("The name of the participant (typically team or player) associated with the outcome. NOTE: This is provided by the sportsbook. In the case of Player odds, we highly recommend using PlayerID as names of players can be inconsistent between sportsbooks.")]
        [DataMember(Name = "Participant", Order = 9)]
        public string Participant { get; set; }

        /// <summary>
        /// Indicates if this outcome is available for betting as of the last update
        /// </summary>
        [Description("Indicates if this outcome is available for betting as of the last update")]
        [DataMember(Name = "IsAvailable", Order = 10)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Indicates if this is an alternate value or the core value
        /// </summary>
        [Description("Indicates if this is an alternate value or the core value")]
        [DataMember(Name = "IsAlternate", Order = 11)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The timestamp of when the betting outcome was created
        /// </summary>
        [Description("The timestamp of when the betting outcome was created")]
        [DataMember(Name = "Created", Order = 12)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The last updated timestamp of the outcome (in US Eastern Time)
        /// </summary>
        [Description("The last updated timestamp of the outcome (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 13)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The unique ID of the fighter tied to this betting outcome (where applicable)
        /// </summary>
        [Description("The unique ID of the fighter tied to this betting outcome (where applicable)")]
        [DataMember(Name = "FighterId", Order = 14)]
        public int? FighterId { get; set; }

        /// <summary>
        /// The URL for the sportsbook event
        /// </summary>
        [Description("The URL for the sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 15)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// The datetime the outcome was unlisted (no longer available for bets)
        /// </summary>
        [Description("The datetime the outcome was unlisted (no longer available for bets)")]
        [DataMember(Name = "Unlisted", Order = 16)]
        public DateTime? Unlisted { get; set; }

    }
}

