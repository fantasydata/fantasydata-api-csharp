using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="Fighter")]
    [Serializable]
    public partial class Fighter
    {
        /// <summary>
        /// The unique ID of this fighter
        /// </summary>
        [Description("The unique ID of this fighter")]
        [DataMember(Name = "FighterId", Order = 1)]
        public int FighterId { get; set; }

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
        /// The nickname of the fighter
        /// </summary>
        [Description("The nickname of the fighter")]
        [DataMember(Name = "Nickname", Order = 4)]
        public string Nickname { get; set; }

        /// <summary>
        /// The fighter's weight class
        /// </summary>
        [Description("The fighter's weight class")]
        [DataMember(Name = "WeightClass", Order = 5)]
        public string WeightClass { get; set; }

        /// <summary>
        /// The fighter's date of birth
        /// </summary>
        [Description("The fighter's date of birth")]
        [DataMember(Name = "BirthDate", Order = 6)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The height of the fighter
        /// </summary>
        [Description("The height of the fighter")]
        [DataMember(Name = "Height", Order = 7)]
        public decimal? Height { get; set; }

        /// <summary>
        /// The fighter's weight in pounds (lbs.)
        /// </summary>
        [Description("The fighter's weight in pounds (lbs.)")]
        [DataMember(Name = "Weight", Order = 8)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// The fighter's reach
        /// </summary>
        [Description("The fighter's reach")]
        [DataMember(Name = "Reach", Order = 9)]
        public decimal? Reach { get; set; }

        /// <summary>
        /// The total number of wins the fighter has in their career
        /// </summary>
        [Description("The total number of wins the fighter has in their career")]
        [DataMember(Name = "Wins", Order = 10)]
        public int? Wins { get; set; }

        /// <summary>
        /// Total number of losses by the fighter in their career
        /// </summary>
        [Description("Total number of losses by the fighter in their career")]
        [DataMember(Name = "Losses", Order = 11)]
        public int? Losses { get; set; }

        /// <summary>
        /// The total number of fights in the fighter's career that ended in a draw
        /// </summary>
        [Description("The total number of fights in the fighter's career that ended in a draw")]
        [DataMember(Name = "Draws", Order = 12)]
        public int? Draws { get; set; }

        /// <summary>
        /// The total number of fights in the fighter's career that ended in a no contest
        /// </summary>
        [Description("The total number of fights in the fighter's career that ended in a no contest")]
        [DataMember(Name = "NoContests", Order = 13)]
        public int? NoContests { get; set; }

        /// <summary>
        /// Total technical knockout (TKO) wins by the fighter in their career
        /// </summary>
        [Description("Total technical knockout (TKO) wins by the fighter in their career")]
        [DataMember(Name = "TechnicalKnockouts", Order = 14)]
        public int? TechnicalKnockouts { get; set; }

        /// <summary>
        /// Total technical knockout (TKO) losses by the fighter in their career
        /// </summary>
        [Description("Total technical knockout (TKO) losses by the fighter in their career")]
        [DataMember(Name = "TechnicalKnockoutLosses", Order = 15)]
        public int? TechnicalKnockoutLosses { get; set; }

        /// <summary>
        /// Total submission wins by the fighter in their career
        /// </summary>
        [Description("Total submission wins by the fighter in their career")]
        [DataMember(Name = "Submissions", Order = 16)]
        public int? Submissions { get; set; }

        /// <summary>
        /// Total submission losses by the fighter in their career
        /// </summary>
        [Description("Total submission losses by the fighter in their career")]
        [DataMember(Name = "SubmissionLosses", Order = 17)]
        public int? SubmissionLosses { get; set; }

        /// <summary>
        /// Total title fight wins by the fighter in their career
        /// </summary>
        [Description("Total title fight wins by the fighter in their career")]
        [DataMember(Name = "TitleWins", Order = 18)]
        public int? TitleWins { get; set; }

        /// <summary>
        /// Total title fight losses by the fighter in their career
        /// </summary>
        [Description("Total title fight losses by the fighter in their career")]
        [DataMember(Name = "TitleLosses", Order = 19)]
        public int? TitleLosses { get; set; }

        /// <summary>
        /// The fighter's title draws
        /// </summary>
        [Description("The fighter's title draws")]
        [DataMember(Name = "TitleDraws", Order = 20)]
        public int? TitleDraws { get; set; }

        /// <summary>
        /// The fighter's overall career stats
        /// </summary>
        [Description("The fighter's overall career stats")]
        [DataMember(Name = "CareerStats", Order = 10021)]
        public CareerStat CareerStats { get; set; }

    }
}

