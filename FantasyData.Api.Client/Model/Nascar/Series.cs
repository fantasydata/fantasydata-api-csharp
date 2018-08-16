using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Nascar
{
    [DataContract(Namespace="", Name="Series")]
    [Serializable]
    public partial class Series
    {
        /// <summary>
        /// The unique ID of this series
        /// </summary>
        [Description("The unique ID of this series")]
        [DataMember(Name = "SeriesID", Order = 1)]
        public int SeriesID { get; set; }

        /// <summary>
        /// The name of this series
        /// </summary>
        [Description("The name of this series")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

    }
}

