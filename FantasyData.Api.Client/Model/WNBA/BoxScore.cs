using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.WNBA
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// Returns the game details for a given game's box score
        /// </summary>
        [Description("Returns the game details for a given game's box score")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// The details of the quarters (including overtime periods) for this game.
        /// </summary>
        [Description("The details of the quarters (including overtime periods) for this game.")]
        [DataMember(Name = "Quarters", Order = 20002)]
        public Quarter[] Quarters { get; set; }

        /// <summary>
        /// The team game stats associated with this box score
        /// </summary>
        [Description("The team game stats associated with this box score")]
        [DataMember(Name = "TeamGames", Order = 20003)]
        public TeamGame[] TeamGames { get; set; }

        /// <summary>
        /// The player game stats associated with this box score
        /// </summary>
        [Description("The player game stats associated with this box score")]
        [DataMember(Name = "PlayerGames", Order = 20004)]
        public PlayerGame[] PlayerGames { get; set; }

    }
}

