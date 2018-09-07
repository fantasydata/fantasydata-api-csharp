using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerTournamentProjection")]
    [Serializable]
    public partial class PlayerTournamentProjection
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
        /// The TournamentID of the tournament
        /// </summary>
        [Description("The TournamentID of the tournament")]
        [DataMember(Name = "TournamentID", Order = 3)]
        public int TournamentID { get; set; }

        /// <summary>
        /// The name of the golfer
        /// </summary>
        [Description("The name of the golfer")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The rank of this golfer in the tournament
        /// </summary>
        [Description("The rank of this golfer in the tournament")]
        [DataMember(Name = "Rank", Order = 5)]
        public int? Rank { get; set; }

        /// <summary>
        /// The country where this golfer is from
        /// </summary>
        [Description("The country where this golfer is from")]
        [DataMember(Name = "Country", Order = 6)]
        public string Country { get; set; }

        /// <summary>
        /// The total score of the golfer for this tournament as compared to par
        /// </summary>
        [Description("The total score of the golfer for this tournament as compared to par")]
        [DataMember(Name = "TotalScore", Order = 7)]
        public decimal? TotalScore { get; set; }

        /// <summary>
        /// The total strokes this golfer has for this tournament
        /// </summary>
        [Description("The total strokes this golfer has for this tournament")]
        [DataMember(Name = "TotalStrokes", Order = 8)]
        public decimal? TotalStrokes { get; set; }

        /// <summary>
        /// The current hole of this golfer for the current round
        /// </summary>
        [Description("The current hole of this golfer for the current round")]
        [DataMember(Name = "TotalThrough", Order = 9)]
        public int? TotalThrough { get; set; }

        /// <summary>
        /// The money earned by this golfer for this tournament
        /// </summary>
        [Description("The money earned by this golfer for this tournament")]
        [DataMember(Name = "Earnings", Order = 10)]
        public decimal? Earnings { get; set; }

        /// <summary>
        /// The FedEx points scored by this golfer
        /// </summary>
        [Description("The FedEx points scored by this golfer")]
        [DataMember(Name = "FedExPoints", Order = 11)]
        public int? FedExPoints { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the FantasyData scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the FantasyData scoring system")]
        [DataMember(Name = "FantasyPoints", Order = 12)]
        public decimal? FantasyPoints { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the DraftKings scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the DraftKings scoring system")]
        [DataMember(Name = "FantasyPointsDraftKings", Order = 13)]
        public decimal? FantasyPointsDraftKings { get; set; }

        /// <summary>
        /// The salary of this golfer on DraftKings
        /// </summary>
        [Description("The salary of this golfer on DraftKings")]
        [DataMember(Name = "DraftKingsSalary", Order = 14)]
        public int? DraftKingsSalary { get; set; }

        /// <summary>
        /// Total double eagles this golfer scored for this tournament
        /// </summary>
        [Description("Total double eagles this golfer scored for this tournament")]
        [DataMember(Name = "DoubleEagles", Order = 15)]
        public decimal? DoubleEagles { get; set; }

        /// <summary>
        /// Total eagles this golfer scored for this tournament
        /// </summary>
        [Description("Total eagles this golfer scored for this tournament")]
        [DataMember(Name = "Eagles", Order = 16)]
        public decimal? Eagles { get; set; }

        /// <summary>
        /// Total birdies this golfer scored for this tournament
        /// </summary>
        [Description("Total birdies this golfer scored for this tournament")]
        [DataMember(Name = "Birdies", Order = 17)]
        public decimal? Birdies { get; set; }

        /// <summary>
        /// Total pars this golfer scored for this tournament
        /// </summary>
        [Description("Total pars this golfer scored for this tournament")]
        [DataMember(Name = "Pars", Order = 18)]
        public decimal? Pars { get; set; }

        /// <summary>
        /// Total bogeys this golfer scored for this tournament
        /// </summary>
        [Description("Total bogeys this golfer scored for this tournament")]
        [DataMember(Name = "Bogeys", Order = 19)]
        public decimal? Bogeys { get; set; }

        /// <summary>
        /// Total double bogeys this golfer scored for this tournament
        /// </summary>
        [Description("Total double bogeys this golfer scored for this tournament")]
        [DataMember(Name = "DoubleBogeys", Order = 20)]
        public decimal? DoubleBogeys { get; set; }

        /// <summary>
        /// Total triple bogeys (or worse) this golfer scored for this tournament
        /// </summary>
        [Description("Total triple bogeys (or worse) this golfer scored for this tournament")]
        [DataMember(Name = "WorseThanDoubleBogey", Order = 21)]
        public decimal? WorseThanDoubleBogey { get; set; }

        /// <summary>
        /// Total holes-in-one this golfer scored for this tournament
        /// </summary>
        [Description("Total holes-in-one this golfer scored for this tournament")]
        [DataMember(Name = "HoleInOnes", Order = 22)]
        public decimal? HoleInOnes { get; set; }

        /// <summary>
        /// Total streaks of three birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of three birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfThreeBirdiesOrBetter", Order = 23)]
        public decimal? StreaksOfThreeBirdiesOrBetter { get; set; }

        /// <summary>
        /// Total bogey-free rounds this golfer scored
        /// </summary>
        [Description("Total bogey-free rounds this golfer scored")]
        [DataMember(Name = "BogeyFreeRounds", Order = 24)]
        public decimal? BogeyFreeRounds { get; set; }

        /// <summary>
        /// Total rounds this golfer finished scoring under 70 strokes
        /// </summary>
        [Description("Total rounds this golfer finished scoring under 70 strokes")]
        [DataMember(Name = "RoundsUnderSeventy", Order = 25)]
        public decimal? RoundsUnderSeventy { get; set; }

        /// <summary>
        /// Total triple bogeys this golfer scored for this tournament
        /// </summary>
        [Description("Total triple bogeys this golfer scored for this tournament")]
        [DataMember(Name = "TripleBogeys", Order = 26)]
        public decimal? TripleBogeys { get; set; }

        /// <summary>
        /// Total quadruple bogeys (or worse) this golfer scored for this tournament
        /// </summary>
        [Description("Total quadruple bogeys (or worse) this golfer scored for this tournament")]
        [DataMember(Name = "WorseThanTripleBogey", Order = 27)]
        public decimal? WorseThanTripleBogey { get; set; }

        /// <summary>
        /// The time that this golfer tees off for the upcoming round
        /// </summary>
        [Description("The time that this golfer tees off for the upcoming round")]
        [DataMember(Name = "TeeTime", Order = 28)]
        public DateTime? TeeTime { get; set; }

        /// <summary>
        /// Indicates whether this golfer made the cut (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that this golfer makes the cut)
        /// </summary>
        [Description("Indicates whether this golfer made the cut (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that this golfer makes the cut)")]
        [DataMember(Name = "MadeCut", Order = 29)]
        public decimal? MadeCut { get; set; }

        /// <summary>
        /// Indicates whether this golfer won the tournament (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that the golfer wins the tournament)
        /// </summary>
        [Description("Indicates whether this golfer won the tournament (for tournament projections, this value will be a decimal between 0 and 1 of the likelihood that the golfer wins the tournament)")]
        [DataMember(Name = "Win", Order = 30)]
        public decimal? Win { get; set; }

        /// <summary>
        /// Indicates whether a golfer is not playing in this tournament (if golfer is not playing, this will be Out)
        /// </summary>
        [Description("Indicates whether a golfer is not playing in this tournament (if golfer is not playing, this will be Out)")]
        [DataMember(Name = "TournamentStatus", Order = 31)]
        public string TournamentStatus { get; set; }

        [DataMember(Name = "IsAlternate", Order = 32)]
        public bool? IsAlternate { get; set; }

        /// <summary>
        /// The salary of this golfer on FanDuel
        /// </summary>
        [Description("The salary of this golfer on FanDuel")]
        [DataMember(Name = "FanDuelSalary", Order = 33)]
        public int? FanDuelSalary { get; set; }

        /// <summary>
        /// The salary of this golfer on FantasyDraft
        /// </summary>
        [Description("The salary of this golfer on FantasyDraft")]
        [DataMember(Name = "FantasyDraftSalary", Order = 34)]
        public int? FantasyDraftSalary { get; set; }

        /// <summary>
        /// Indicates whether this golfer made the cut, but did not finish the tournament
        /// </summary>
        [Description("Indicates whether this golfer made the cut, but did not finish the tournament")]
        [DataMember(Name = "MadeCutDidNotFinish", Order = 35)]
        public bool? MadeCutDidNotFinish { get; set; }

        /// <summary>
        /// The details of the rounds this golfer played
        /// </summary>
        [Description("The details of the rounds this golfer played")]
        [DataMember(Name = "Rounds", Order = 20036)]
        public PlayerRound[] Rounds { get; set; }

        /// <summary>
        /// Odds to win the tournament displayed as a decimal (assumed over 1, ex. 9/2 = 4.5). This is the payout from the sports book for each dollar wagered.
        /// </summary>
        [Description("Odds to win the tournament displayed as a decimal (assumed over 1, ex. 9/2 = 4.5). This is the payout from the sports book for each dollar wagered.")]
        [DataMember(Name = "OddsToWin", Order = 37)]
        public decimal? OddsToWin { get; set; }

        /// <summary>
        /// Odds to win the tournament displayed as text (ex. 9/2). This is the payout from the sports book for each dollar wagered.
        /// </summary>
        [Description("Odds to win the tournament displayed as text (ex. 9/2). This is the payout from the sports book for each dollar wagered.")]
        [DataMember(Name = "OddsToWinDescription", Order = 38)]
        public string OddsToWinDescription { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the FanDuel scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the FanDuel scoring system")]
        [DataMember(Name = "FantasyPointsFanDuel", Order = 39)]
        public decimal? FantasyPointsFanDuel { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the FantasyDraft scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the FantasyDraft scoring system")]
        [DataMember(Name = "FantasyPointsFantasyDraft", Order = 40)]
        public decimal? FantasyPointsFantasyDraft { get; set; }

        /// <summary>
        /// Total streaks of four birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of four birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfFourBirdiesOrBetter", Order = 41)]
        public decimal? StreaksOfFourBirdiesOrBetter { get; set; }

        /// <summary>
        /// Total streaks of five birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of five birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfFiveBirdiesOrBetter", Order = 42)]
        public decimal? StreaksOfFiveBirdiesOrBetter { get; set; }

        /// <summary>
        /// The sum of all back to back birdies (or better) across all rounds
        /// </summary>
        [Description("The sum of all back to back birdies (or better) across all rounds")]
        [DataMember(Name = "ConsecutiveBirdieOrBetterCount", Order = 43)]
        public decimal? ConsecutiveBirdieOrBetterCount { get; set; }

        /// <summary>
        /// The sum of all bounce back holes across all rounds. A bounce back hole is an under par hole following an over par hole
        /// </summary>
        [Description("The sum of all bounce back holes across all rounds. A bounce back hole is an under par hole following an over par hole")]
        [DataMember(Name = "BounceBackCount", Order = 44)]
        public decimal? BounceBackCount { get; set; }

        /// <summary>
        /// Number of rounds that contained five or more birdies (or better)
        /// </summary>
        [Description("Number of rounds that contained five or more birdies (or better)")]
        [DataMember(Name = "RoundsWithFiveOrMoreBirdiesOrBetter", Order = 45)]
        public decimal? RoundsWithFiveOrMoreBirdiesOrBetter { get; set; }

        /// <summary>
        /// Indicates whether the player has withdrawn from the tournament
        /// </summary>
        [Description("Indicates whether the player has withdrawn from the tournament")]
        [DataMember(Name = "IsWithdrawn", Order = 46)]
        public bool IsWithdrawn { get; set; }

        /// <summary>
        /// The fantasy points this golfer scored using the Yahoo scoring system
        /// </summary>
        [Description("The fantasy points this golfer scored using the Yahoo scoring system")]
        [DataMember(Name = "FantasyPointsYahoo", Order = 47)]
        public decimal? FantasyPointsYahoo { get; set; }

        /// <summary>
        /// Total streaks of six birdies (or better) this golfer scored (maximum one per round)
        /// </summary>
        [Description("Total streaks of six birdies (or better) this golfer scored (maximum one per round)")]
        [DataMember(Name = "StreaksOfSixBirdiesOrBetter", Order = 48)]
        public decimal? StreaksOfSixBirdiesOrBetter { get; set; }

    }
}

