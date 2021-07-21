using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="GameBettingSplit")]
    [Serializable]
    public partial class GameBettingSplit
    {
        /// <summary>
        /// The unique id of the score record
        /// </summary>
        [Description("The unique id of the score record")]
        [DataMember(Name = "ScoreId", Order = 1)]
        public int ScoreId { get; set; }

        /// <summary>
        /// The generated gamekey
        /// </summary>
        [Description("The generated gamekey")]
        [DataMember(Name = "GameKey", Order = 2)]
        public string GameKey { get; set; }

        /// <summary>
        /// The seasontype of the score
        /// </summary>
        [Description("The seasontype of the score")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The season of the score
        /// </summary>
        [Description("The season of the score")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The week of the score
        /// </summary>
        [Description("The week of the score")]
        [DataMember(Name = "Week", Order = 5)]
        public int Week { get; set; }

        /// <summary>
        /// The start time of the score
        /// </summary>
        [Description("The start time of the score")]
        [DataMember(Name = "Date", Order = 6)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The away team key
        /// </summary>
        [Description("The away team key")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The home team key
        /// </summary>
        [Description("The home team key")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The BettingMarkets included in this game that have splits
        /// </summary>
        [Description("The BettingMarkets included in this game that have splits")]
        [DataMember(Name = "BettingMarketSplits", Order = 20009)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

