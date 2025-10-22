using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
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
        public int? GameOddId { get; set; }

        /// <summary>
        /// The unique ID of this GameOddResultType
        /// </summary>
        [Description("The unique ID of this GameOddResultType")]
        [DataMember(Name = "GameOddResultTypeId", Order = 2)]
        public int? GameOddResultTypeId { get; set; }

        /// <summary>
        /// The result/outcome of a bet (e.g. Won; Lost; Push; Not Resulted; Incomplete)
        /// </summary>
        [Description("The result/outcome of a bet (e.g. Won; Lost; Push; Not Resulted; Incomplete)")]
        [DataMember(Name = "GameOddResultType", Order = 3)]
        public string GameOddResultType { get; set; }

        /// <summary>
        /// The market type of the odd (ex: live; pregame; 1st inning; etc)
        /// </summary>
        [Description("The market type of the odd (ex: live; pregame; 1st inning; etc)")]
        [DataMember(Name = "OddType", Order = 4)]
        public string OddType { get; set; }

        /// <summary>
        /// The GameOddResultType of an outcome in the form of a string
        /// </summary>
        [Description("The GameOddResultType of an outcome in the form of a string")]
        [DataMember(Name = "GameOddType", Order = 5)]
        public string GameOddType { get; set; }

        /// <summary>
        /// The offered betting line from a sportsbook for a game (i.e. If a team won a game by 2 and the run line was -1.5, the actual value would be 2 and the bet value would be -1.5)
        /// </summary>
        [Description("The offered betting line from a sportsbook for a game (i.e. If a team won a game by 2 and the run line was -1.5, the actual value would be 2 and the bet value would be -1.5)")]
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

