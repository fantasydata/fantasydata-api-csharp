using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
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
        /// The ID associated with the betting result type of this outcome
        /// </summary>
        [Description("The ID associated with the betting result type of this outcome")]
        [DataMember(Name = "BettingResultTypeID", Order = 2)]
        public int? BettingResultTypeID { get; set; }

        /// <summary>
        /// The BettingResultType of this outcome
        /// </summary>
        [Description("The BettingResultType of this outcome")]
        [DataMember(Name = "BettingResultType", Order = 3)]
        public string BettingResultType { get; set; }

        /// <summary>
        /// The ID associated with the betting outcome type
        /// </summary>
        [Description("The ID associated with the betting outcome type")]
        [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
        public int? BettingOutcomeTypeID { get; set; }

        /// <summary>
        /// The name of the betting outcome within a betting market (e.g. Home; Away; Under; Over)
        /// </summary>
        [Description("The name of the betting outcome within a betting market (e.g. Home; Away; Under; Over)")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The offered betting line from a sportsbook for a game (i.e. If a team won a game by 2 and the spread was -1.5, the actual value would be 2 and the bet value would be -1.5)
        /// </summary>
        [Description("The offered betting line from a sportsbook for a game (i.e. If a team won a game by 2 and the spread was -1.5, the actual value would be 2 and the bet value would be -1.5)")]
        [DataMember(Name = "BetValue", Order = 6)]
        public decimal? BetValue { get; set; }

        /// <summary>
        /// The value of the actual result that occured in game (i.e. If a team won a game by 2 and the spread was -1.5, the actual value would be 2 and the bet value would be -1.5)
        /// </summary>
        [Description("The value of the actual result that occured in game (i.e. If a team won a game by 2 and the spread was -1.5, the actual value would be 2 and the bet value would be -1.5)")]
        [DataMember(Name = "ActualValue", Order = 7)]
        public decimal? ActualValue { get; set; }

    }
}

