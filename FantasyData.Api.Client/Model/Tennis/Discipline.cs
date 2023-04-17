using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Tennis
{
    [DataContract(Namespace="", Name="Discipline")]
    [Serializable]
    public partial class Discipline
    {
        /// <summary>
        /// Unique ID of Discipline
        /// </summary>
        [Description("Unique ID of Discipline")]
        [DataMember(Name = "DisciplineId", Order = 1)]
        public int DisciplineId { get; set; }

        /// <summary>
        /// Name of Discipline
        /// </summary>
        [Description("Name of Discipline")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

