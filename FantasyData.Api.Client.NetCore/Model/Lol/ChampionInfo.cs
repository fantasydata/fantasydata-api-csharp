using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Lol
{
    [DataContract(Namespace="", Name="ChampionInfo")]
    [Serializable]
    public partial class ChampionInfo
    {
        /// <summary>
        /// The unique id of the champion
        /// </summary>
        [Description("The unique id of the champion")]
        [DataMember(Name = "ChampionId", Order = 1)]
        public int ChampionId { get; set; }

        /// <summary>
        /// The name of the champion
        /// </summary>
        [Description("The name of the champion")]
        [DataMember(Name = "Name", Order = 2)]
        public string Name { get; set; }

        /// <summary>
        /// The title of the champion
        /// </summary>
        [Description("The title of the champion")]
        [DataMember(Name = "Title", Order = 3)]
        public string Title { get; set; }

    }
}

