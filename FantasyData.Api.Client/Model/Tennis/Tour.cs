using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Tour")]
    [Serializable]
    public partial class Tour
    {
        /// <summary>
        /// The unique ID of the tour
        /// </summary>
        [Description("The unique ID of the tour")]
        [DataMember(Name = "TourId", Order = 1)]
        public int TourId { get; set; }

        /// <summary>
        /// The name of the tour
        /// </summary>
        [Description("The name of the tour")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Gender of players associated with this tour
        /// </summary>
        [Description("Gender of players associated with this tour")]
        [DataMember(Name = "Gender", Order = 3)]
        public string Gender { get; set; }

        /// <summary>
        /// Associated Tour Seasons
        /// </summary>
        [Description("Associated Tour Seasons")]
        [DataMember(Name = "TourSeasons", Order = 20004)]
        public TourSeason[] TourSeasons { get; set; }

    }
}

