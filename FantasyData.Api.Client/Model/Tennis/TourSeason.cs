using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="TourSeason")]
    [Serializable]
    public partial class TourSeason
    {
        /// <summary>
        /// Unique ID of Tour Season.
        /// </summary>
        [Description("Unique ID of Tour Season.")]
        [DataMember(Name = "TourSeasonId", Order = 1)]
        public int TourSeasonId { get; set; }

        /// <summary>
        /// ID of associated Tour.
        /// </summary>
        [Description("ID of associated Tour.")]
        [DataMember(Name = "TourId", Order = 2)]
        public int TourId { get; set; }

        /// <summary>
        /// Year of Tour Season.
        /// </summary>
        [Description("Year of Tour Season.")]
        [DataMember(Name = "Year", Order = 3)]
        public int? Year { get; set; }

    }
}

