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

        /// <summary>
        /// The stats for players across all matches
        /// </summary>
        [Description("The stats for players across all matches")]
        [DataMember(Name = "PlayerGames", Order = 20003)]
        public PlayerGame[] PlayerGames { get; set; }

        /// <summary>
        /// The stats for teams across all matches
        /// </summary>
        [Description("The stats for teams across all matches")]
        [DataMember(Name = "TeamGames", Order = 20004)]
        public TeamGame[] TeamGames { get; set; }

    }
}

