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
        /// The unique ID of the game tied to the BettingSplits
        /// </summary>
        [Description("The unique ID of the game tied to the BettingSplits")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The MLB season of the betting split
        /// </summary>
        [Description("The MLB season of the betting split")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The day of the game
        /// </summary>
        [Description("The day of the game")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 5)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the Home Team
        /// </summary>
        [Description("The abbreviation [Key] of the Home Team")]
        [DataMember(Name = "HomeTeam", Order = 6)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Shows the BettingMarkets that have splits included for them in a given game
        /// </summary>
        [Description("Shows the BettingMarkets that have splits included for them in a given game")]
        [DataMember(Name = "BettingMarketSplits", Order = 20007)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

