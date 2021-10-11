using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="GameBettingSplit")]
    [Serializable]
    public partial class GameBettingSplit
    {
        /// <summary>
        /// The unique id of the game record
        /// </summary>
        [Description("The unique id of the game record")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The seasontype of the game
        /// </summary>
        [Description("The seasontype of the game")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The season of the game
        /// </summary>
        [Description("The season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The start time of the game
        /// </summary>
        [Description("The start time of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The away team key
        /// </summary>
        [Description("The away team key")]
        [DataMember(Name = "AwayTeam", Order = 5)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The home team key
        /// </summary>
        [Description("The home team key")]
        [DataMember(Name = "HomeTeam", Order = 6)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The BettingMarkets included in this game that have splits
        /// </summary>
        [Description("The BettingMarkets included in this game that have splits")]
        [DataMember(Name = "BettingMarketSplits", Order = 20007)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

