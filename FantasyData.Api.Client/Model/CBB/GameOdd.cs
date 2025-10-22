using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
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
        /// The name of the sportsbook
        /// </summary>
        [Description("The name of the sportsbook")]
        [DataMember(Name = "Sportsbook", Order = 2)]
        public string Sportsbook { get; set; }

        /// <summary>
        /// The unique ID of this game
        /// </summary>
        [Description("The unique ID of this game")]
        [DataMember(Name = "GameId", Order = 3)]
        public int GameId { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first created (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when these odds were first created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 4)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when these odds were last updated; based on US Eastern Time. If these are the latest odds for this game; and they have not been updated within the last few minutes; then it indicates that there were problems connecting to the sportsbook.
        /// </summary>
        [Description("The timestamp of when these odds were last updated; based on US Eastern Time. If these are the latest odds for this game; and they have not been updated within the last few minutes; then it indicates that there were problems connecting to the sportsbook.")]
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
        /// The sportsbook's point spread payout for the away team. Note: this line is a consensus.
        /// </summary>
        [Description("The sportsbook's point spread payout for the away team. Note: this line is a consensus.")]
        [DataMember(Name = "AwayPointSpreadPayout", Order = 11)]
        public int? AwayPointSpreadPayout { get; set; }

        /// <summary>
        /// The total points line (over/under) as given by the sportsbook
        /// </summary>
        [Description("The total points line (over/under) as given by the sportsbook")]
        [DataMember(Name = "OverUnder", Order = 12)]
        public decimal? OverUnder { get; set; }

        /// <summary>
        /// The odds at which the sportsbook will pay out winning Over bets at
        /// </summary>
        [Description("The odds at which the sportsbook will pay out winning Over bets at")]
        [DataMember(Name = "OverPayout", Order = 13)]
        public int? OverPayout { get; set; }

        /// <summary>
        /// The sportsbook's payout for the under
        /// </summary>
        [Description("The sportsbook's payout for the under")]
        [DataMember(Name = "UnderPayout", Order = 14)]
        public int? UnderPayout { get; set; }

        /// <summary>
        /// The unique ID associated with this sportsbook
        /// </summary>
        [Description("The unique ID associated with this sportsbook")]
        [DataMember(Name = "SportsbookId", Order = 15)]
        public int? SportsbookId { get; set; }

        /// <summary>
        /// The market type of the odd (ex: live; pregame; 1st-half; etc.)
        /// </summary>
        [Description("The market type of the odd (ex: live; pregame; 1st-half; etc.)")]
        [DataMember(Name = "OddType", Order = 16)]
        public string OddType { get; set; }

        /// <summary>
        /// The URL for sportsbook event
        /// </summary>
        [Description("The URL for sportsbook event")]
        [DataMember(Name = "SportsbookUrl", Order = 17)]
        public string SportsbookUrl { get; set; }

        /// <summary>
        /// The timestamp of when these odds were first made unavailable to be bet on any further
        /// </summary>
        [Description("The timestamp of when these odds were first made unavailable to be bet on any further")]
        [DataMember(Name = "Unlisted", Order = 18)]
        public DateTime? Unlisted { get; set; }

    }
}

