using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Driver")]
    [Serializable]
    public partial class Driver
    {
        [DataMember(Name = "DriverID", Order = 1)]
        public int DriverID { get; set; }

        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }

        [DataMember(Name = "LastName", Order = 3)]
        public string LastName { get; set; }

        [DataMember(Name = "Number", Order = 4)]
        public int? Number { get; set; }

        [DataMember(Name = "Team", Order = 5)]
        public string Team { get; set; }

        [DataMember(Name = "BirthDate", Order = 6)]
        public DateTime? BirthDate { get; set; }

        [DataMember(Name = "BirthPlace", Order = 7)]
        public string BirthPlace { get; set; }

        [DataMember(Name = "Gender", Order = 8)]
        public string Gender { get; set; }

        [DataMember(Name = "Height", Order = 9)]
        public int? Height { get; set; }

        [DataMember(Name = "Weight", Order = 10)]
        public int? Weight { get; set; }

        [DataMember(Name = "Manufacturer", Order = 11)]
        public string Manufacturer { get; set; }

        [DataMember(Name = "Engine", Order = 12)]
        public string Engine { get; set; }

        [DataMember(Name = "Chassis", Order = 13)]
        public string Chassis { get; set; }

        [DataMember(Name = "Sponsors", Order = 14)]
        public string Sponsors { get; set; }

        [DataMember(Name = "CrewChief", Order = 15)]
        public string CrewChief { get; set; }

        [DataMember(Name = "PhotoUrl", Order = 16)]
        public string PhotoUrl { get; set; }

        [DataMember(Name = "Updated", Order = 17)]
        public DateTime? Updated { get; set; }

        [DataMember(Name = "Created", Order = 18)]
        public DateTime? Created { get; set; }

    }
}

