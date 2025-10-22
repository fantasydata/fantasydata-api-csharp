using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="GameBettingSplit")]
    [Serializable]
    public partial class GameBettingSplit
    {
        /// <summary>
        /// The unique ID of this game associate with relevant game
        /// </summary>
        [Description("The unique ID of this game associate with relevant game")]
        [DataMember(Name = "GameID", Order = 1)]
        public int GameID { get; set; }

        /// <summary>
        /// The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar)
        /// </summary>
        [Description("The type of season that this record corresponds to (1=Regular Season; 2=Preseason; 3=Postseason; 4=Offseason; 5=AllStar)")]
        [DataMember(Name = "SeasonType", Order = 2)]
        public int SeasonType { get; set; }

        /// <summary>
        /// The season that this betting event occurs in. Note: season is a single year that the majority of the season occurs in.
        /// </summary>
        [Description("The season that this betting event occurs in. Note: season is a single year that the majority of the season occurs in.")]
        [DataMember(Name = "Season", Order = 3)]
        public int Season { get; set; }

        /// <summary>
        /// The day that the game is scheduled to be played in
        /// </summary>
        [Description("The day that the game is scheduled to be played in")]
        [DataMember(Name = "Day", Order = 4)]
        public DateTime? Day { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the away team
        /// </summary>
        [Description("The abbreviation [Key] of the away team")]
        [DataMember(Name = "AwayTeam", Order = 5)]
        public string AwayTeam { get; set; }

        /// <summary>
        /// The abbreviation [Key] of the home team tied to this betting split
        /// </summary>
        [Description("The abbreviation [Key] of the home team tied to this betting split")]
        [DataMember(Name = "HomeTeam", Order = 6)]
        public string HomeTeam { get; set; }

        /// <summary>
        /// Shows the Market Types that have splits included for them in a given game
        /// </summary>
        [Description("Shows the Market Types that have splits included for them in a given game")]
        [DataMember(Name = "BettingMarketSplits", Order = 20007)]
        public BettingMarketSplit[] BettingMarketSplits { get; set; }

    }
}

