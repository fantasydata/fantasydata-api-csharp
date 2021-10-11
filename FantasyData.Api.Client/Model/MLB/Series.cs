using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Series")]
    [Serializable]
    public partial class Series
    {
        /// <summary>
        /// Number of Wins by the Home Team 
        /// </summary>
        [Description("Number of Wins by the Home Team ")]
        [DataMember(Name = "HomeTeamWins", Order = 1)]
        public int HomeTeamWins { get; set; }

        /// <summary>
        /// Number of Wins by the Away Team
        /// </summary>
        [Description("Number of Wins by the Away Team")]
        [DataMember(Name = "AwayTeamWins", Order = 2)]
        public int AwayTeamWins { get; set; }

        /// <summary>
        /// Game Number in Series
        /// </summary>
        [Description("Game Number in Series")]
        [DataMember(Name = "GameNumber", Order = 3)]
        public int GameNumber { get; set; }

        /// <summary>
        /// Maximum Number of Games in Series
        /// </summary>
        [Description("Maximum Number of Games in Series")]
        [DataMember(Name = "MaxLength", Order = 4)]
        public int MaxLength { get; set; }

    }
}

