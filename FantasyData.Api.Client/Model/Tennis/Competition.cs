using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Competition")]
    [Serializable]
    public partial class Competition
    {
        /// <summary>
        /// Unique ID of Competition
        /// </summary>
        [Description("Unique ID of Competition")]
        [DataMember(Name = "CompetitionId", Order = 1)]
        public int CompetitionId { get; set; }

        /// <summary>
        /// ID of Area in which Competition takes place.
        /// </summary>
        [Description("ID of Area in which Competition takes place.")]
        [DataMember(Name = "AreaId", Order = 2)]
        public int AreaId { get; set; }

        /// <summary>
        /// Name of Area in which Competition takes place.
        /// </summary>
        [Description("Name of Area in which Competition takes place.")]
        [DataMember(Name = "AreaName", Order = 3)]
        public string AreaName { get; set; }

        /// <summary>
        /// Gender(s) participating in this Competition.
        /// </summary>
        [Description("Gender(s) participating in this Competition.")]
        [DataMember(Name = "Gender", Order = 4)]
        public string Gender { get; set; }

        /// <summary>
        /// Name of Competition
        /// </summary>
        [Description("Name of Competition")]
        [DataMember(Name = "Name", Order = 5)]
        public string Name { get; set; }

    }
}

