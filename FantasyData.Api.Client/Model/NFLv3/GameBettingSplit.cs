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
        /// Unique ID of the score/game
        /// </summary>
        [Description("Unique ID of the score/game")]
        [DataMember(Name = "ScoreId", Order = 1)]
        public int ScoreId { get; set; }

        /// <summary>
        /// A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks
        /// </summary>
        [Description("A 9 digit unique code identifying the game that this record corresponds to. The GameID is composed of Season; SeasonType; Week and HomeTeam. Note: This value will be NULL for bye weeks")]
        [DataMember(Name = "GameKey", Order = 2)]
        public string GameKey { get; set; }

        /// <summary>
        /// The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).
        /// </summary>
        [Description("The type of season that this game corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=All-Star).")]
        [DataMember(Name = "SeasonType", Order = 3)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The season of the score
        /// </summary>
        [Description("The season of the score")]
        [DataMember(Name = "Season", Order = 4)]
        public int Season { get; set; }

        /// <summary>
        /// The NFL week associated with this betting split (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have 3 preseason weeks
        /// </summary>
        [Description("The NFL week associated with this betting split (regular season: 1 to 18; preseason: 0 to 4; postseason: 1 to 4). Note: seasons after 2021 will have 3 preseason weeks")]
        [DataMember(Name = "Week", Order = 5)]
        public int Week { get; set; }

        /// <summary>
        /// The date and time of the game (in US Eastern Time)
        /// </summary>
        [Description("The date and time of the game (in US Eastern Time)")]
        [DataMember(Name = "Date", Order = 6)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The abbreviation [Key} of the away team
        /// </summary>
        [Description("The abbreviation [Key} of the away team")]
        [DataMember(Name = "AwayTeam", Order = 7)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 8)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Shows the Market Types that have splits included for them in a given game
        /// </summary>
        [Description("Shows the Market Types that have splits included for them in a given game")]
        [DataMember(Name = "BettingMarketSplits", Order = 20009)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

