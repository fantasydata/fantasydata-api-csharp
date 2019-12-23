﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.NetCore.Model.CBB
{
    [DataContract(Namespace="", Name="BoxScore")]
    [Serializable]
    public partial class BoxScore
    {
        /// <summary>
        /// The game details of this box score
        /// </summary>
        [Description("The game details of this box score")]
        [DataMember(Name = "Game", Order = 10001)]
        public Game Game { get; set; }

        /// <summary>
        /// The period details of this box score
        /// </summary>
        [Description("The period details of this box score")]
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

