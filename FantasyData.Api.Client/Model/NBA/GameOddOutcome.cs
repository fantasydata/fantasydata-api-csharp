using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="GameOddOutcome")]
    [Serializable]
    public partial class GameOddOutcome
    {
        /// <summary>
        /// Unique ID of this odd
        /// </summary>
        [Description("Unique ID of this odd")]
        [DataMember(Name = "GameOddId", Order = 1)]
        public int GameOddId { get; set; }

        /// <summary>
        /// The GameOddResultType of this outcome as an integer
        /// </summary>
        [Description("The GameOddResultType of this outcome as an integer")]
        [DataMember(Name = "GameOddResultTypeId", Order = 2)]
        public int? GameOddResultTypeId { get; set; }

        /// <summary>
        /// The string identifier of the GameOddResultType of this outcome (e.g. Won, Lost, Push, Not Resulted, Incomplete)
        /// </summary>
        [Description("The string identifier of the GameOddResultType of this outcome (e.g. Won, Lost, Push, Not Resulted, Incomplete)")]
        [DataMember(Name = "GameOddResultType", Order = 3)]
        public string GameOddResultType { get; set; }

        /// <summary>
        /// The market type of the odd (ex: live, pregame, 1st-5th Inning, etc)
        /// </summary>
        [Description("The market type of the odd (ex: live, pregame, 1st-5th Inning, etc)")]
        [DataMember(Name = "OddType", Order = 4)]
        public string OddType { get; set; }

        /// <summary>
        /// The GameOddOutcomeType of this outcome as a string
        /// </summary>
        [Description("The GameOddOutcomeType of this outcome as a string")]
        [DataMember(Name = "GameOddType", Order = 5)]
        public string GameOddType { get; set; }

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

