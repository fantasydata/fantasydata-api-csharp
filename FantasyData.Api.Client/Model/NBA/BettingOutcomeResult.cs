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

    }
}

