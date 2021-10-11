using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="BettingOutcomeResult")]
    [Serializable]
    public partial class BettingOutcomeResult
    {
        /// <summary>
        /// The unique identifier of the outcome
        /// </summary>
        [Description("The unique identifier of the outcome")]
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
        /// The BettingOutcomeType of this outcome
        /// </summary>
        [Description("The BettingOutcomeType of this outcome")]
        [DataMember(Name = "BettingOutcomeType", Order = 5)]
        public string BettingOutcomeType { get; set; }

        /// <summary>
        /// The value that was bet in this outcome (if applicable)
        /// </summary>
        [Description("The value that was bet in this outcome (if applicable)")]
        [DataMember(Name = "BetValue", Order = 6)]
        public decimal? BetValue { get; set; }

        /// <summary>
        /// The value that actually occurred in game (if applicable)
        /// </summary>
        [Description("The value that actually occurred in game (if applicable)")]
        [DataMember(Name = "ActualValue", Order = 7)]
        public decimal? ActualValue { get; set; }

    }
}

