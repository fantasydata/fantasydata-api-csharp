using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="BettingOutcomeResult")]
    [Serializable]
    public partial class BettingOutcomeResult
    {
        /// <summary>
        /// The unique ID associated with this specific outcome
        /// </summary>
        [Description("The unique ID associated with this specific outcome")]
        [DataMember(Name = "BettingOutcomeID", Order = 1)]
        public int BettingOutcomeID { get; set; }

        /// <summary>
        /// The BettingResultType of this outcome
        /// </summary>
        [Description("The BettingResultType of this outcome")]
        [DataMember(Name = "BettingResultTypeID", Order = 2)]
        public int? BettingResultTypeID { get; set; }

        /// <summary>
        /// The string identifier of the BettingResultType of this outcome (e.g. Won, Lost, Push, Not Resulted, Incomplete)
        /// </summary>
        [Description("The string identifier of the BettingResultType of this outcome (e.g. Won, Lost, Push, Not Resulted, Incomplete)")]
        [DataMember(Name = "BettingResultType", Order = 3)]
        public string BettingResultType { get; set; }

        /// <summary>
        /// The BettingOutcomeTypeID of this outcome
        /// </summary>
        [Description("The BettingOutcomeTypeID of this outcome")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of outcome type (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of outcome type (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The offered betting line from a sportsbook for a game (i.e. If a team won a game by 5 and the spread was -6.5, the actual value would be 5 and the bet value would be -6.5)
        /// </summary>
        [Description("The offered betting line from a sportsbook for a game (i.e. If a team won a game by 5 and the spread was -6.5, the actual value would be 5 and the bet value would be -6.5)")]
        [DataMember(Name = "BetValue", Order = 6)]
        public decimal? BetValue { get; set; }

        /// <summary>
        /// The value of the actual result that occurred in game (i.e. If a team won a game by 5 and the spread was -6.5, the actual value would be 5 and the bet value would be -6.5)
        /// </summary>
        [Description("The value of the actual result that occurred in game (i.e. If a team won a game by 5 and the spread was -6.5, the actual value would be 5 and the bet value would be -6.5)")]
        [DataMember(Name = "ActualValue", Order = 7)]
        public decimal? ActualValue { get; set; }

    }
}

