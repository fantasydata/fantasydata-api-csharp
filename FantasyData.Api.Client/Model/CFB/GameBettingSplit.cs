using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CFB
{
    [DataContract(Namespace="", Name="GameBettingSplit")]
    [Serializable]
    public partial class GameBettingSplit
    {
        /// <summary>
        /// The unique ID of this game tied to this split
        /// </summary>
        [Description("The unique ID of this game tied to this split")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar).
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar).")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The college football season of the game
        /// </summary>
        [Description("The college football season of the game")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The week of the game related to this betting split
        /// </summary>
        [Description("The week of the game related to this betting split")]
        [DataMember(Name = "Week", Order = 4)]
        public int Week { get; set; }

        /// <summary>
        /// The date of the game
        /// </summary>
        [Description("The date of the game")]
        [DataMember(Name = "Day", Order = 5)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team tied to this split
        /// </summary>
        [Description("The abbreviation [Key] of the away team tied to this split")]
        [DataMember(Name = "AwayTeam", Order = 6)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team
        /// </summary>
        [Description("The abbreviation [Key] of the home team")]
        [DataMember(Name = "HomeTeam", Order = 7)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Shows the Market Types that have splits included for them in a given game
        /// </summary>
        [Description("Shows the Market Types that have splits included for them in a given game")]
        [DataMember(Name = "BettingMarketSplits", Order = 20008)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

