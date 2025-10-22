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
        /// The unique ID of this golfer/round combination
        /// </summary>
        [Description("The unique ID of this golfer/round combination")]
        [DataMember(Name = "PlayerRoundID", Order = 1)]
        public int PlayerRoundID { get; set; }

        /// <summary>
        /// The unique ID of this player/tournament combination
        /// </summary>
        [Description("The unique ID of this player/tournament combination")]
        [DataMember(Name = "PlayerTournamentID", Order = 2)]
        public int PlayerTournamentID { get; set; }

        /// <summary>
        /// The number of the round associated with these stats
        /// </summary>
        [Description("The number of the round associated with these stats")]
        [DataMember(Name = "Number", Order = 3)]
        public int? Number { get; set; }

        /// <summary>
        /// The date that this round is being played on
        /// </summary>
        [Description("The date that this round is being played on")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime Day { get; set; }

        /// <summary>
        /// The par of the course this round is played on
        /// </summary>
        [Description("The par of the course this round is played on")]
        [DataMember(Name = "Par", Order = 5)]
        public int? Par { get; set; }

        /// <summary>
        /// The total strokes this golfer has for this round in the tournament
        /// </summary>
        [Description("The total strokes this golfer has for this round in the tournament")]
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
        /// Total eagles scored by the golfer in this round
        /// </summary>
        [Description("Total eagles scored by the golfer in this round")]
        [DataMember(Name = "Eagles", Order = 10)]
        public int? Eagles { get; set; }

        /// <summary>
        /// Total birdies scored by the golfer for this round
        /// </summary>
        [Description("Total birdies scored by the golfer for this round")]
        [DataMember(Name = "Birdies", Order = 11)]
        public int? Birdies { get; set; }

        /// <summary>
        /// Total pars scored by the player in this round of the tournament
        /// </summary>
        [Description("Total pars scored by the player in this round of the tournament")]
        [DataMember(Name = "Pars", Order = 12)]
        public int? Pars { get; set; }

        /// <summary>
        /// Total bogeys scored by the golfer for this round
        /// </summary>
        [Description("Total bogeys scored by the golfer for this round")]
        [DataMember(Name = "Bogeys", Order = 13)]
        public int? Bogeys { get; set; }

        /// <summary>
        /// Total double bogeys scored by the golfer in this round
        /// </summary>
        [Description("Total double bogeys scored by the golfer in this round")]
        [DataMember(Name = "DoubleBogeys", Order = 14)]
        public int? DoubleBogeys { get; set; }

        /// <summary>
        /// Total holes the golfer scored worse than a double bogey for the round
        /// </summary>
        [Description("Total holes the golfer scored worse than a double bogey for the round")]
        [DataMember(Name = "WorseThanDoubleBogey", Order = 15)]
        public int? WorseThanDoubleBogey { get; set; }

        /// <summary>
        /// Total holes-in-one scored by the golfer in this round
        /// </summary>
        [Description("Total holes-in-one scored by the golfer in this round")]
        [DataMember(Name = "HoleInOnes", Order = 16)]
        public int? HoleInOnes { get; set; }

        /// <summary>
        /// Total triple bogeys this golfer scored for the round
        /// </summary>
        [Description("Total triple bogeys this golfer scored for the round")]
        [DataMember(Name = "TripleBogeys", Order = 17)]
        public int? TripleBogeys { get; set; }

        /// <summary>
        /// Total holes the golfer scored worse than a triple bogey for the round
        /// </summary>
        [Description("Total holes the golfer scored worse than a triple bogey for the round")]
        [DataMember(Name = "WorseThanTripleBogey", Order = 18)]
        public int? WorseThanTripleBogey { get; set; }

        /// <summary>
        /// The hole-by-hole results for this player in this round
        /// </summary>
        [Description("The hole-by-hole results for this player in this round")]
        [DataMember(Name = "Holes", Order = 20019)]
        public PlayerHole[] Holes { get; set; }

        /// <summary>
        /// The longest streak of birdies (or better) by the golfer
        /// </summary>
        [Description("The longest streak of birdies (or better) by the golfer")]
        [DataMember(Name = "LongestBirdieOrBetterStreak", Order = 20)]
        public decimal? LongestBirdieOrBetterStreak { get; set; }

        /// <summary>
        /// The sum of all back to back birdies (or better) by the golfer in this round
        /// </summary>
        [Description("The sum of all back to back birdies (or better) by the golfer in this round")]
        [DataMember(Name = "ConsecutiveBirdieOrBetterCount", Order = 21)]
        public decimal? ConsecutiveBirdieOrBetterCount { get; set; }

        /// <summary>
        /// Total bounce back holes by the golfer for this round
        /// </summary>
        [Description("Total bounce back holes by the golfer for this round")]
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

        /// <summary>
        /// The time that this golfer tees off for the upcoming round (in US Eastern Time)
        /// </summary>
        [Description("The time that this golfer tees off for the upcoming round (in US Eastern Time)")]
        [DataMember(Name = "TeeTime", Order = 27)]
        public DateTime? TeeTime { get; set; }

        /// <summary>
        /// Indicates whether the player started with the back nine holes
        /// </summary>
        [Description("Indicates whether the player started with the back nine holes")]
        [DataMember(Name = "BackNineStart", Order = 28)]
        public bool? BackNineStart { get; set; }

    }
}

