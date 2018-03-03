using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf
{
    [DataContract(Namespace="", Name="Leaderboard")]
    [Serializable]
    public partial class Leaderboard
    {
        [DataMember(Name = "Tournament", Order = 10001)]
        public Tournament Tournament { get; set; }

        [DataMember(Name = "Players", Order = 20002)]
        public PlayerTournament[] Players { get; set; }

    }
}

