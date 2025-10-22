﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
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
        /// Whether or not this stadium is the home venue for an active team. Note: Active = True & Inactive = False
        /// </summary>
        [Description("Whether or not this stadium is the home venue for an active team. Note: Active = True & Inactive = False")]
        [DataMember(Name = "Active", Order = 2)]
        public bool Active { get; set; }

        /// <summary>
        /// The full name of the stadium
        /// </summary>
        [Description("The full name of the stadium")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The address where the stadium is located (street name). Note: some stadiums will not have an address field
        /// </summary>
        [Description("The address where the stadium is located (street name). Note: some stadiums will not have an address field")]
        [DataMember(Name = "Address", Order = 4)]
        public string Address { get; set; }

        /// <summary>
        /// The city where the stadium is located
        /// </summary>
        [Description("The city where the stadium is located")]
        [DataMember(Name = "City", Order = 5)]
        public string City { get; set; }

        /// <summary>
        /// The US state where the stadium is located. Note: if Stadium is outside US; this value is NULL
        /// </summary>
        [Description("The US state where the stadium is located. Note: if Stadium is outside US; this value is NULL")]
        [DataMember(Name = "State", Order = 6)]
        public string State { get; set; }

        /// <summary>
        /// The zip code of the stadium
        /// </summary>
        [Description("The zip code of the stadium")]
        [DataMember(Name = "Zip", Order = 7)]
        public string Zip { get; set; }

        /// <summary>
        /// The 3-letter country abbreviation where the stadium is located
        /// </summary>
        [Description("The 3-letter country abbreviation where the stadium is located")]
        [DataMember(Name = "Country", Order = 8)]
        public string Country { get; set; }

        /// <summary>
        /// The estimated seating capacity of the stadium
        /// </summary>
        [Description("The estimated seating capacity of the stadium")]
        [DataMember(Name = "Capacity", Order = 9)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The geographic latitude coordinate of this venue.
        /// </summary>
        [Description("The geographic latitude coordinate of this venue.")]
        [DataMember(Name = "GeoLat", Order = 10)]
        public decimal? GeoLat { get; set; }

        /// <summary>
        /// The geographic longitude coordinate of this venue.
        /// </summary>
        [Description("The geographic longitude coordinate of this venue.")]
        [DataMember(Name = "GeoLong", Order = 11)]
        public decimal? GeoLong { get; set; }

    }
}

