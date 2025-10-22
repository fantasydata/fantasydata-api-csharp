using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB
{
    [DataContract(Namespace="", Name="MatchupTrends")]
    [Serializable]
    public partial class MatchupTrends
    {
        /// <summary>
        /// Next scheduled game for the team with a specified opposing team
        /// </summary>
        [Description("Next scheduled game for the team with a specified opposing team")]
        [DataMember(Name = "UpcomingGame", Order = 10001)]
        public Game UpcomingGame { get; set; }

        /// <summary>
        /// The collection of team trends between each team
        /// </summary>
        [Description("The collection of team trends between each team")]
        [DataMember(Name = "TeamTrends", Order = 20002)]
        public TeamTrends[] TeamTrends { get; set; }

        /// <summary>
        /// The collection of team game trends against opponent
        /// </summary>
        [Description("The collection of team game trends against opponent")]
        [DataMember(Name = "TeamMatchupTrends", Order = 20003)]
        public TeamGameTrends[] TeamMatchupTrends { get; set; }

        /// <summary>
        /// The collection of opponent game trends against team
        /// </summary>
        [Description("The collection of opponent game trends against team")]
        [DataMember(Name = "OpponentMatchupTrends", Order = 20004)]
        public TeamGameTrends[] OpponentMatchupTrends { get; set; }

        /// <summary>
        /// The collection of last 10 game scores between each team
        /// </summary>
        [Description("The collection of last 10 game scores between each team")]
        [DataMember(Name = "PreviousGames", Order = 20005)]
        public Game[] PreviousGames { get; set; }

    }
}

