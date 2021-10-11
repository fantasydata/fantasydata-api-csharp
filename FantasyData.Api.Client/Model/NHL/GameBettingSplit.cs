using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="GameBettingSplit")]
    [Serializable]
    public partial class GameBettingSplit
    {
        /// <summary>
        /// Unique Game ID associated with relevant game.
        /// </summary>
        [Description("Unique Game ID associated with relevant game.")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// Season Type (e.g.  Preseason, Regular Season, Postseason)
        /// </summary>
        [Description("Season Type (e.g.  Preseason, Regular Season, Postseason)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// End Year of Season (2021-22 would be 2022)
        /// </summary>
        [Description("End Year of Season (2021-22 would be 2022)")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// Day of Game
        /// </summary>
        [Description("Day of Game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// Away Team
        /// </summary>
        [Description("Away Team")]
        [DataMember(Name = "AwayTeam", Order = 5)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// Home Team
        /// </summary>
        [Description("Home Team")]
        [DataMember(Name = "HomeTeam", Order = 6)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// The Betting Markets included in this game that have splits
        /// </summary>
        [Description("The Betting Markets included in this game that have splits")]
        [DataMember(Name = "BettingMarketSplits", Order = 20007)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

