using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.GRid
{
    [DataContract(Namespace="", Name="Metadata")]
    [Serializable]
    public partial class Metadata
    {
        /// <summary>
        /// A GUID/UUID for this metadata item
        /// </summary>
        [Description("A GUID/UUID for this metadata item")]
        [DataMember(Name = "Id", Order = 1)]
        public string Id { get; set; }

        /// <summary>
        /// The name of this metadata item
        /// </summary>
        [Description("The name of this metadata item")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

