using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="GameOdd")]
    [Serializable]
    public partial class GameOdd
    {
        /// <summary>
        /// The unique ID of this odd
        /// </summary>
        [Description("The unique ID of this odd")]
        [DataMember(Name = "GameOddID", Order = 1)]
        public int GameOddID { get; set; }

        /// <summary>
        /// Name of sportsbook
        /// </summary>
        [Description("Name of sportsbook")]
        [DataMember(Name = "Sportsbook", Order = 2)]
        public string Sportsbook { get; set; }

        /// <summary>
        /// Unique ID of the Sportsbook
        /// </summary>
        [Description("Unique ID of the Sportsbook")]
        [DataMember(Name = "SportsbookID", Order = 3)]
        public int SportsbookID { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameID", Order = 4)]
        public int GameID { get; set; }

        /// <summary>
        /// The market type of the odd (ex: live, pregame, 1st-half, 2nd-quarter)
        /// </summary>
        [Description("The market type of the odd (ex: live, pregame, 1st-half, 2nd-quarter)")]
        [DataMember(Name = "OddType", Order = 5)]
        public string OddType { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first created in US Eastern Time
        /// </summary>
        [Description("The timestamp of when these odds were first created in US Eastern Time")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The timestamp of when this record was last updated (in US Eastern time)
        /// </summary>
        [Description("The timestamp of when this record was last updated (in US Eastern time)")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The URL for the sportsbook event
        /// </summary>
        [Description("The URL for the sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 8)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// The sportsbook's money line for the home team
        /// </summary>
        [Description("The sportsbook's money line for the home team")]
        [DataMember(Name = "HomeMoneyLine", Order = 9)]
        public int? HomeMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's money line for the away team
        /// </summary>
        [Description("The sportsbook's money line for the away team")]
        [DataMember(Name = "AwayMoneyLine", Order = 10)]
        public int? AwayMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's point spread for the home team
        /// </summary>
        [Description("The sportsbook's point spread for the home team")]
        [DataMember(Name = "HomePointSpread", Order = 11)]
        public decimal? HomePointSpread { get; set; }

        /// <summary>
        /// The sportsbook's point spread for the away team
        /// </summary>
        [Description("The sportsbook's point spread for the away team")]
        [DataMember(Name = "AwayPointSpread", Order = 12)]
        public decimal? AwayPointSpread { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the home team
        /// </summary>
        [Description("The sportsbook's point spread payout for the home team")]
        [DataMember(Name = "HomePointSpreadPayout", Order = 13)]
        public int? HomePointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's point spread payout for the away team
        /// </summary>
        [Description("The sportsbook's point spread payout for the away team")]
        [DataMember(Name = "AwayPointSpreadPayout", Order = 14)]
        public int? AwayPointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's total points scored over or under for the game. Note: this is also known as the Total for the game.
        /// </summary>
        [Description("The sportsbook's total points scored over or under for the game. Note: this is also known as the Total for the game.")]
        [DataMember(Name = "OverUnder", Order = 15)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over
        /// </summary>
        [Description("The sportsbook's payout for the over")]
        [DataMember(Name = "OverPayout", Order = 16)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 17)]
        public int? UnderPayout { get; set; }

    }
}

