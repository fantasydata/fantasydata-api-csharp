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
        /// Unique ID of Tour
        /// </summary>
        [Description("Unique ID of Tour")]
        [DataMember(Name = "TourId", Order = 1)]
        public int TourId { get; set; }

        /// <summary>
        /// Name of Tour
        /// </summary>
        [Description("Name of Tour")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Gender of Tour
        /// </summary>
        [Description("Gender of Tour")]
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

