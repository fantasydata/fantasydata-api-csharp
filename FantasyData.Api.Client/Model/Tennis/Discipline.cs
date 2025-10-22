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
        /// The ID of associated discipline
        /// </summary>
        [Description("The ID of associated discipline")]
        [DataMember(Name = "DisciplineId", Order = 1)]
        public int DisciplineId { get; set; }

        /// <summary>
        /// The name of the discipline(Singles; Doubles; Mixed Doubles)
        /// </summary>
        [Description("The name of the discipline(Singles; Doubles; Mixed Doubles)")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

