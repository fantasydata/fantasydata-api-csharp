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
        /// The fighter's nickname
        /// </summary>
        [Description("The fighter's nickname")]
        [DataMember(Name = "Nickname", Order = 4)]
        public string Nickname { get; set; }

        /// <summary>
        /// The fighter's weight class
        /// </summary>
        [Description("The fighter's weight class")]
        [DataMember(Name = "WeightClass", Order = 5)]
        public string WeightClass { get; set; }

        /// <summary>
        /// The fighter's DOB
        /// </summary>
        [Description("The fighter's DOB")]
        [DataMember(Name = "BirthDate", Order = 6)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The fighter's height
        /// </summary>
        [Description("The fighter's height")]
        [DataMember(Name = "Height", Order = 7)]
        public decimal? Height { get; set; }

        /// <summary>
        /// The fighter's weight
        /// </summary>
        [Description("The fighter's weight")]
        [DataMember(Name = "Weight", Order = 8)]
        public decimal? Weight { get; set; }

        /// <summary>
        /// The fighter's reach
        /// </summary>
        [Description("The fighter's reach")]
        [DataMember(Name = "Reach", Order = 9)]
        public decimal? Reach { get; set; }

        /// <summary>
        /// The fighter's wins
        /// </summary>
        [Description("The fighter's wins")]
        [DataMember(Name = "Wins", Order = 10)]
        public int? Wins { get; set; }

        /// <summary>
        /// The fighter's losses
        /// </summary>
        [Description("The fighter's losses")]
        [DataMember(Name = "Losses", Order = 11)]
        public int? Losses { get; set; }

        /// <summary>
        /// The fighter's fights that ended in a draw
        /// </summary>
        [Description("The fighter's fights that ended in a draw")]
        [DataMember(Name = "Draws", Order = 12)]
        public int? Draws { get; set; }

        /// <summary>
        /// The fighter's fights that ended in a no contest
        /// </summary>
        [Description("The fighter's fights that ended in a no contest")]
        [DataMember(Name = "NoContests", Order = 13)]
        public int? NoContests { get; set; }

        /// <summary>
        /// The fighter's TKO wins
        /// </summary>
        [Description("The fighter's TKO wins")]
        [DataMember(Name = "TechnicalKnockouts", Order = 14)]
        public int? TechnicalKnockouts { get; set; }

        /// <summary>
        /// The fighter's TKO losses
        /// </summary>
        [Description("The fighter's TKO losses")]
        [DataMember(Name = "TechnicalKnockoutLosses", Order = 15)]
        public int? TechnicalKnockoutLosses { get; set; }

        /// <summary>
        /// The fighter's submission wins
        /// </summary>
        [Description("The fighter's submission wins")]
        [DataMember(Name = "Submissions", Order = 16)]
        public int? Submissions { get; set; }

        /// <summary>
        /// The fighter's submission losses
        /// </summary>
        [Description("The fighter's submission losses")]
        [DataMember(Name = "SubmissionLosses", Order = 17)]
        public int? SubmissionLosses { get; set; }

        /// <summary>
        /// The fighter's title wins
        /// </summary>
        [Description("The fighter's title wins")]
        [DataMember(Name = "TitleWins", Order = 18)]
        public int? TitleWins { get; set; }

        /// <summary>
        /// The fighter's title losses
        /// </summary>
        [Description("The fighter's title losses")]
        [DataMember(Name = "TitleLosses", Order = 19)]
        public int? TitleLosses { get; set; }

        /// <summary>
        /// The fighter's title draws
        /// </summary>
        [Description("The fighter's title draws")]
        [DataMember(Name = "TitleDraws", Order = 20)]
        public int? TitleDraws { get; set; }

        /// <summary>
        /// The fighter's title draws
        /// </summary>
        [Description("The fighter's title draws")]
        [DataMember(Name = "CareerStats", Order = 10021)]
        public CareerStat CareerStats { get; set; }

    }
}

