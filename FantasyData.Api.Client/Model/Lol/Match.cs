using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="Match")]
    [Serializable]
    public partial class Match
    {
        /// <summary>
        /// The Unique ID of the Game the match is from.
        /// </summary>
        [Description("The Unique ID of the Game the match is from.")]
        [DataMember(Name = "GameId", Order = 1)]
        public int GameId { get; set; }

        /// <summary>
        /// The match number (starts from 1)
        /// </summary>
        [Description("The match number (starts from 1)")]
        [DataMember(Name = "Number", Order = 2)]
        public int Number { get; set; }

        /// <summary>
        /// The name of the league of legends map
        /// </summary>
        [Description("The name of the league of legends map")]
        [DataMember(Name = "MapName", Order = 3)]
        public string MapName { get; set; }

        /// <summary>
        /// The TeamId of the winning Team (once a winner is found)
        /// </summary>
        [Description("The TeamId of the winning Team (once a winner is found)")]
        [DataMember(Name = "WinningTeamId", Order = 4)]
        public int? WinningTeamId { get; set; }

        /// <summary>
        /// The LoL version number as of the playing of this match
        /// </summary>
        [Description("The LoL version number as of the playing of this match")]
        [DataMember(Name = "GameVersion", Order = 5)]
        public string GameVersion { get; set; }

        /// <summary>
        /// The list of banned champions for each team (if shows champion x banned by team y then their opponent cannot select that champion)
        /// </summary>
        [Description("The list of banned champions for each team (if shows champion x banned by team y then their opponent cannot select that champion)")]
        [DataMember(Name = "MatchBans", Order = 20006)]
        public MatchBan[] MatchBans { get; set; }

        /// <summary>
        /// The list of player match stats for the given match
        /// </summary>
        [Description("The list of player match stats for the given match")]
        [DataMember(Name = "PlayerMatches", Order = 20007)]
        public PlayerMatch[] PlayerMatches { get; set; }

        /// <summary>
        /// The list of team match stats for the given match
        /// </summary>
        [Description("The list of team match stats for the given match")]
        [DataMember(Name = "TeamMatches", Order = 20008)]
        public TeamMatch[] TeamMatches { get; set; }

    }
}

