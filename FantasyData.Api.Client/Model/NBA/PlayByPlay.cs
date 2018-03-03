using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NBA
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
        /// The details of the quarters associated with this play-by-play
        /// </summary>
        [Description("The details of the quarters associated with this play-by-play")]
        [DataMember(Name = "Quarters", Order = 20002)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The details of the plays associated with this play-by-play
        /// </summary>
        [Description("The details of the plays associated with this play-by-play")]
        [DataMember(Name = "Plays", Order = 20003)]
        public Play[] Plays { get; set; }

    }
}

