using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.NHL
{
    [DataContract(Namespace="", Name="PlayByPlay")]
    [Serializable]
    public partial class PlayByPlay
    {
        /// <summary>
        /// Game Information.
        /// </summary>
        [Description("Game Information.")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// List of Plays in the game.
        /// </summary>
        [Description("List of Plays in the game.")]
        [DataMember(Name = "Plays", Order = 20002)]
        public Play[] Plays { get; set; }

    }
}

