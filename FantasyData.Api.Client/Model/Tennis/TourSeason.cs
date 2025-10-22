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
        /// The unique ID of tour season
        /// </summary>
        [Description("The unique ID of tour season")]
        [DataMember(Name = "TourSeasonId", Order = 1)]
        public int TourSeasonId { get; set; }

        /// <summary>
        /// The unique ID of the tour
        /// </summary>
        [Description("The unique ID of the tour")]
        [DataMember(Name = "TourId", Order = 2)]
        public int TourId { get; set; }

        /// <summary>
        /// The year in which the tour season takes place
        /// </summary>
        [Description("The year in which the tour season takes place")]
        [DataMember(Name = "Year", Order = 3)]
        public int? Year { get; set; }

    }
}

