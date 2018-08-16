using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="GameOdd")]
    [Serializable]
    public partial class GameOdd
    {
        /// <summary>
        /// Unique ID of this odd
        /// </summary>
        [Description("Unique ID of this odd")]
        [DataMember(Name = "GameOddId", Order = 1)]
        public int GameOddId { get; set; }

        /// <summary>
        /// Name of sportsbook
        /// </summary>
        [Description("Name of sportsbook")]
        [DataMember(Name = "Sportsbook", Order = 2)]
        public string Sportsbook { get; set; }

        /// <summary>
        /// Unique ID of the Score/Game.
        /// </summary>
        [Description("Unique ID of the Score/Game.")]
        [DataMember(Name = "ScoreId", Order = 3)]
        public int ScoreId { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first created, based on US Eatern Time (EST/EDT).
        /// </summary>
        [Description("The timestamp of when these odds were first created, based on US Eatern Time (EST/EDT).")]
        [DataMember(Name = "Created", Order = 4)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when these odds were last updated, based on US Eatern Time (EST/EDT). If these are the latest odds for this game, and they have not been updated within the last few minutes, then it indicates that there were problems connecting to the sportsbook.
        /// </summary>
        [Description("The timestamp of when these odds were last updated, based on US Eatern Time (EST/EDT). If these are the latest odds for this game, and they have not been updated within the last few minutes, then it indicates that there were problems connecting to the sportsbook.")]
        [DataMember(Name = "Updated", Order = 5)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The sportsbook's money line for the home team
        /// </summary>
        [Description("The sportsbook's money line for the home team")]
        [DataMember(Name = "HomeMoneyLine", Order = 6)]
        public int? HomeMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's money line for the away team
        /// </summary>
        [Description("The sportsbook's money line for the away team")]
        [DataMember(Name = "AwayMoneyLine", Order = 7)]
        public int? AwayMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's money line for a draw
        /// </summary>
        [Description("The sportsbook's money line for a draw")]
        [DataMember(Name = "DrawMoneyLine", Order = 8)]
        public int? DrawMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's point spread for the home team
        /// </summary>
        [Description("The sportsbook's point spread for the home team")]
        [DataMember(Name = "HomePointSpread", Order = 9)]
        public decimal? HomePointSpread { get; set; }

        /// <summary>
        /// The sportsbook's point spread for the away team
        /// </summary>
        [Description("The sportsbook's point spread for the away team")]
        [DataMember(Name = "AwayPointSpread", Order = 10)]
        public decimal? AwayPointSpread { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the home team
        /// </summary>
        [Description("The sportsbook's point spread payout for the home team")]
        [DataMember(Name = "HomePointSpreadPayout", Order = 11)]
        public int? HomePointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the away team
        /// </summary>
        [Description("The sportsbook's point spread payout for the away team")]
        [DataMember(Name = "AwayPointSpreadPayout", Order = 12)]
        public int? AwayPointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's total points scored over under for the game
        /// </summary>
        [Description("The sportsbook's total points scored over under for the game")]
        [DataMember(Name = "OverUnder", Order = 13)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over
        /// </summary>
        [Description("The sportsbook's payout for the over")]
        [DataMember(Name = "OverPayout", Order = 14)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 15)]
        public int? UnderPayout { get; set; }

    }
}

