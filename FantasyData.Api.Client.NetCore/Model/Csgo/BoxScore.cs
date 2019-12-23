using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.Csgo
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// The details of the game
        /// </summary>
        [Description("The details of the game")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// The details of the maps (best of matches)
        /// </summary>
        [Description("The details of the maps (best of matches)")]
        [DataMember(Name = "Maps", Order = 20002)]
        public Map[] Maps { get; set; }

    }
}

