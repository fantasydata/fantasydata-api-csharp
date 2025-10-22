using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MMA
{
    [DataContract(Namespace="", Name="FightStat")]
    [Serializable]
    public partial class FightStat
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
        /// Indicates if this fighter won the fight
        /// </summary>
        [Description("Indicates if this fighter won the fight")]
        [DataMember(Name = "Winner", Order = 4)]
        public bool? Winner { get; set; }

        /// <summary>
        /// Total fantasy points scored by the fighter in the fight
        /// </summary>
        [Description("Total fantasy points scored by the fighter in the fight")]
        [DataMember(Name = "FantasyPoints", Order = 5)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// Total DraftKings fantasy points scored by the fighter in the fight
        /// </summary>
        [Description("Total DraftKings fantasy points scored by the fighter in the fight")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 6)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The total number of official knockdowns by the fighter to the opponent
        /// </summary>
        [Description("The total number of official knockdowns by the fighter to the opponent")]
        [DataMember(Name = "Knockdowns", Order = 7)]
        public decimal? Knockdowns { get; set; }

        /// <summary>
        /// Total number of all strikes attempted by the fighter in this fight
        /// </summary>
        [Description("Total number of all strikes attempted by the fighter in this fight")]
        [DataMember(Name = "TotalStrikesAttempted", Order = 8)]
        public decimal? TotalStrikesAttempted { get; set; }

        /// <summary>
        /// Total number of all strikes landed by the fighter in this fight
        /// </summary>
        [Description("Total number of all strikes landed by the fighter in this fight")]
        [DataMember(Name = "TotalStrikesLanded", Order = 9)]
        public decimal? TotalStrikesLanded { get; set; }

        /// <summary>
        /// Total number of strikes attempted that officials deem significant strikes by the fighter in this fight
        /// </summary>
        [Description("Total number of strikes attempted that officials deem significant strikes by the fighter in this fight")]
        [DataMember(Name = "SigStrikesAttempted", Order = 10)]
        public decimal? SigStrikesAttempted { get; set; }

        /// <summary>
        /// Total number of strikes landed that officials deem significant strikes by the fighter in this fight
        /// </summary>
        [Description("Total number of strikes landed that officials deem significant strikes by the fighter in this fight")]
        [DataMember(Name = "SigStrikesLanded", Order = 11)]
        public decimal? SigStrikesLanded { get; set; }

        /// <summary>
        /// Total number of takedowns attempted by the fighter in this fight
        /// </summary>
        [Description("Total number of takedowns attempted by the fighter in this fight")]
        [DataMember(Name = "TakedownsAttempted", Order = 12)]
        public decimal? TakedownsAttempted { get; set; }

        /// <summary>
        /// Total number of takedowns landed by the fighter in this fight
        /// </summary>
        [Description("Total number of takedowns landed by the fighter in this fight")]
        [DataMember(Name = "TakedownsLanded", Order = 13)]
        public decimal? TakedownsLanded { get; set; }

        /// <summary>
        /// Total number of takedowns that were a result of forcefully slamming opponent to ground by the fighter in this fight
        /// </summary>
        [Description("Total number of takedowns that were a result of forcefully slamming opponent to ground by the fighter in this fight")]
        [DataMember(Name = "TakedownsSlams", Order = 14)]
        public decimal? TakedownsSlams { get; set; }

        /// <summary>
        /// Total number of takedowns landed divided by number of takedowns attempted
        /// </summary>
        [Description("Total number of takedowns landed divided by number of takedowns attempted")]
        [DataMember(Name = "TakedownAccuracy", Order = 15)]
        public decimal? TakedownAccuracy { get; set; }

        /// <summary>
        /// Total number of advances to half guard, side control, mount, or back control
        /// </summary>
        [Description("Total number of advances to half guard, side control, mount, or back control")]
        [DataMember(Name = "Advances", Order = 16)]
        public decimal? Advances { get; set; }

        /// <summary>
        /// Transitions performed by countering your opponents transition and giving fighter the offensive advantage.
        /// </summary>
        [Description("Transitions performed by countering your opponents transition and giving fighter the offensive advantage.")]
        [DataMember(Name = "Reversals", Order = 17)]
        public decimal? Reversals { get; set; }

        /// <summary>
        /// Total number of submissions or technical submissions attempted
        /// </summary>
        [Description("Total number of submissions or technical submissions attempted")]
        [DataMember(Name = "Submissions", Order = 18)]
        public decimal? Submissions { get; set; }

        /// <summary>
        /// Number of takedown slams landed divided by number of takedowns attempted
        /// </summary>
        [Description("Number of takedown slams landed divided by number of takedowns attempted")]
        [DataMember(Name = "SlamRate", Order = 19)]
        public decimal? SlamRate { get; set; }

        /// <summary>
        /// Number of seconds fighter deemed in control by officials
        /// </summary>
        [Description("Number of seconds fighter deemed in control by officials")]
        [DataMember(Name = "TimeInControl", Order = 20)]
        public decimal? TimeInControl { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight in the first round
        /// </summary>
        [Description("Indicates if this fighter won the fight in the first round")]
        [DataMember(Name = "FirstRoundWin", Order = 21)]
        public bool? FirstRoundWin { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight in the second round
        /// </summary>
        [Description("Indicates if this fighter won the fight in the second round")]
        [DataMember(Name = "SecondRoundWin", Order = 22)]
        public bool? SecondRoundWin { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight in the third round
        /// </summary>
        [Description("Indicates if this fighter won the fight in the third round")]
        [DataMember(Name = "ThirdRoundWin", Order = 23)]
        public bool? ThirdRoundWin { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight in the fourth round
        /// </summary>
        [Description("Indicates if this fighter won the fight in the fourth round")]
        [DataMember(Name = "FourthRoundWin", Order = 24)]
        public bool? FourthRoundWin { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight in the fifth round
        /// </summary>
        [Description("Indicates if this fighter won the fight in the fifth round")]
        [DataMember(Name = "FifthRoundWin", Order = 25)]
        public bool? FifthRoundWin { get; set; }

        /// <summary>
        /// Indicates if this fighter won the fight by decision
        /// </summary>
        [Description("Indicates if this fighter won the fight by decision")]
        [DataMember(Name = "DecisionWin", Order = 26)]
        public bool? DecisionWin { get; set; }

    }
}

