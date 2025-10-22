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
        /// The first name of the fighter
        /// </summary>
        [Description("The first name of the fighter")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the fighter
        /// </summary>
        [Description("The last name of the fighter")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// Significant strikes landed per minute over the fighter's career
        /// </summary>
        [Description("Significant strikes landed per minute over the fighter's career")]
        [DataMember(Name = "SigStrikesLandedPerMinute", Order = 4)]
        public decimal? SigStrikesLandedPerMinute { get; set; }

        /// <summary>
        /// Significant strikes landed divided by strikes attempted over the fighter's career
        /// </summary>
        [Description("Significant strikes landed divided by strikes attempted over the fighter's career")]
        [DataMember(Name = "SigStrikeAccuracy", Order = 5)]
        public decimal? SigStrikeAccuracy { get; set; }

        /// <summary>
        /// Average takedowns landed per 15 minutes in the fighter's career
        /// </summary>
        [Description("Average takedowns landed per 15 minutes in the fighter's career")]
        [DataMember(Name = "TakedownAverage", Order = 6)]
        public decimal? TakedownAverage { get; set; }

        /// <summary>
        /// Average number of submissions attempted per 15 minutes in the fighter's career
        /// </summary>
        [Description("Average number of submissions attempted per 15 minutes in the fighter's career")]
        [DataMember(Name = "SubmissionAverage", Order = 7)]
        public decimal? SubmissionAverage { get; set; }

        /// <summary>
        /// The percentage of wins ending in a knockout by the fighter
        /// </summary>
        [Description("The percentage of wins ending in a knockout by the fighter")]
        [DataMember(Name = "KnockoutPercentage", Order = 8)]
        public decimal? KnockoutPercentage { get; set; }

        /// <summary>
        /// Percentage of wins ending by TKO in the fighter's career
        /// </summary>
        [Description("Percentage of wins ending by TKO in the fighter's career")]
        [DataMember(Name = "TechnicalKnockoutPercentage", Order = 9)]
        public decimal? TechnicalKnockoutPercentage { get; set; }

        /// <summary>
        /// The percentage of wins ending in a decision by the fighter in their career
        /// </summary>
        [Description("The percentage of wins ending in a decision by the fighter in their career")]
        [DataMember(Name = "DecisionPercentage", Order = 10)]
        public decimal? DecisionPercentage { get; set; }

    }
}

