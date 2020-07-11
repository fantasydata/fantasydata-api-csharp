using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.MLB
{
    [DataContract(Namespace="", Name="Inning")]
    [Serializable]
    public partial class Inning
    {
        /// <summary>
        /// The unique ID for the inning
        /// </summary>
        [Description("The unique ID for the inning")]
        [DataMember(Name = "InningID", Order = 1)]
        public int InningID { get; set; }

        /// <summary>
        /// The unique ID for the game
        /// </summary>
        [Description("The unique ID for the game")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The inning number in the game
        /// </summary>
        [Description("The inning number in the game")]
        [DataMember(Name = "InningNumber", Order = 3)]
        public int InningNumber { get; set; }

        /// <summary>
        /// The number of away team runs in the inning
        /// </summary>
        [Description("The number of away team runs in the inning")]
        [DataMember(Name = "AwayTeamRuns", Order = 4)]
        public int? AwayTeamRuns { get; set; }

        /// <summary>
        /// The number of home team runs in the inning
        /// </summary>
        [Description("The number of home team runs in the inning")]
        [DataMember(Name = "HomeTeamRuns", Order = 5)]
        public int? HomeTeamRuns { get; set; }

    }
}

