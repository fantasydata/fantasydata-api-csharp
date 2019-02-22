using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Lol
{
    [DataContract(Namespace="", Name="Standing")]
    [Serializable]
    public partial class Standing
    {
        /// <summary>
        /// The unique ID of the standing
        /// </summary>
        [Description("The unique ID of the standing")]
        [DataMember(Name = "StandingId", Order = 1)]
        public int StandingId { get; set; }

        /// <summary>
        /// The unique ID of the round
        /// </summary>
        [Description("The unique ID of the round")]
        [DataMember(Name = "RoundId", Order = 2)]
        public int RoundId { get; set; }

        /// <summary>
        /// The unique ID of the team
        /// </summary>
        [Description("The unique ID of the team")]
        [DataMember(Name = "TeamId", Order = 3)]
        public int TeamId { get; set; }

        /// <summary>
        /// The full name of the team
        /// </summary>
        [Description("The full name of the team")]
        [DataMember(Name = "Name", Order = 4)]
        public string Name { get; set; }

        /// <summary>
        /// The order of the teams in the standings
        /// </summary>
        [Description("The order of the teams in the standings")]
        [DataMember(Name = "Order", Order = 5)]
        public int? Order { get; set; }

        /// <summary>
        /// The number of games played
        /// </summary>
        [Description("The number of games played")]
        [DataMember(Name = "Games", Order = 6)]
        public int Games { get; set; }

        /// <summary>
        /// The number of wins
        /// </summary>
        [Description("The number of wins")]
        [DataMember(Name = "Wins", Order = 7)]
        public int Wins { get; set; }

        /// <summary>
        /// The number of losses
        /// </summary>
        [Description("The number of losses")]
        [DataMember(Name = "Losses", Order = 8)]
        public int Losses { get; set; }

        /// <summary>
        /// Total points accumulated
        /// </summary>
        [Description("Total points accumulated")]
        [DataMember(Name = "Points", Order = 9)]
        public int Points { get; set; }

        /// <summary>
        /// The total score for the team
        /// </summary>
        [Description("The total score for the team")]
        [DataMember(Name = "ScoreFor", Order = 10)]
        public int ScoreFor { get; set; }

        /// <summary>
        /// The total score against the team
        /// </summary>
        [Description("The total score against the team")]
        [DataMember(Name = "ScoreAgainst", Order = 11)]
        public int ScoreAgainst { get; set; }

        /// <summary>
        /// Total score differential
        /// </summary>
        [Description("Total score differential")]
        [DataMember(Name = "ScoreDifference", Order = 12)]
        public int ScoreDifference { get; set; }

        /// <summary>
        /// The name of the group (when applicable)
        /// </summary>
        [Description("The name of the group (when applicable)")]
        [DataMember(Name = "Group", Order = 13)]
        public string Group { get; set; }

    }
}

