using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
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
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 3)]
        public int GameId { get; set; }

        /// <summary>
        /// The date and time when these odds were first created in US Eastern Time
        /// </summary>
        [Description("The date and time when these odds were first created in US Eastern Time")]
        [DataMember(Name = "Created", Order = 4)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date and time of when these odds were last updated (in US Eatern Time) If these are the latest odds for this game; and they have not been updated within the last few minutes; then it indicates that there were problems connecting to the sportsbook.
        /// </summary>
        [Description("The date and time of when these odds were last updated (in US Eatern Time) If these are the latest odds for this game; and they have not been updated within the last few minutes; then it indicates that there were problems connecting to the sportsbook.")]
        [DataMember(Name = "Updated", Order = 5)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// The sportsbook's moneyline for the home team
        /// </summary>
        [Description("The sportsbook's moneyline for the home team")]
        [DataMember(Name = "HomeMoneyLine", Order = 6)]
        public int? HomeMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's moneyline for the away team
        /// </summary>
        [Description("The sportsbook's moneyline for the away team")]
        [DataMember(Name = "AwayMoneyLine", Order = 7)]
        public int? AwayMoneyLine { get; set; }

        /// <summary>
        /// The sportsbook's run line for the home team
        /// </summary>
        [Description("The sportsbook's run line for the home team")]
        [DataMember(Name = "HomePointSpread", Order = 8)]
        public decimal? HomePointSpread { get; set; }

        /// <summary>
        /// The sportsbook's run line for the away team
        /// </summary>
        [Description("The sportsbook's run line for the away team")]
        [DataMember(Name = "AwayPointSpread", Order = 9)]
        public decimal? AwayPointSpread { get; set; }

        /// <summary>
        /// The sportsbook's run line payout for the home team
        /// </summary>
        [Description("The sportsbook's run line payout for the home team")]
        [DataMember(Name = "HomePointSpreadPayout", Order = 10)]
        public int? HomePointSpreadPayout { get; set; }

        /// <summary>
        /// The sportsbook's run line payout for the away team
        /// </summary>
        [Description("The sportsbook's run line payout for the away team")]
        [DataMember(Name = "AwayPointSpreadPayout", Order = 11)]
        public int? AwayPointSpreadPayout { get; set; }

        /// <summary>
        /// The total points line as given by the sportsbook
        /// </summary>
        [Description("The total points line as given by the sportsbook")]
        [DataMember(Name = "OverUnder", Order = 12)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The sportsbook's payout for the over
        /// </summary>
        [Description("The sportsbook's payout for the over")]
        [DataMember(Name = "OverPayout", Order = 13)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 14)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// Unique ID of the sportsbook
        /// </summary>
        [Description("Unique ID of the sportsbook")]
        [DataMember(Name = "SportsbookId", Order = 15)]
        public int? SportsbookId { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 16)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// The market type of the odd (ex: live; pregame; 1st inning; etc)
        /// </summary>
        [Description("The market type of the odd (ex: live; pregame; 1st inning; etc)")]
        [DataMember(Name = "OddType", Order = 17)]
        public string OddType { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first made unavailable to be bet on any further (In US Eastern Time)
        /// </summary>
        [Description("The timestamp of when these odds were first made unavailable to be bet on any further (In US Eastern Time)")]
        [DataMember(Name = "Unlisted", Order = 18)]
        public DateTime? Unlisted { get; set; }

    }
}

