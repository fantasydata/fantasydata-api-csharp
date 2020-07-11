using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Csgo
{
    [DataContract(Namespace="", Name="Venue")]
    [Serializable]
    public partial class Venue
    {
        /// <summary>
        /// The unique ID of the venue
        /// </summary>
        [Description("The unique ID of the venue")]
        [DataMember(Name = "VenueId", Order = 1)]
        public int VenueId { get; set; }

        /// <summary>
        /// The full name of the venue
        /// </summary>
        [Description("The full name of the venue")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The address where the venue is located
        /// </summary>
        [Description("The address where the venue is located")]
        [DataMember(Name = "Address", Order = 3)]
        public string Address { get; set; }

        /// <summary>
        /// The city where the venue is located
        /// </summary>
        [Description("The city where the venue is located")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The zip code of the venue
        /// </summary>
        [Description("The zip code of the venue")]
        [DataMember(Name = "Zip", Order = 5)]
        public string Zip { get; set; }

        /// <summary>
        /// The 2-digit country code where the venue is located
        /// </summary>
        [Description("The 2-digit country code where the venue is located")]
        [DataMember(Name = "Country", Order = 6)]
        public string Country { get; set; }

        /// <summary>
        /// Indicates whether this venue is actively used
        /// </summary>
        [Description("Indicates whether this venue is actively used")]
        [DataMember(Name = "Open", Order = 7)]
        public bool Open { get; set; }

        /// <summary>
        /// The year the venue opened
        /// </summary>
        [Description("The year the venue opened")]
        [DataMember(Name = "Opened", Order = 8)]
        public int? Opened { get; set; }

        /// <summary>
        /// A nickname for this venue
        /// </summary>
        [Description("A nickname for this venue")]
        [DataMember(Name = "Nickname1", Order = 9)]
        public string Nickname1 { get; set; }

        /// <summary>
        /// A nickname for this venue
        /// </summary>
        [Description("A nickname for this venue")]
        [DataMember(Name = "Nickname2", Order = 10)]
        public string Nickname2 { get; set; }

        /// <summary>
        /// The estimated seating capacity of the venue
        /// </summary>
        [Description("The estimated seating capacity of the venue")]
        [DataMember(Name = "Capacity", Order = 11)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The geographic latitude coordinate of this venue.
        /// </summary>
        [Description("The geographic latitude coordinate of this venue.")]
        [DataMember(Name = "GeoLat", Order = 12)]
        public decimal? GeoLat { get; set; }

        /// <summary>
        /// The geographic longitude coordinate of this venue.
        /// </summary>
        [Description("The geographic longitude coordinate of this venue.")]
        [DataMember(Name = "GeoLong", Order = 13)]
        public decimal? GeoLong { get; set; }

    }
}

