﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerTournamentBasic")]
    [Serializable]
    public partial class PlayerTournamentBasic
    {
        /// <summary>
        /// The unique ID of this player/tournament combination
        /// </summary>
        [Description("The unique ID of this player/tournament combination")]
        [DataMember(Name = "PlayerTournamentID", Order = 1)]
        public int PlayerTournamentID { get; set; }

        /// <summary>
        /// The PlayerID of the golfer
        /// </summary>
        [Description("The PlayerID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 2)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The name of the golfer
        /// </summary>
        [Description("The name of the golfer")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The rank of this golfer in the tournament
        /// </summary>
        [Description("The rank of this golfer in the tournament")]
        [DataMember(Name = "Rank", Order = 4)]
        public int? Rank { get; set; }

        /// <summary>
        /// The country where this golfer is from
        /// </summary>
        [Description("The country where this golfer is from")]
        [DataMember(Name = "Country", Order = 5)]
        public string Country { get; set; }

        /// <summary>
        /// The total score of the golfer for this tournament as compared to par
        /// </summary>
        [Description("The total score of the golfer for this tournament as compared to par")]
        [DataMember(Name = "TotalScore", Order = 6)]
        public decimal? TotalScore { get; set; }

        /// <summary>
        /// The total strokes this golfer has for this tournament
        /// </summary>
        [Description("The total strokes this golfer has for this tournament")]
        [DataMember(Name = "TotalStrokes", Order = 7)]
        public decimal? TotalStrokes { get; set; }

        /// <summary>
        /// The current hole of this golfer for the current round
        /// </summary>
        [Description("The current hole of this golfer for the current round")]
        [DataMember(Name = "TotalThrough", Order = 8)]
        public int? TotalThrough { get; set; }

        /// <summary>
        /// The money earned by this golfer for this tournament
        /// </summary>
        [Description("The money earned by this golfer for this tournament")]
        [DataMember(Name = "Earnings", Order = 9)]
        public decimal? Earnings { get; set; }

        /// <summary>
        /// The FedEx points scored by this golfer
        /// </summary>
        [Description("The FedEx points scored by this golfer")]
        [DataMember(Name = "FedExPoints", Order = 10)]
        public int? FedExPoints { get; set; }

        /// <summary>
        /// Total double eagles this golfer scored for this tournament
        /// </summary>
        [Description("Total double eagles this golfer scored for this tournament")]
        [DataMember(Name = "DoubleEagles", Order = 11)]
        public decimal? DoubleEagles { get; set; }

        /// <summary>
        /// Total eagles this golfer scored for this tournament
        /// </summary>
        [Description("Total eagles this golfer scored for this tournament")]
        [DataMember(Name = "Eagles", Order = 12)]
        public decimal? Eagles { get; set; }

        /// <summary>
        /// Total birdies this golfer scored for this tournament
        /// </summary>
        [Description("Total birdies this golfer scored for this tournament")]
        [DataMember(Name = "Birdies", Order = 13)]
        public decimal? Birdies { get; set; }

        /// <summary>
        /// Total pars this golfer scored for this tournament
        /// </summary>
        [Description("Total pars this golfer scored for this tournament")]
        [DataMember(Name = "Pars", Order = 14)]
        public decimal? Pars { get; set; }

        /// <summary>
        /// Total bogeys this golfer scored for this tournament
        /// </summary>
        [Description("Total bogeys this golfer scored for this tournament")]
        [DataMember(Name = "Bogeys", Order = 15)]
        public decimal? Bogeys { get; set; }

        /// <summary>
        /// Total double bogeys this golfer scored for this tournament
        /// </summary>
        [Description("Total double bogeys this golfer scored for this tournament")]
        [DataMember(Name = "DoubleBogeys", Order = 16)]
        public decimal? DoubleBogeys { get; set; }

        /// <summary>
        /// Total triple bogeys (or worse) this golfer scored for this tournament
        /// </summary>
        [Description("Total triple bogeys (or worse) this golfer scored for this tournament")]
        [DataMember(Name = "WorseThanDoubleBogey", Order = 17)]
        public decimal? WorseThanDoubleBogey { get; set; }

        /// <summary>
        /// Total holes-in-one this golfer scored for this tournament
        /// </summary>
        [Description("Total holes-in-one this golfer scored for this tournament")]
        [DataMember(Name = "HoleInOnes", Order = 18)]
        public decimal? HoleInOnes { get; set; }

        /// <summary>
        /// Total streaks of three birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of three birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfThreeBirdiesOrBetter", Order = 19)]
        public decimal? StreaksOfThreeBirdiesOrBetter { get; set; }

        /// <summary>
        /// Total bogey-free rounds this golfer scored
        /// </summary>
        [Description("Total bogey-free rounds this golfer scored")]
        [DataMember(Name = "BogeyFreeRounds", Order = 20)]
        public decimal? BogeyFreeRounds { get; set; }

        /// <summary>
        /// Total rounds this golfer finished scoring under 70 strokes
        /// </summary>
        [Description("Total rounds this golfer finished scoring under 70 strokes")]
        [DataMember(Name = "RoundsUnderSeventy", Order = 21)]
        public decimal? RoundsUnderSeventy { get; set; }

        /// <summary>
        /// Total triple bogeys this golfer scored for this tournament
        /// </summary>
        [Description("Total triple bogeys this golfer scored for this tournament")]
        [DataMember(Name = "TripleBogeys", Order = 22)]
        public decimal? TripleBogeys { get; set; }

        /// <summary>
        /// Total quadruple bogeys (or worse) this golfer scored for this tournament
        /// </summary>
        [Description("Total quadruple bogeys (or worse) this golfer scored for this tournament")]
        [DataMember(Name = "WorseThanTripleBogey", Order = 23)]
        public decimal? WorseThanTripleBogey { get; set; }

        /// <summary>
        /// The time that this golfer tees off for the upcoming round (starting after 2020, this value will be in ET)
        /// </summary>
        [Description("The time that this golfer tees off for the upcoming round (starting after 2020, this value will be in ET)")]
        [DataMember(Name = "TeeTime", Order = 24)]
        public DateTime? TeeTime { get; set; }

        /// <summary>
        /// Indicates whether this golfer made the cut. This field defaults to 1 at tournament start, then flips to 0 once a golfer has been cut (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that this golfer makes the cut)
        /// </summary>
        [Description("Indicates whether this golfer made the cut. This field defaults to 1 at tournament start, then flips to 0 once a golfer has been cut (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that this golfer makes the cut)")]
        [DataMember(Name = "MadeCut", Order = 25)]
        public decimal? MadeCut { get; set; }

        /// <summary>
        /// Indicates whether this golfer won the tournament (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that the golfer wins the tournament)
        /// </summary>
        [Description("Indicates whether this golfer won the tournament (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that the golfer wins the tournament)")]
        [DataMember(Name = "Win", Order = 26)]
        public decimal? Win { get; set; }

        /// <summary>
        /// Indicates whether a golfer is in the regular playing field or if they are an alternate golfer for this tournament.
        /// </summary>
        [Description("Indicates whether a golfer is in the regular playing field or if they are an alternate golfer for this tournament.")]
        [DataMember(Name = "IsAlternate", Order = 27)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// Indicates whether this golfer made the cut, but did not finish the tournament
        /// </summary>
        [Description("Indicates whether this golfer made the cut, but did not finish the tournament")]
        [DataMember(Name = "MadeCutDidNotFinish", Order = 28)]
        public bool? MadeCutDidNotFinish { get; set; }

        /// <summary>
        /// Total streaks of four birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of four birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfFourBirdiesOrBetter", Order = 29)]
        public decimal? StreaksOfFourBirdiesOrBetter { get; set; }

        /// <summary>
        /// Total streaks of five birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of five birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfFiveBirdiesOrBetter", Order = 30)]
        public decimal? StreaksOfFiveBirdiesOrBetter { get; set; }

        /// <summary>
        /// The sum of all back to back birdies (or better) across all rounds
        /// </summary>
        [Description("The sum of all back to back birdies (or better) across all rounds")]
        [DataMember(Name = "ConsecutiveBirdieOrBetterCount", Order = 31)]
        public decimal? ConsecutiveBirdieOrBetterCount { get; set; }

        /// <summary>
        /// The sum of all bounce back holes across all rounds. A bounce back hole is an under par hole following an over par hole
        /// </summary>
        [Description("The sum of all bounce back holes across all rounds. A bounce back hole is an under par hole following an over par hole")]
        [DataMember(Name = "BounceBackCount", Order = 32)]
        public decimal? BounceBackCount { get; set; }

        /// <summary>
        /// Number of rounds that contained five or more birdies (or better)
        /// </summary>
        [Description("Number of rounds that contained five or more birdies (or better)")]
        [DataMember(Name = "RoundsWithFiveOrMoreBirdiesOrBetter", Order = 33)]
        public decimal? RoundsWithFiveOrMoreBirdiesOrBetter { get; set; }

        /// <summary>
        /// Indicates whether the player has withdrawn from the tournament
        /// </summary>
        [Description("Indicates whether the player has withdrawn from the tournament")]
        [DataMember(Name = "IsWithdrawn", Order = 34)]
        public bool IsWithdrawn { get; set; }

        /// <summary>
        /// Total streaks of six birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of six birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfSixBirdiesOrBetter", Order = 35)]
        public decimal? StreaksOfSixBirdiesOrBetter { get; set; }

        /// <summary>
        /// The details of the rounds this golfer played
        /// </summary>
        [Description("The details of the rounds this golfer played")]
        [DataMember(Name = "Rounds", Order = 20036)]
        public PlayerRound[] Rounds { get; set; }

    }
}

