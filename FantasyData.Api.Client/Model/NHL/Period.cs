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
        /// The unique ID associated of this period
        /// </summary>
        [Description("The unique ID associated of this period")]
        [DataMember(Name = "PeriodID", Order = 1)]
        public int PeriodID { get; set; }

        /// <summary>
        /// The unique ID of this game tied to this period
        /// </summary>
        [Description("The unique ID of this game tied to this period")]
        [DataMember(Name = "GameID", Order = 2)]
        public int GameID { get; set; }

        /// <summary>
        /// The name of the period (possible values: 1; 2; 3; SO; OT; OT2; OT3; OT4; etc)
        /// </summary>
        [Description("The name of the period (possible values: 1; 2; 3; SO; OT; OT2; OT3; OT4; etc)")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// Total goals scored by the away team in a given period
        /// </summary>
        [Description("Total goals scored by the away team in a given period")]
        [DataMember(Name = "AwayScore", Order = 4)]
        public int? AwayScore { get; set; }

        /// <summary>
        /// Total goals scored by the home team in the period
        /// </summary>
        [Description("Total goals scored by the home team in the period")]
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

