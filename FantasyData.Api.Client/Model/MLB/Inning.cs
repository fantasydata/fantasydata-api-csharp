using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="Inning")]
    [Serializable]
    public partial class Inning
    {
        /// <summary>
        /// The unique ID of this specific inning
        /// </summary>
        [Description("The unique ID of this specific inning")]
        [DataMember(Name = "InningID", Order = 1)]
        public int InningID { get; set; }

        /// <summary>
        /// The unique ID of the game tied to this Inning
        /// </summary>
        [Description("The unique ID of the game tied to this Inning")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The current inning number of the game
        /// </summary>
        [Description("The current inning number of the game")]
        [DataMember(Name = "InningNumber", Order = 3)]
        public int InningNumber { get; set; }

        /// <summary>
        /// Number of runs scored by the away team in the specific inning
        /// </summary>
        [Description("Number of runs scored by the away team in the specific inning")]
        [DataMember(Name = "AwayTeamRuns", Order = 4)]
        public int? AwayTeamRuns { get; set; }

        /// <summary>
        /// Number of runs scored by the home team in the specific inning
        /// </summary>
        [Description("Number of runs scored by the home team in the specific inning")]
        [DataMember(Name = "HomeTeamRuns", Order = 5)]
        public int? HomeTeamRuns { get; set; }

    }
}

