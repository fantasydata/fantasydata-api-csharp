using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="CareerStat")]
    [Serializable]
    public partial class CareerStat
    {
        /// <summary>
        /// The unique ID of this fighter
        /// </summary>
        [Description("The unique ID of this fighter")]
        [DataMember(Name = "FighterId", Order = 1)]
        public int? FighterId { get; set; }

        /// <summary>
        /// The fighter's first name
        /// </summary>
        [Description("The fighter's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The fighter's last name
        /// </summary>
        [Description("The fighter's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// Significal strikes landed per minute over career
        /// </summary>
        [Description("Significal strikes landed per minute over career")]
        [DataMember(Name = "SigStrikesLandedPerMinute", Order = 4)]
        public decimal? SigStrikesLandedPerMinute { get; set; }

        /// <summary>
        /// Significant strikes landed divided by strikes attempted over career
        /// </summary>
        [Description("Significant strikes landed divided by strikes attempted over career")]
        [DataMember(Name = "SigStrikeAccuracy", Order = 5)]
        public decimal? SigStrikeAccuracy { get; set; }

        /// <summary>
        /// Average takedowns landed per 15 minutes
        /// </summary>
        [Description("Average takedowns landed per 15 minutes")]
        [DataMember(Name = "TakedownAverage", Order = 6)]
        public decimal? TakedownAverage { get; set; }

        /// <summary>
        /// Average number of submissions attempted per 15 minutes
        /// </summary>
        [Description("Average number of submissions attempted per 15 minutes")]
        [DataMember(Name = "SubmissionAverage", Order = 7)]
        public decimal? SubmissionAverage { get; set; }

        /// <summary>
        /// Percentage of wins ending by knockout
        /// </summary>
        [Description("Percentage of wins ending by knockout")]
        [DataMember(Name = "KnockoutPercentage", Order = 8)]
        public decimal? KnockoutPercentage { get; set; }

        /// <summary>
        /// Percentage of wins ending by TKO
        /// </summary>
        [Description("Percentage of wins ending by TKO")]
        [DataMember(Name = "TechnicalKnockoutPercentage", Order = 9)]
        public decimal? TechnicalKnockoutPercentage { get; set; }

        /// <summary>
        /// Percentage of wins ending in a decision
        /// </summary>
        [Description("Percentage of wins ending in a decision")]
        [DataMember(Name = "DecisionPercentage", Order = 10)]
        public decimal? DecisionPercentage { get; set; }

    }
}

