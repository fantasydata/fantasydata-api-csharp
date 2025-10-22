using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="PlayerSeason")]
    [Serializable]
    public partial class PlayerSeason
    {
        /// <summary>
        /// The unique ID of the golfer season record
        /// </summary>
        [Description("The unique ID of the golfer season record")]
        [DataMember(Name = "PlayerSeasonID", Order = 1)]
        public int PlayerSeasonID { get; set; }

        /// <summary>
        /// The PGA season for which this record applies
        /// </summary>
        [Description("The PGA season for which this record applies")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// The unique ID of the golfer
        /// </summary>
        [Description("The unique ID of the golfer")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        /// <summary>
        /// The full name of the golfer
        /// </summary>
        [Description("The full name of the golfer")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The player's latest World Golf Ranking
        /// </summary>
        [Description("The player's latest World Golf Ranking")]
        [DataMember(Name = "WorldGolfRank", Order = 5)]
        public int? WorldGolfRank { get; set; }

        /// <summary>
        /// The player's World Golf Ranking from the previous week
        /// </summary>
        [Description("The player's World Golf Ranking from the previous week")]
        [DataMember(Name = "WorldGolfRankLastWeek", Order = 6)]
        public int? WorldGolfRankLastWeek { get; set; }

        /// <summary>
        /// The total number of tournaments the player competed in during the season
        /// </summary>
        [Description("The total number of tournaments the player competed in during the season")]
        [DataMember(Name = "Events", Order = 7)]
        public int? Events { get; set; }

        /// <summary>
        /// The total Average World Golf Ranking points scored on tournaments during this season
        /// </summary>
        [Description("The total Average World Golf Ranking points scored on tournaments during this season")]
        [DataMember(Name = "AveragePoints", Order = 8)]
        public decimal? AveragePoints { get; set; }

        /// <summary>
        /// Total World Golf Ranking points scored on tournaments during this season
        /// </summary>
        [Description("Total World Golf Ranking points scored on tournaments during this season")]
        [DataMember(Name = "TotalPoints", Order = 9)]
        public decimal? TotalPoints { get; set; }

        /// <summary>
        /// Total World Golf Ranking points lost after the golfers most recent performance
        /// </summary>
        [Description("Total World Golf Ranking points lost after the golfers most recent performance")]
        [DataMember(Name = "PointsLost", Order = 10)]
        public decimal? PointsLost { get; set; }

        /// <summary>
        /// Total World Golf Ranking points gained after the golfers most recent performance
        /// </summary>
        [Description("Total World Golf Ranking points gained after the golfers most recent performance")]
        [DataMember(Name = "PointsGained", Order = 11)]
        public decimal? PointsGained { get; set; }

    }
}

