﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
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
        /// The unique ID of the game
        /// </summary>
        [Description("The unique ID of the game")]
        [DataMember(Name = "GameId", Order = 3)]
        public int GameId { get; set; }

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

        /// <summary>
        /// Unique ID of the sportsbook
        /// </summary>
        [Description("Unique ID of the sportsbook")]
        [DataMember(Name = "SportsbookId", Order = 16)]
        public int? SportsbookId { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 17)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// The sportsbook's asian handicap for the home team
        /// </summary>
        [Description("The sportsbook's asian handicap for the home team")]
        [DataMember(Name = "HomeTeamAsianHandicap", Order = 18)]
        public decimal? HomeTeamAsianHandicap { get; set; }

        /// <summary>
        /// The sportsbook's asian handicap for the away team
        /// </summary>
        [Description("The sportsbook's asian handicap for the away team")]
        [DataMember(Name = "AwayTeamAsianHandicap", Order = 19)]
        public decimal? AwayTeamAsianHandicap { get; set; }

        /// <summary>
        /// The sportsbook's asian handicap payout for the home team covering
        /// </summary>
        [Description("The sportsbook's asian handicap payout for the home team covering")]
        [DataMember(Name = "HomeTeamAsianHandicapPayout", Order = 20)]
        public int? HomeTeamAsianHandicapPayout { get; set; }

        /// <summary>
        /// The sportsbook's asian handicap payout for the away team covering
        /// </summary>
        [Description("The sportsbook's asian handicap payout for the away team covering")]
        [DataMember(Name = "AwayTeamAsianHandicapPayout", Order = 21)]
        public int? AwayTeamAsianHandicapPayout { get; set; }

        /// <summary>
        /// The sportsbook's asian total for the game
        /// </summary>
        [Description("The sportsbook's asian total for the game")]
        [DataMember(Name = "AsianTotal", Order = 22)]
        public decimal? AsianTotal { get; set; }

        /// <summary>
        /// The sportsbook's payout for a result over the asian total
        /// </summary>
        [Description("The sportsbook's payout for a result over the asian total")]
        [DataMember(Name = "AsianTotalOverPayout", Order = 23)]
        public int? AsianTotalOverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for a result under the asian total
        /// </summary>
        [Description("The sportsbook's payout for a result under the asian total")]
        [DataMember(Name = "AsianTotalUnderPayout", Order = 24)]
        public int? AsianTotalUnderPayout { get; set; }

        /// <summary>
        /// The market type of the odd (ex:live, pregame)
        /// </summary>
        [Description("The market type of the odd (ex:live, pregame)")]
        [DataMember(Name = "OddType", Order = 25)]
        public string OddType { get; set; }

    }
}

