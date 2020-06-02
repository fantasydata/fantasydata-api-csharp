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
        /// Id of one of the teams.  Team A is determined by the home team in the first leg, and remains set through the life of the record.
        /// </summary>
        [Description("Id of one of the teams.  Team A is determined by the home team in the first leg, and remains set through the life of the record.")]
        [DataMember(Name = "TeamA_Id", Order = 1)]
        public int TeamA_Id { get; set; }

        /// <summary>
        /// Aggregate score of team A.
        /// </summary>
        [Description("Aggregate score of team A.")]
        [DataMember(Name = "TeamA_AggregateScore", Order = 2)]
        public int TeamA_AggregateScore { get; set; }

        /// <summary>
        /// Id of one of the teams.  Team B is determined by the away team in the first leg, and remains set through the life of the record.
        /// </summary>
        [Description("Id of one of the teams.  Team B is determined by the away team in the first leg, and remains set through the life of the record.")]
        [DataMember(Name = "TeamB_Id", Order = 3)]
        public int TeamB_Id { get; set; }

        /// <summary>
        /// Aggregate score of team A.
        /// </summary>
        [Description("Aggregate score of team A.")]
        [DataMember(Name = "TeamB_AggregateScore", Order = 4)]
        public int TeamB_AggregateScore { get; set; }

        /// <summary>
        /// Team Id of the team which wins the home-and-home matchup.
        /// </summary>
        [Description("Team Id of the team which wins the home-and-home matchup.")]
        [DataMember(Name = "WinningTeamId", Order = 5)]
        public int WinningTeamId { get; set; }

        /// <summary>
        /// Date and time the record was created.
        /// </summary>
        [Description("Date and time the record was created.")]
        [DataMember(Name = "Created", Order = 6)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Date and time the record was updated.
        /// </summary>
        [Description("Date and time the record was updated.")]
        [DataMember(Name = "Updated", Order = 7)]
        public DateTime Updated { get; set; }

    }
}

