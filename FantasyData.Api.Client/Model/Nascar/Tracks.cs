using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Tracks")]
    [Serializable]
    public partial class Tracks
    {
        /// <summary>
        /// The name of the track for this race
        /// </summary>
        [Description("The name of the track for this race")]
        [DataMember(Name = "Track", Order = 1)]
        public string Track { get; set; }

    }
}

