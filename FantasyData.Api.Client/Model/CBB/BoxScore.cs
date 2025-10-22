using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
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
        /// The details of the periods (halves & overtime) for this game. Note: the scores are for that half/period only, not total score of game at that point.
        /// </summary>
        [Description("The details of the periods (halves & overtime) for this game. Note: the scores are for that half/period only, not total score of game at that point.")]
        [DataMember(Name = "Periods", Order = 20002)]
        public Period[] Periods { get; set; }

        /// <summary>
        /// The player game stats of this box score
        /// </summary>
        [Description("The player game stats of this box score")]
        [DataMember(Name = "PlayerGames", Order = 20003)]
        public PlayerGame[] PlayerGames { get; set; }

        /// <summary>
        /// The team game stats of this box score
        /// </summary>
        [Description("The team game stats of this box score")]
        [DataMember(Name = "TeamGames", Order = 20004)]
        public TeamGame[] TeamGames { get; set; }

    }
}

