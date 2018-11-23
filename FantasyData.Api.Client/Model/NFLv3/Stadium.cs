using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3
{
    [DataContract(Namespace="", Name="Stadium")]
    [Serializable]
    public partial class Stadium
    {
        /// <summary>
        /// The unique ID of the stadium
        /// </summary>
        [Description("The unique ID of the stadium")]
        [DataMember(Name = "StadiumID", Order = 1)]
        public int StadiumID { get; set; }

        /// <summary>
        /// The full name of the stadium
        /// </summary>
        [Description("The full name of the stadium")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The city where the stadium is located
        /// </summary>
        [Description("The city where the stadium is located")]
        [DataMember(Name = "City", Order = 3)]
        public string City { get; set; }

        /// <summary>
        /// The US state where the stadium is located (if Stadium is outside US, this value is NULL)
        /// </summary>
        [Description("The US state where the stadium is located (if Stadium is outside US, this value is NULL)")]
        [DataMember(Name = "State", Order = 4)]
        public string State { get; set; }

        /// <summary>
        /// The 2-digit country code where the stadium is located
        /// </summary>
        [Description("The 2-digit country code where the stadium is located")]
        [DataMember(Name = "Country", Order = 5)]
        public string Country { get; set; }

        /// <summary>
        /// The estimated seating capacity of the stadium
        /// </summary>
        [Description("The estimated seating capacity of the stadium")]
        [DataMember(Name = "Capacity", Order = 6)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The playing surface of the stadium (Grass, Artificial or Dome)
        /// </summary>
        [Description("The playing surface of the stadium (Grass, Artificial or Dome)")]
        [DataMember(Name = "PlayingSurface", Order = 7)]
        public string PlayingSurface { get; set; }

        /// <summary>
        /// The geographic latitude coordinate of this venue.
        /// </summary>
        [Description("The geographic latitude coordinate of this venue.")]
        [DataMember(Name = "GeoLat", Order = 8)]
        public decimal? GeoLat { get; set; }

        /// <summary>
        /// The geographic longitude coordinate of this venue.
        /// </summary>
        [Description("The geographic longitude coordinate of this venue.")]
        [DataMember(Name = "GeoLong", Order = 9)]
        public decimal? GeoLong { get; set; }

        /// <summary>
        /// The type of the stadium (possible values: Outdoor, Dome, RetractableDome)
        /// </summary>
        [Description("The type of the stadium (possible values: Outdoor, Dome, RetractableDome)")]
        [DataMember(Name = "Type", Order = 10)]
        public string Type { get; set; }

    }
}

