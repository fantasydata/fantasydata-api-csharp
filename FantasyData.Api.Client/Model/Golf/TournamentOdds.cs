using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="TournamentOdds")]
    [Serializable]
    public partial class TournamentOdds
    {
        /// <summary>
        /// The details of the tournament
        /// </summary>
        [Description("The details of the tournament")]
        [DataMember(Name = "Tournament", Order = 10001)]
        public Tournament Tournament { get; set; }

        /// <summary>
        /// The tournaments collection of PlayerTournamentOdds
        /// </summary>
        [Description("The tournaments collection of PlayerTournamentOdds")]
        [DataMember(Name = "PlayerTournamentOdds", Order = 20002)]
        public PlayerTournamentOdd[] PlayerTournamentOdds { get; set; }

    }
}

