using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerRound")]
    [Serializable]
    public partial class PlayerRound
    {
        /// <summary>
        /// The unique ID of this player/round combination
        /// </summary>
        [Description("The unique ID of this player/round combination")]
        [DataMember(Name = "PlayerRoundID", Order = 1)]
        public int PlayerRoundID { get; set; }

        /// <summary>
        /// The unique ID of this player/tournament combination
        /// </summary>
        [Description("The unique ID of this player/tournament combination")]
        [DataMember(Name = "PlayerTournamentID", Order = 2)]
        public int PlayerTournamentID { get; set; }

        /// <summary>
        /// The round number of this round
        /// </summary>
        [Description("The round number of this round")]
        [DataMember(Name = "Number", Order = 3)]
        public int? Number { get; set; }

        /// <summary>
        /// The day that this round is played on
        /// </summary>
        [Description("The day that this round is played on")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The par of the course this round is played on
        /// </summary>
        [Description("The par of the course this round is played on")]
        [DataMember(Name = "Par", Order = 5)]
        public int? Par { get; set; }

        /// <summary>
        /// The player's score (+/- par) on this round
        /// </summary>
        [Description("The player's score (+/- par) on this round")]
        [DataMember(Name = "Score", Order = 6)]
        public int? Score { get; set; }

        /// <summary>
        /// Indicates whether the player shot bogey-free during this round
        /// </summary>
        [Description("Indicates whether the player shot bogey-free during this round")]
        [DataMember(Name = "BogeyFree", Order = 7)]
        public bool BogeyFree { get; set; }

        /// <summary>
        /// Indicates whether the player got a streak of three birdies (or better) on this round
        /// </summary>
        [Description("Indicates whether the player got a streak of three birdies (or better) on this round")]
        [DataMember(Name = "IncludesStreakOfThreeBirdiesOrBetter", Order = 8)]
        public bool IncludesStreakOfThreeBirdiesOrBetter { get; set; }

        /// <summary>
        /// Total number of double eagles shot by this player on this round
        /// </summary>
        [Description("Total number of double eagles shot by this player on this round")]
        [DataMember(Name = "DoubleEagles", Order = 9)]
        public int? DoubleEagles { get; set; }

        /// <summary>
        /// Total number of eagles shot by this player on this round
        /// </summary>
        [Description("Total number of eagles shot by this player on this round")]
        [DataMember(Name = "Eagles", Order = 10)]
        public int? Eagles { get; set; }

        /// <summary>
        /// Total number of birdies shot by this player on this round
        /// </summary>
        [Description("Total number of birdies shot by this player on this round")]
        [DataMember(Name = "Birdies", Order = 11)]
        public int? Birdies { get; set; }

        /// <summary>
        /// Total number of pars shot by this player on this round
        /// </summary>
        [Description("Total number of pars shot by this player on this round")]
        [DataMember(Name = "Pars", Order = 12)]
        public int? Pars { get; set; }

        /// <summary>
        /// Total number of bogeys shot by this player on this round
        /// </summary>
        [Description("Total number of bogeys shot by this player on this round")]
        [DataMember(Name = "Bogeys", Order = 13)]
        public int? Bogeys { get; set; }

        /// <summary>
        /// Total number of double bogeys shot by this player on this round
        /// </summary>
        [Description("Total number of double bogeys shot by this player on this round")]
        [DataMember(Name = "DoubleBogeys", Order = 14)]
        public int? DoubleBogeys { get; set; }

        /// <summary>
        /// Total number of worse than double bogeys shot by this player on this round
        /// </summary>
        [Description("Total number of worse than double bogeys shot by this player on this round")]
        [DataMember(Name = "WorseThanDoubleBogey", Order = 15)]
        public int? WorseThanDoubleBogey { get; set; }

        /// <summary>
        /// Total number of holes in one shot by this player on this round
        /// </summary>
        [Description("Total number of holes in one shot by this player on this round")]
        [DataMember(Name = "HoleInOnes", Order = 16)]
        public int? HoleInOnes { get; set; }

        /// <summary>
        /// Total number of triple bogeys shot by this player on this round
        /// </summary>
        [Description("Total number of triple bogeys shot by this player on this round")]
        [DataMember(Name = "TripleBogeys", Order = 17)]
        public int? TripleBogeys { get; set; }

        /// <summary>
        /// Total number of worse than triple bogeys shot by this player on this round
        /// </summary>
        [Description("Total number of worse than triple bogeys shot by this player on this round")]
        [DataMember(Name = "WorseThanTripleBogey", Order = 18)]
        public int? WorseThanTripleBogey { get; set; }

        /// <summary>
        /// The hole-by-hole results of this player on this round
        /// </summary>
        [Description("The hole-by-hole results of this player on this round")]
        [DataMember(Name = "Holes", Order = 20019)]
        public PlayerHole[] Holes { get; set; }

        /// <summary>
        /// The longest streak of birdies (or better)
        /// </summary>
        [Description("The longest streak of birdies (or better)")]
        [DataMember(Name = "LongestBirdieOrBetterStreak", Order = 20)]
        public decimal? LongestBirdieOrBetterStreak { get; set; }

        /// <summary>
        /// The longest streak of consecutive birdies (or better)
        /// </summary>
        [Description("The longest streak of consecutive birdies (or better)")]
        [DataMember(Name = "ConsecutiveBirdieOrBetterCount", Order = 21)]
        public decimal? ConsecutiveBirdieOrBetterCount { get; set; }

        /// <summary>
        /// The total bouncebacks this player had on this round
        /// </summary>
        [Description("The total bouncebacks this player had on this round")]
        [DataMember(Name = "BounceBackCount", Order = 22)]
        public decimal? BounceBackCount { get; set; }

        /// <summary>
        /// Indicates whether the player shot a streak of four birdies or better on this round
        /// </summary>
        [Description("Indicates whether the player shot a streak of four birdies or better on this round")]
        [DataMember(Name = "IncludesStreakOfFourBirdiesOrBetter", Order = 23)]
        public bool IncludesStreakOfFourBirdiesOrBetter { get; set; }

        /// <summary>
        /// Indicates whether the player shot a streak of five birdies or better on this round
        /// </summary>
        [Description("Indicates whether the player shot a streak of five birdies or better on this round")]
        [DataMember(Name = "IncludesStreakOfFiveBirdiesOrBetter", Order = 24)]
        public bool IncludesStreakOfFiveBirdiesOrBetter { get; set; }

        /// <summary>
        /// Indicates whether the player shot a streak of five (or more) birdies or better on this round
        /// </summary>
        [Description("Indicates whether the player shot a streak of five (or more) birdies or better on this round")]
        [DataMember(Name = "IncludesFiveOrMoreBirdiesOrBetter", Order = 25)]
        public bool IncludesFiveOrMoreBirdiesOrBetter { get; set; }

        /// <summary>
        /// Indicates whether the player shot a six of five birdies or better on this round
        /// </summary>
        [Description("Indicates whether the player shot a six of five birdies or better on this round")]
        [DataMember(Name = "IncludesStreakOfSixBirdiesOrBetter", Order = 26)]
        public bool IncludesStreakOfSixBirdiesOrBetter { get; set; }

    }
}

