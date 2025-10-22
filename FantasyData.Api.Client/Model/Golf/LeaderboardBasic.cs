using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="LeaderboardBasic")]
    [Serializable]
    public partial class LeaderboardBasic
    {
        /// <summary>
        /// The details of the tournament for this event
        /// </summary>
        [Description("The details of the tournament for this event")]
        [DataMember(Name = "Tournament", Order = 10001)]
        public TournamentBasic Tournament { get; set; }

        /// <summary>
        /// The details of the golfers who competed in this tournament
        /// </summary>
        [Description("The details of the golfers who competed in this tournament")]
        [DataMember(Name = "Players", Order = 20002)]
        public PlayerTournamentBasic[] Players { get; set; }

    }
}

