using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// The information on the entire game 
        /// </summary>
        [Description("The information on the entire game ")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// The information on the individual matches 
        /// </summary>
        [Description("The information on the individual matches ")]
        [DataMember(Name = "Matches", Order = 20002)]
        public Match[] Matches { get; set; }

    }
}

