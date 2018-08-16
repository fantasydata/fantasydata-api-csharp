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
        /// The unique ID of the player season record
        /// </summary>
        [Description("The unique ID of the player season record")]
        [DataMember(Name = "PlayerSeasonID", Order = 1)]
        public int PlayerSeasonID { get; set; }

        /// <summary>
        /// The PGA season for which this record applies
        /// </summary>
        [Description("The PGA season for which this record applies")]
        [DataMember(Name = "Season", Order = 2)]
        public int Season { get; set; }

        /// <summary>
        /// Unique ID assigned to each player that stays with them throughout their career
        /// </summary>
        [Description("Unique ID assigned to each player that stays with them throughout their career")]
        [DataMember(Name = "PlayerID", Order = 3)]
        public int PlayerID { get; set; }

        /// <summary>
        /// Player's name
        /// </summary>
        [Description("Player's name")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The player's latest world golf ranking
        /// </summary>
        [Description("The player's latest world golf ranking")]
        [DataMember(Name = "WorldGolfRank", Order = 5)]
        public int? WorldGolfRank { get; set; }

        /// <summary>
        /// The player's world golf ranking from the previous week
        /// </summary>
        [Description("The player's world golf ranking from the previous week")]
        [DataMember(Name = "WorldGolfRankLastWeek", Order = 6)]
        public int? WorldGolfRankLastWeek { get; set; }

        /// <summary>
        /// The total number of tournaments this player competed in during this season
        /// </summary>
        [Description("The total number of tournaments this player competed in during this season")]
        [DataMember(Name = "Events", Order = 7)]
        public int? Events { get; set; }

        /// <summary>
        /// Average points scored on tournaments during this season
        /// </summary>
        [Description("Average points scored on tournaments during this season")]
        [DataMember(Name = "AveragePoints", Order = 8)]
        public decimal? AveragePoints { get; set; }

        /// <summary>
        /// Total points scored on tournaments during this season
        /// </summary>
        [Description("Total points scored on tournaments during this season")]
        [DataMember(Name = "TotalPoints", Order = 9)]
        public decimal? TotalPoints { get; set; }

        /// <summary>
        /// Total points lost
        /// </summary>
        [Description("Total points lost")]
        [DataMember(Name = "PointsLost", Order = 10)]
        public decimal? PointsLost { get; set; }

        /// <summary>
        /// Total points gained
        /// </summary>
        [Description("Total points gained")]
        [DataMember(Name = "PointsGained", Order = 11)]
        public decimal? PointsGained { get; set; }

    }
}

