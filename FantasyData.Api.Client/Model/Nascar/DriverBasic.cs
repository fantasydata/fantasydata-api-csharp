﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="DriverBasic")]
    [Serializable]
    public partial class DriverBasic
    {
        /// <summary>
        /// The unique ID of this driver (assigned by SportsDataIO)
        /// </summary>
        [Description("The unique ID of this driver (assigned by SportsDataIO)")]
        [DataMember(Name = "DriverID", Order = 1)]
        public int DriverID { get; set; }

        /// <summary>
        /// The driver's first name
        /// </summary>
        [Description("The driver's first name")]
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        /// <summary>
        /// The driver's last name
        /// </summary>
        [Description("The driver's last name")]
        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        /// <summary>
        /// The driver's car number
        /// </summary>
        [Description("The driver's car number")]
        [DataMember(Name = "Number", Order = 4)]
        public int? Number { get; set; }

        /// <summary>
        /// The driver's car number for display purposes (with leading zeros when necessary)
        /// </summary>
        [Description("The driver's car number for display purposes (with leading zeros when necessary)")]
        [DataMember(Name = "NumberDisplay", Order = 5)]
        public string NumberDisplay { get; set; }

        /// <summary>
        /// The driver's team name
        /// </summary>
        [Description("The driver's team name")]
        [DataMember(Name = "Team", Order = 6)]
        public string Team { get; set; }

        /// <summary>
        /// The driver's birth date
        /// </summary>
        [Description("The driver's birth date")]
        [DataMember(Name = "BirthDate", Order = 7)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The driver's birth place
        /// </summary>
        [Description("The driver's birth place")]
        [DataMember(Name = "BirthPlace", Order = 8)]
        public string BirthPlace { get; set; }

        /// <summary>
        /// The driver's gender
        /// </summary>
        [Description("The driver's gender")]
        [DataMember(Name = "Gender", Order = 9)]
        public string Gender { get; set; }

        /// <summary>
        /// The driver's height
        /// </summary>
        [Description("The driver's height")]
        [DataMember(Name = "Height", Order = 10)]
        public int? Height { get; set; }

        /// <summary>
        /// The driver's weight
        /// </summary>
        [Description("The driver's weight")]
        [DataMember(Name = "Weight", Order = 11)]
        public int? Weight { get; set; }

        /// <summary>
        /// The manufacturer of the driver's car
        /// </summary>
        [Description("The manufacturer of the driver's car")]
        [DataMember(Name = "Manufacturer", Order = 12)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The engine type of the driver's car
        /// </summary>
        [Description("The engine type of the driver's car")]
        [DataMember(Name = "Engine", Order = 13)]
        public string Engine { get; set; }

        /// <summary>
        /// The chassis of the driver's car
        /// </summary>
        [Description("The chassis of the driver's car")]
        [DataMember(Name = "Chassis", Order = 14)]
        public string Chassis { get; set; }

        /// <summary>
        /// The names of the sponsor(s) of the driver
        /// </summary>
        [Description("The names of the sponsor(s) of the driver")]
        [DataMember(Name = "Sponsors", Order = 15)]
        public string Sponsors { get; set; }

        /// <summary>
        /// The name of the crew chief for the driver
        /// </summary>
        [Description("The name of the crew chief for the driver")]
        [DataMember(Name = "CrewChief", Order = 16)]
        public string CrewChief { get; set; }

        /// <summary>
        /// The date/time when this driver was last updated
        /// </summary>
        [Description("The date/time when this driver was last updated")]
        [DataMember(Name = "Updated", Order = 17)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date/time when this driver was created
        /// </summary>
        [Description("The date/time when this driver was created")]
        [DataMember(Name = "Created", Order = 18)]
        public DateTime? Created { get; set; }

    }
}

