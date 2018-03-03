using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
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
        /// Whether or not this stadium is the home venue for an active team
        /// </summary>
        [Description("Whether or not this stadium is the home venue for an active team")]
        [DataMember(Name = "Active", Order = 2)]
        public bool Active { get; set; }

        /// <summary>
        /// The full name of the stadium
        /// </summary>
        [Description("The full name of the stadium")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// The city where the stadium is located
        /// </summary>
        [Description("The city where the stadium is located")]
        [DataMember(Name = "City", Order = 4)]
        public string City { get; set; }

        /// <summary>
        /// The US state where the stadium is located (if Stadium is outside US, this value is NULL)
        /// </summary>
        [Description("The US state where the stadium is located (if Stadium is outside US, this value is NULL)")]
        [DataMember(Name = "State", Order = 5)]
        public string State { get; set; }

        /// <summary>
        /// The 2-digit country code where the stadium is located
        /// </summary>
        [Description("The 2-digit country code where the stadium is located")]
        [DataMember(Name = "Country", Order = 6)]
        public string Country { get; set; }

        /// <summary>
        /// The estimated seating capacity of the stadium
        /// </summary>
        [Description("The estimated seating capacity of the stadium")]
        [DataMember(Name = "Capacity", Order = 7)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The playing surface of the stadium (Grass, Artificial or Dome)
        /// </summary>
        [Description("The playing surface of the stadium (Grass, Artificial or Dome)")]
        [DataMember(Name = "Surface", Order = 8)]
        public string Surface { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the left field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the left field wall.")]
        [DataMember(Name = "LeftField", Order = 9)]
        public int? LeftField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the mid left field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the mid left field wall.")]
        [DataMember(Name = "MidLeftField", Order = 10)]
        public int? MidLeftField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the left center field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the left center field wall.")]
        [DataMember(Name = "LeftCenterField", Order = 11)]
        public int? LeftCenterField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the mid left center field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the mid left center field wall.")]
        [DataMember(Name = "MidLeftCenterField", Order = 12)]
        public int? MidLeftCenterField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the center field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the center field wall.")]
        [DataMember(Name = "CenterField", Order = 13)]
        public int? CenterField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the mid right center field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the mid right center field wall.")]
        [DataMember(Name = "MidRightCenterField", Order = 14)]
        public int? MidRightCenterField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the right center field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the right center field wall.")]
        [DataMember(Name = "RightCenterField", Order = 15)]
        public int? RightCenterField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the mid right field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the mid right field wall.")]
        [DataMember(Name = "MidRightField", Order = 16)]
        public int? MidRightField { get; set; }

        /// <summary>
        /// The estimated distance between home plate and the right field wall.
        /// </summary>
        [Description("The estimated distance between home plate and the right field wall.")]
        [DataMember(Name = "RightField", Order = 17)]
        public int? RightField { get; set; }

        /// <summary>
        /// The geographic latitude coordinate of this venue.
        /// </summary>
        [Description("The geographic latitude coordinate of this venue.")]
        [DataMember(Name = "GeoLat", Order = 18)]
        public decimal? GeoLat { get; set; }

        /// <summary>
        /// The geographic longitude coordinate of this venue.
        /// </summary>
        [Description("The geographic longitude coordinate of this venue.")]
        [DataMember(Name = "GeoLong", Order = 19)]
        public decimal? GeoLong { get; set; }

        /// <summary>
        /// The altitude of the stadium in feet.
        /// </summary>
        [Description("The altitude of the stadium in feet.")]
        [DataMember(Name = "Altitude", Order = 20)]
        public int? Altitude { get; set; }

        /// <summary>
        /// The direction that the batter is facing while looking at the pitcher's mound. For instance, 90 means that the line from home plate through 2nd base is pointing east. 180 means that the line is pointing north … and so on.
        /// </summary>
        [Description("The direction that the batter is facing while looking at the pitcher's mound. For instance, 90 means that the line from home plate through 2nd base is pointing east. 180 means that the line is pointing north … and so on.")]
        [DataMember(Name = "HomePlateDirection", Order = 21)]
        public int? HomePlateDirection { get; set; }

        /// <summary>
        /// The type of the stadium (possible values: Outdoor, Dome, RetractableDome)
        /// </summary>
        [Description("The type of the stadium (possible values: Outdoor, Dome, RetractableDome)")]
        [DataMember(Name = "Type", Order = 22)]
        public string Type { get; set; }

    }
}

