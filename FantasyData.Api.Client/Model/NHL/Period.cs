using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="Period")]
    [Serializable]
    public partial class Period
    {
        /// <summary>
        /// Unique identifier for each period.
        /// </summary>
        [Description("Unique identifier for each period.")]
        [DataMember(Name = "PeriodID", Order = 1)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The unique ID for this game.
        /// </summary>
        [Description("The unique ID for this game.")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The Name of the Quarter (possible values: 1, 2, 3, OT, SO)
        /// </summary>
        [Description("The Name of the Quarter (possible values: 1, 2, 3, OT, SO)")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The total goals scored by the away team in this period.
        /// </summary>
        [Description("The total goals scored by the away team in this period.")]
        [DataMember(Name = "AwayScore", Order = 4)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// The total goals scored by the home team in this period.
        /// </summary>
        [Description("The total goals scored by the home team in this period.")]
        [DataMember(Name = "HomeScore", Order = 5)]
        public int? HomeScore { get; set; }

        /// <summary>
        /// The details of the scoring plays that occurred during this period
        /// </summary>
        [Description("The details of the scoring plays that occurred during this period")]
        [DataMember(Name = "ScoringPlays", Order = 20006)]
        public ScoringPlay[] ScoringPlays { get; set; }

        /// <summary>
        /// The details of the penalties that occurred during this period
        /// </summary>
        [Description("The details of the penalties that occurred during this period")]
        [DataMember(Name = "Penalties", Order = 20007)]
        public Penalty[] Penalties { get; set; }

    }
}

