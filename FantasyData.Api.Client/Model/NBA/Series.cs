using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
{
    [DataContract(Namespace="", Name="Series")]
    [Serializable]
    public partial class Series
    {
        /// <summary>
        /// Total number of wins by the home team in the series
        /// </summary>
        [Description("Total number of wins by the home team in the series")]
        [DataMember(Name = "HomeTeamWins", Order = 1)]
        public int HomeTeamWins { get; set; }

        /// <summary>
        /// Total wins in the series by the away team
        /// </summary>
        [Description("Total wins in the series by the away team")]
        [DataMember(Name = "AwayTeamWins", Order = 2)]
        public int AwayTeamWins { get; set; }

        /// <summary>
        /// The game number in the series
        /// </summary>
        [Description("The game number in the series")]
        [DataMember(Name = "GameNumber", Order = 3)]
        public int GameNumber { get; set; }

        /// <summary>
        /// The maximum number of games that can be played in a series
        /// </summary>
        [Description("The maximum number of games that can be played in a series")]
        [DataMember(Name = "MaxLength", Order = 4)]
        public int MaxLength { get; set; }

    }
}

