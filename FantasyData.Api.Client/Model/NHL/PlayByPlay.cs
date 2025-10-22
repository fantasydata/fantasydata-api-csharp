using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NHL
{
    [DataContract(Namespace="", Name="PlayByPlay")]
    [Serializable]
    public partial class PlayByPlay
    {
        /// <summary>
        /// The details of the game associated with this play-by-play
        /// </summary>
        [Description("The details of the game associated with this play-by-play")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// List of Plays in the game
        /// </summary>
        [Description("List of Plays in the game")]
        [DataMember(Name = "Plays", Order = 20002)]
        public Play[] Plays { get; set; }

    }
}

