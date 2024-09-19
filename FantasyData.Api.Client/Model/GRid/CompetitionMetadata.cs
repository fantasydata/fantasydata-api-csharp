using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="CompetitionMetadata")]
    [Serializable]
    public partial class CompetitionMetadata
    {
        /// <summary>
        /// The associated Sport that this competition applies to
        /// </summary>
        [Description("The associated Sport that this competition applies to")]
        [DataMember(Name = "Sport", Order = 10001)]
        public Metadata Sport { get; set; }

        /// <summary>
        /// A GUID/UUID for this metadata item
        /// </summary>
        [Description("A GUID/UUID for this metadata item")]
        [DataMember(Name = "Id", Order = 2)]
        public string Id { get; set; }

        /// <summary>
        /// The name of this metadata item
        /// </summary>
        [Description("The name of this metadata item")]
        [DataMember(Name = "Name", Order = 3)]
        public string Name { get; set; }

    }
}

