using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Series")]
    [Serializable]
    public partial class Series
    {
        [DataMember(Name = "SeriesID", Order = 1)]
        public int SeriesID { get; set; }

        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

