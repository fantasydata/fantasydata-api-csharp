using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Leaderboard")]
    [Serializable]
    public partial class Leaderboard
    {
        /// <summary>
        /// The details of the tournament for this leaderboard
        /// </summary>
        [Description("The details of the tournament for this leaderboard")]
        [DataMember(Name = "Tournament", Order = 10001)]
        public Tournament Tournament { get; set; }

        /// <summary>
        /// The details of the players who competed in this tournament
        /// </summary>
        [Description("The details of the players who competed in this tournament")]
        [DataMember(Name = "Players", Order = 20002)]
        public PlayerTournament[] Players { get; set; }

    }
}

