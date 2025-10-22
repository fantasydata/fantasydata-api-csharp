using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="GameOddResult")]
    [Serializable]
    public partial class GameOddResult
    {
        /// <summary>
        /// The unique ID of this odd
        /// </summary>
        [Description("The unique ID of this odd")]
        [DataMember(Name = "GameOddID", Order = 1)]
        public int GameOddID { get; set; }

        /// <summary>
        /// The name of the sportsbook
        /// </summary>
        [Description("The name of the sportsbook")]
        [DataMember(Name = "Sportsbook", Order = 2)]
        public string Sportsbook { get; set; }

        /// <summary>
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameID", Order = 3)]
        public int GameID { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first created (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when these odds were first created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 4)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when these odds were last updated, based on US Eatern Time (EST/EDT). If these are the latest odds for this game, and they have not been updated within the last few minutes, then it indicates that there were problems connecting to the sportsbook.
        /// </summary>
        [Description("The timestamp of when these odds were last updated, based on US Eatern Time (EST/EDT). If these are the latest odds for this game, and they have not been updated within the last few minutes, then it indicates that there were problems connecting to the sportsbook.")]
        [DataMember(Name = "Updated", Order = 5)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The sportsbook's moneyline for the home team
        /// </summary>
        [Description("The sportsbook's moneyline for the home team")]
        [DataMember(Name = "HomeMoneyLine", Order = 6)]
        public int? HomeMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's money line for the away team
        /// </summary>
        [Description("The sportsbook's money line for the away team")]
        [DataMember(Name = "AwayMoneyLine", Order = 7)]
        public int? AwayMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's point spread for the home team
        /// </summary>
        [Description("The sportsbook's point spread for the home team")]
        [DataMember(Name = "HomePointSpread", Order = 8)]
        public decimal? HomePointSpread { get; set; }

        /// <summary>
        /// The sportsbook's point spread for the away team
        /// </summary>
        [Description("The sportsbook's point spread for the away team")]
        [DataMember(Name = "AwayPointSpread", Order = 9)]
        public decimal? AwayPointSpread { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the home team
        /// </summary>
        [Description("The sportsbook's point spread payout for the home team")]
        [DataMember(Name = "HomePointSpreadPayout", Order = 10)]
        public int? HomePointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the away team
        /// </summary>
        [Description("The sportsbook's point spread payout for the away team")]
        [DataMember(Name = "AwayPointSpreadPayout", Order = 11)]
        public int? AwayPointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's total goals line (over/under) for the game
        /// </summary>
        [Description("The sportsbook's total goals line (over/under) for the game")]
        [DataMember(Name = "OverUnder", Order = 12)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over bet on the total goals line
        /// </summary>
        [Description("The sportsbook's payout for the over bet on the total goals line")]
        [DataMember(Name = "OverPayout", Order = 13)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 14)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// The unique ID of the sportsbook
        /// </summary>
        [Description("The unique ID of the sportsbook")]
        [DataMember(Name = "SportsbookID", Order = 15)]
        public int? SportsbookID { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 16)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// The odd type of this specific odd
        /// </summary>
        [Description("The odd type of this specific odd")]
        [DataMember(Name = "OddType", Order = 17)]
        public string OddType { get; set; }

        /// <summary>
        /// List of outcomes showing results of betting markets that were bet on for the given match
        /// </summary>
        [Description("List of outcomes showing results of betting markets that were bet on for the given match")]
        [DataMember(Name = "GameOddOutcomeResults", Order = 20018)]
        public GameOddOutcome[] GameOddOutcomeResults { get; set; }

    }
}

