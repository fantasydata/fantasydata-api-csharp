using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Soccer
{
    [DataContract(Namespace="", Name="PlayoffAggregateScore")]
    [Serializable]
    public partial class PlayoffAggregateScore
    {
        /// <summary>
        /// The TeamID of Team A. Note: Team A is determined by the home team in the first leg, and remains set through the life of the record
        /// </summary>
        [Description("The TeamID of Team A. Note: Team A is determined by the home team in the first leg, and remains set through the life of the record")]
        [DataMember(Name = "TeamA_Id", Order = 1)]
        public int TeamA_Id { get; set; }

        /// <summary>
        /// The score, on aggregate, of Team A in the matchup. Note: Team A is determined by the home team in the first leg, and remains set through the life of the record
        /// </summary>
        [Description("The score, on aggregate, of Team A in the matchup. Note: Team A is determined by the home team in the first leg, and remains set through the life of the record")]
        [DataMember(Name = "TeamA_AggregateScore", Order = 2)]
        public int TeamA_AggregateScore { get; set; }

        /// <summary>
        /// The TeamID of Team B. Note: Team B is determined by the away team in the first leg, and remains set through the life of the record
        /// </summary>
        [Description("The TeamID of Team B. Note: Team B is determined by the away team in the first leg, and remains set through the life of the record")]
        [DataMember(Name = "TeamB_Id", Order = 3)]
        public int TeamB_Id { get; set; }

        /// <summary>
        /// The score, on aggregate, of Team B in the matchup. Note: Team B is determined by the away team in the first leg, and remains set through the life of the record
        /// </summary>
        [Description("The score, on aggregate, of Team B in the matchup. Note: Team B is determined by the away team in the first leg, and remains set through the life of the record")]
        [DataMember(Name = "TeamB_AggregateScore", Order = 4)]
        public int TeamB_AggregateScore { get; set; }

        /// <summary>
        /// The ID of the team that wins the home-and-home matchup
        /// </summary>
        [Description("The ID of the team that wins the home-and-home matchup")]
        [DataMember(Name = "WinningTeamId", Order = 5)]
        public int WinningTeamId { get; set; }

        /// <summary>
        /// Date and time the record was created (in US Eastern Time)
        /// </summary>
        [Description("Date and time the record was created (in US Eastern Time)")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the record was last updated (in US Eastern Time)
        /// </summary>
        [Description("The timestamp of when the record was last updated (in US Eastern Time)")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime Updated { get; set; }

    }
}

