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
        /// Number of wins by the home team on in the series. Note: this is for postseason series only.
        /// </summary>
        [Description("Number of wins by the home team on in the series. Note: this is for postseason series only.")]
        [DataMember(Name = "HomeTeamWins", Order = 1)]
        public int HomeTeamWins { get; set; }

        /// <summary>
        /// Number of wins by the away team in the series. Note: This is for postseason series only.
        /// </summary>
        [Description("Number of wins by the away team in the series. Note: This is for postseason series only.")]
        [DataMember(Name = "AwayTeamWins", Order = 2)]
        public int AwayTeamWins { get; set; }

        /// <summary>
        /// Game number in series. Note: this applies to postseason series only.
        /// </summary>
        [Description("Game number in series. Note: this applies to postseason series only.")]
        [DataMember(Name = "GameNumber", Order = 3)]
        public int GameNumber { get; set; }

        /// <summary>
        /// Maximum number of games in the series. Note: this is for postseason series only.
        /// </summary>
        [Description("Maximum number of games in the series. Note: this is for postseason series only.")]
        [DataMember(Name = "MaxLength", Order = 4)]
        public int MaxLength { get; set; }

    }
}

